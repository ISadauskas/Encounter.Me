using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Trails
    {
        [Key]
        public int TrailId { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Length { get; set; }
        public DateTime Timestamp { get; set; }
        public string Location { get; set; }
        public string Organizer { get; set; }
    }
}
