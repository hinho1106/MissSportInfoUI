using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissSportInfoUI
{
    //JSON format for macro info
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    internal class JSONEventClass
    {
        public class Body
        {
            public List<CenterEvent> center_events { get; set; }
        }

        public class CenterEvent
        {
            public int center_id { get; set; }
            public string center_name { get; set; }
            public List<Event> events { get; set; }
            public int total { get; set; }
            public string extra_notes { get; set; }
        }

        public class Event
        {
            public string title { get; set; }
            public string start_time { get; set; }
            public string end_time { get; set; }
            public int event_type { get; set; }
            public string description { get; set; }
            public int event_item_id { get; set; }
            public bool online_new_activity { get; set; }
            public string activity_detail_url { get; set; }
            public string activity_location_desc { get; set; }
            public List<Facility> facilities { get; set; }
            public int reservation_event_type_id { get; set; }
            public Price price { get; set; }
            public List<object> instructors { get; set; }
            public object background_color { get; set; }
            public object text_color { get; set; }
        }

        public class Facility
        {
            public int facility_id { get; set; }
            public string facility_name { get; set; }
            public int center_id { get; set; }
            public string center_name { get; set; }
            public bool is_center_valid { get; set; }
            public List<object> event_type_ids { get; set; }
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

        public class Price
        {
            public bool? show_price_info_online { get; set; }
            public string? estimate_price { get; set; }
            public List<object>? prices { get; set; }
            public List<object>? registration_type_prices { get; set; }
            public string? private_lesson_enroll_now { get; set; }
            public bool? not_allow_online_team_enroll { get; set; }
            public object? search_from_price { get; set; }
            public string? search_from_price_desc { get; set; }
            public bool? free { get; set; }
            public bool? simple_fee { get; set; }
            public bool? is_package { get; set; }
        }

        public class EventObj
        {
            public Headers headers { get; set; }
            public Body body { get; set; }
        }
    }
    


}
