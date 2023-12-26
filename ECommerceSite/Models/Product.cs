using System.ComponentModel.DataAnnotations;

namespace ECommerceSite.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Range(0, double.MaxValue)]
        public double Price { get; set; }

        public Product()
        {
            Name = "Default";
            Category = "Other";
            Price = 0.0;
        }

        public Product(string name, string category, double price)
        {
            Name = name;
            Category = category;
            Price = price;
        }
    }

    public class CartItemViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
