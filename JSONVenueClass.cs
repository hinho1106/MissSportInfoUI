using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissSportInfoUI
{
    internal class JSONVenueClass
        {

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Activity
        {
            public int id { get; set; }
            public string name { get; set; }
            public int category_id { get; set; }
            public int sub_category_id { get; set; }
            public List<int> center_ids { get; set; }
        }

        public class ActivityCategory
        {
            public int id { get; set; }
            public string name { get; set; }
            public List<int> centerIds { get; set; }
        }

        public class ActivityCenter
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class ActivitySubCategory
        {
            public int id { get; set; }
            public string name { get; set; }
            public List<int> centerIds { get; set; }
        }

        public class Body
        {
            public List<Center> center { get; set; }
            public List<Activity> activity { get; set; }
            public List<ActivityCategory> activity_category { get; set; }
            public List<Facility> facilities { get; set; }
            public CalendarPeriod calendar_period { get; set; }
            public List<object> event_types { get; set; }
            public List<ActivityCenter> activity_center { get; set; }
            public List<ActivitySubCategory> activity_sub_category { get; set; }
            public List<object> permit_center { get; set; }
        }

        public class CalendarPeriod
        {
            public string start_date { get; set; }
            public string end_date { get; set; }
        }

        public class Center
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Facility
        {
            public int facility_id { get; set; }
            public string facility_name { get; set; }
            public int center_id { get; set; }
            public string center_name { get; set; }
            public bool is_center_valid { get; set; }
            public List<int> event_type_ids { get; set; }
        }

        public class Headers
        {
            public object sessionRefreshedOn { get; set; }
            public int sessionExtendedCount { get; set; }
            public string response_code { get; set; }
            public string response_message { get; set; }
            public PageInfo page_info { get; set; }
        }

        public class PageInfo
        {
            public string order_by { get; set; }
            public string order_option { get; set; }
            public int total_page { get; set; }
            public int total_records_per_page { get; set; }
            public int page_number { get; set; }
            public int total_records { get; set; }
        }

        public class VenueObj
        {
            public Headers headers { get; set; }
            public Body body { get; set; }
        }


    }
}
