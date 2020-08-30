using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Musik:BaseModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Lied")]
        public string Name { get; set; }
        public string Sänger_in { get; set; }

    }
}