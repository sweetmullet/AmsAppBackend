using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmsApp.Models
{
    public class Keyword
    {
        public int KeywordId { get; set; }
        public int AbstractId { get; set; }
        public string KeywordString { get; set; }
    }
}