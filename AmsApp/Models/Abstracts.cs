using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmsApp.Models
{
    public class Abstracts
    {
        
        public int AbstractsId { get; set; }

        public string AbstractTitle { get; set; }
        public string AbstractBody { get; set; }
        public int IsReviewedInd { get; set; }
        public int EventId { get; set; }
        public string SubmitterFirstName { get; set; }
        public string SubmitterLastName { get; set; }
        public string SubmitterEmail { get; set; }
        public int SubmissionTypeId { get; set; }
    }
}