using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmsApp.Models
{
    public class RoleOperation
    {
        public int RoleOperationId { get; set; }
        public int RoleId { get; set; }
        public virtual ICollection<Operation> OperationId { get; set; }
        
    }
}