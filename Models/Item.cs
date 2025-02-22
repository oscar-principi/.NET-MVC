
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required double Price { get; set; }
    }
}
