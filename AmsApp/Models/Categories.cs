using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmsApp.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryTitle { get; set; }
        public string CategoryDesc { get; set; }
        public int CategoryActiveInd { get; set; }
    }
}