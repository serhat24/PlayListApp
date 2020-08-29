using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Musik
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Lied")]
        public string Name { get; set; }
        public string Sänger_in { get; set; }

    }
}