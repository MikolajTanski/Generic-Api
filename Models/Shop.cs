using System.Collections.Generic;

namespace zadanie.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
