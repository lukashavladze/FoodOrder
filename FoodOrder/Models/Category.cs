using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace FoodOrder.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]

        public string Title { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string Description { get; set; }

        public List<Item> Items { get; set; } = new List<Item>();


    }
}
