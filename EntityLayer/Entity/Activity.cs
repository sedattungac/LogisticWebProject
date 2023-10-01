using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Importance { get; set; }
        public string Status { get; set; }

        //TARİH
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime EndTime { get; set; }
    }
}
