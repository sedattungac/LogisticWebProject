using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Importance { get; set; }
        public string Type { get; set; }
    }
}
