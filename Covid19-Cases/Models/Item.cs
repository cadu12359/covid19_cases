using System;

namespace Covid19_Cases.Models
{
    public class Item
    {
        public int id { get; set; }
        public string country_name { get; set; }
        public string total_cases { get; set; }
        public string new_cases { get; set; }
        public string active_cases { get; set; }
        public string total_deaths { get; set; }
        public string new_deaths { get; set; }
        public string total_recovered { get; set; }
        public string serious_critical { get; set; }
    }
}