using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmsApp.Models
{
    public class EventCategories
    {
        public int EventCategoriesId { get; set; }
        public int CategoryId { get; set; }
        public int EventId { get; set; }
    }
}