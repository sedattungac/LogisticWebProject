using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class Offer
    {
        //Teklif
        [Key]
        public int OfferId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public string Status { get; set; }
        public string Representative { get; set; }
        public string Customer { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
    }
}
