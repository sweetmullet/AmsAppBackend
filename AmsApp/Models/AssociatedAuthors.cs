using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmsApp.Models
{
    public class AssociatedAuthors
    {
        public int AssociatedAuthorsId { get; set; }
        public int AbstractId { get; set; }
        public int AuthorId { get; set; }
    }
}