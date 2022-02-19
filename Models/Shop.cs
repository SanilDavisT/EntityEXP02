using System.ComponentModel.DataAnnotations;

namespace EntityEXP02.Models
{
    public class Shop
    {

        [Key]
        public string item { get; set; }
        public string color { get; set; }

        public int rate { get; set; }


    }
}
