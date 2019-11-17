using FurnitureShop.Models;
using System.Collections.Generic;


namespace FurnitureShop.ViewModels
{
    public class HomeIndexVM
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
        public List<Image> Images { get; set; }
    }
}
