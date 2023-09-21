using System.ComponentModel;

namespace FoodOrder.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public int ItemTypeID { get; set; }

        public virtual Category Category { get; set; }

        public virtual ItemType ItemType { get; set; }


    }
}
