using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public class Runs
    {
        [Key]
        public int RunId { get; set; }
        public string Pace { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Distance { get; set; }
        public int CaloriesLost { get; set; }
        public string User { get; set; }
    }
}
