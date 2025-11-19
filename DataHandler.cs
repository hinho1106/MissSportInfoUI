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
        static List<EventInfo> sportInfos = new List<EventInfo>();
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

        public static List<EventInfo>
    }
}
