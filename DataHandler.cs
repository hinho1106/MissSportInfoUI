using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissSportInfoUI
{
    public static class DataHandler
    {
        static JSONVenueClass.VenueObj venueObj;
        static JSONEventClass.EventObj eventObj;

        public static bool Initialization() //true if it's ready to start UI, false else
        {
            
            
            //Get event ids from POST API
            string venueInfos = HTTPHandler.POSTMissVenues();
            if (!venueInfos.Equals(""))
            {
                try
                {
                    venueObj = JsonConvert.DeserializeObject<JSONVenueClass.VenueObj>(venueInfos);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }

                //generate payload for next API call (getting all events)
                string venueCodes = "";
                foreach(JSONVenueClass.Center centre in venueObj.body.center)
                {
                    venueCodes = venueCodes + centre.id  + ", ";
                }
                venueCodes = venueCodes.Substring(0, venueCodes.Length - 2);
                //Console.Write(venueCodes);
                
                //Get EventInfos from POST API
                string eventInfos = HTTPHandler.POSTMissEvents(venueCodes);

                if (!eventInfos.Equals(""))
                {
                    try
                    {
                        eventObj = JsonConvert.DeserializeObject<JSONEventClass.EventObj>(eventInfos);
                    }
                    catch (Exception ex) {
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
                else
                    return false;
                
                
            }
            else
                return false;

            return true;
        }

        public static List<string> GetAllVenues()
        {
            List<string> venues = new List<string>();
            venues.Add("(All)");
            foreach (JSONVenueClass.Center centre in venueObj.body.center)
            {
                venues.Add(centre.name);
            }
            return venues;
        }

        public static List<EventInfo> processData(string venue, string sport, string day)
        {
            //general variables
            bool controlFlag = true;
            List<EventInfo> infoTable = new List<EventInfo>();
            List<JSONEventClass.Event> targetedVenueEvents = new List<JSONEventClass.Event>();
            string venueText, eventText, dayText, timeText;
            string startTime, endTime;

            //matching venue
            if (venue.Equals("(All)"))
            {
                foreach (JSONEventClass.CenterEvent centreEvent in eventObj.body.center_events)
                {
                    targetedVenueEvents.AddRange(centreEvent.events);
                }
            }
            else
            {
                foreach (JSONEventClass.CenterEvent centreEvent in eventObj.body.center_events)
                {
                    //matching venue
                    if (venue.Equals(centreEvent.center_name))
                    {
                        targetedVenueEvents.AddRange(centreEvent.events);
                    }
                }
            }

            foreach (JSONEventClass.Event targetedEvent in targetedVenueEvents) {
                venueText = targetedEvent.facilities.First<JSONEventClass.Facility>().center_name;
                eventText = targetedEvent.title;
                startTime = targetedEvent.start_time;
                startTime = startTime.Substring(0, startTime.Length - 3);
                endTime = targetedEvent.end_time;
                endTime = endTime.Substring(0, endTime.Length - 3);
                dayText = startTime.Split(" ")[0];
                timeText = startTime.Split(" ")[1] + " - " + endTime.Split(" ")[1];

                //filter day
                if (!day.Equals(dayText))
                {
                    continue;
                }

                //filter by search words
                if (!eventText.Contains(sport))
                {
                    continue;
                }

                infoTable.Add(new EventInfo(){
                    venue = venueText, events = eventText, day = dayText, time = timeText });
            }

            return infoTable;
        }
    }
}
