using System.ComponentModel.DataAnnotations;

namespace EntityEXP02.Models
{
    public class Shop2
    {

        [Key]
        public string item { get; set; }
        public string color { get; set; }

        public int rate { get; set; }

    }
}
