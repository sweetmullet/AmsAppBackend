using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmsApp.Models
{
    public class AbstractCategory
    {
        public int AbstractCategoryId { get; set; }
        public virtual ICollection<Category> CategoryId { get; set; }
        //public int CategoryIdId { get; set; }
        public virtual ICollection<Abstracts> AbstactsId { get; set; }
    }
}