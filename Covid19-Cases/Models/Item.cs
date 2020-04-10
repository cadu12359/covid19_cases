using System;

namespace Covid19_Cases.Models
{
    public class Item
    {
        public int id { get; set; }
        public string country_name { get; set; }
        public float total_cases { get; set; }
        public int new_cases { get; set; }
        public float active_cases { get; set; }
        public float total_deaths { get; set; }
        public float new_deaths { get; set; }
        public float total_recovered { get; set; }
        public float serious_critical { get; set; }
    }
}