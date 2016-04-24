using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmsApp.Models
{
    public class Reviews
    {
        public int ReviewsId { get; set; }
        public int UserId { get; set; }
        public int AbstractId { get; set; }
        public int SubmittedInd { get; set; }
        public string ReviewText { get; set; }
    }
}