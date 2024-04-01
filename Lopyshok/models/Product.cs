using System.Collections.Generic;

namespace Lopyshok.models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Article { get; set; }
        public string ProductTypeName { get; set; }
        public string ImagePath { get; set; }
        public int WorkShopNumber { get; set; }
        public int CountOfPeople { get; set; } 
        public decimal MinimumCost { get; set; } 
        public List<Material> Materials { get; set; }

        public Product() { }
    }
}
