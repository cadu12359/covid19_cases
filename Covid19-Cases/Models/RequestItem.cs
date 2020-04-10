using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Cases.Models
{
    public class RequestItem
    {
        public string country { get; set; }
        public List<Item>  latest_stat_by_country { get; set; }
    }
}
