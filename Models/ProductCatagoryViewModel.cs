using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WomenShop.Models
{
    public class ProductCatagoryViewModel
    {
        public List<Shop>? Shops { get; set; }
        public SelectList? Catagories { get; set; }
        public string? ProductCatagory { get; set; }
        public string? SearchString { get; set; }
    }
}