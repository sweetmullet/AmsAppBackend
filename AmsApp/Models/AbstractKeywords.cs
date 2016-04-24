using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmsApp.Models
{
    public class AbstractKeywords
    {
        public int AbstractKeywordsId { get; set; }
        public int AbstractId { get; set; }
        public int KeywordsId { get; set; }
    }
}