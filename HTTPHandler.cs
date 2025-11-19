using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using ABI.System;
using Newtonsoft.Json;

namespace MissSportInfoUI
{
    internal static class HTTPHandler
    {
        public static string POSTMissVenues()
        {
            HttpClient client = new HttpClient();
            const string url = "https://anc.ca.apm.activecommunities.com/activemississauga/rest/onlinecalendar/filters?locale=en-US";
            const string payload = "{\"calendar_id\":1}";
            try
            {
                StringContent content = new StringContent(payload, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync(url, content).Result;

                response.EnsureSuccessStatusCode(); // Throws if not a 2xx status code

                string responseBody = response.Content.ReadAsStringAsync().Result;
                //Console.WriteLine("Response from POST request:");
                //Console.WriteLine(responseBody);
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Request error: {e.Message}");
                return "";
            }
        }

        public static string POSTMissEvents(string venueCodes)
        {
            HttpClient client = new HttpClient();
            const string url = "https://anc.ca.apm.activecommunities.com/activemississauga/rest/onlinecalendar/multicenter/events?locale=en-US";
            string payload = "{ \"calendar_id\":1,\"center_ids\":["+ venueCodes +"],\"display_all\":0,\"search_start_time\":\"\",\"search_end_time\":\"\",\"facility_ids\":[],\"activity_category_ids\":[],\"activity_sub_category_ids\":[],\"activity_ids\":[],\"activity_min_age\":null,\"activity_max_age\":null,\"event_type_ids\":[]}";
            //const string JSONStringPayload2 = "{ \"calendar_id\":1,\"center_ids\":[290, 248],\"display_all\":0,\"search_start_time\":\"\",\"search_end_time\":\"\",\"facility_ids\":[],\"activity_category_ids\":[],\"activity_sub_category_ids\":[],\"activity_ids\":[],\"activity_min_age\":null,\"activity_max_age\":null,\"event_type_ids\":[]}";
            try
            {
                StringContent content = new StringContent(payload, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync(url, content).Result;

                response.EnsureSuccessStatusCode(); // Throws if not a 2xx status code

                string responseBody = response.Content.ReadAsStringAsync().Result;
                //Console.WriteLine("Response from POST request:");
                //Console.WriteLine(responseBody);
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Request error: {e.Message}");
                return "";
            }
        }

        public static async Task<string> GETNonIceSportGeneralResponse()
        {
            HttpClient client = new HttpClient();

            const string url = "https://services3.arcgis.com/b9WvedVPoizGfvfD/arcgis/rest/services/COT_Sports_Drop_In_View/FeatureServer/0/query?f=json&where=show_on_sports_map%20=%20%27Yes%27&returnGeometry=true&spatialRel=esriSpatialRelIntersects&outFields=*&outSR=102100&resultOffset=0&resultRecordCount=4000";
            HttpResponseMessage response = await client.GetAsync(url);


            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine("Request Success");
                return await response.Content.ReadAsStringAsync();

            }
            else
            {
                MessageBox.Show("Request failed with status code: " + response.StatusCode);
                return "";

            }

        }

        public static async Task<string> GETNonIceSportInfo(int centreID, string week)
        {
            HttpClient client = new HttpClient();


            string url = "https://www.toronto.ca/data/parks/live/locations/" + centreID + "/sports/week" + week + ".json";

            HttpResponseMessage response = await client.GetAsync(url);


            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine("Request Success");
                //Console.WriteLine();
                return await response.Content.ReadAsStringAsync();

            }
            else
            {
                //MessageBox.Show("Request failed with status code: " + response.StatusCode);
                return "";

            }
        }

        public static async Task<string> GETIceSportGeneralResponse()
        {
            HttpClient client = new HttpClient();

            const string url = "https://services3.arcgis.com/b9WvedVPoizGfvfD/arcgis/rest/services/Skate_Locations_v2/FeatureServer/0/query?f=json&where=Show_On_Map%20=%20%27Yes%27&returnGeometry=true&spatialRel=esriSpatialRelIntersects&outFields=*&outSR=102100&resultOffset=0&resultRecordCount=4000";

            HttpResponseMessage response = await client.GetAsync(url);


            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine("Request Success");
                return await response.Content.ReadAsStringAsync();

            }
            else
            {
                MessageBox.Show("Request failed with status code: " + response.StatusCode);
                return "";

            }


        }

        public static async Task<string> GETIceSportInfo(int locationID, string week)
        {
            HttpClient client = new HttpClient();

            string url = "https://www.toronto.ca/data/parks/live/locations/" + locationID + "/skate/week" + week + ".json";

            HttpResponseMessage response = await client.GetAsync(url);


            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine("Request Success");
                return await response.Content.ReadAsStringAsync();

            }
            else
            {
                //MessageBox.Show("Request failed with status code: " + response.StatusCode +"\nLocationID: " + locationID);
                return "";

            }



        }
    }
}
