using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class CustomerGroup
    {
        [Key]
        public int CustomerGroupId { get; set; }
        public string CustomerGroupName { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
