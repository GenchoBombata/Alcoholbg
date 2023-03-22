using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Alcoholbg.Domain
{
    public class Product
    {
        public int id { get; set; }
        [Required]
        [MaxLength(30)]
        public string ProductName { get; set; }
        [Required]
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string Picture { get; set; }
        [Required]
        [Range(0,5000)]
        public int Quantity { get; set; }
        [Required]
        [Range(0, 5000)]
        public decimal Price { get; set; }
        [Required]
        [Range(0,100)]
        public decimal Discount { get; set; }
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; } = new List<Order>();
    }
}