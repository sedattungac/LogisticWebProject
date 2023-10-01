using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string RecordType { get; set; }
        public string Telephone { get; set; }
        public string Representative { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ContactDate { get; set; }
        public int CustomerGroupId { get; set; }
        public virtual CustomerGroup CustomerGroup { get; set; }
    }
}
