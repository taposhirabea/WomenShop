using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WomenShop.Data;
using System;
using System.Linq;

namespace WomenShop.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WomenShopContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WomenShopContext>>()))
            {
                // Look for any movies.
                if (context.Shop.Any())
                {
                    return;   // DB has been seeded
                }

                context.Shop.AddRange(
                    new Shop
                    {
                        ImagePath = "bag1.jpg",
                        Catagory = "Bag",
                        Size = "",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 400M
                    },

                    new Shop
                    {
                        ImagePath = "bag2.jpg",
                        Catagory = "Bag",
                        Size = "M",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 2800M
                    },

                    new Shop
                    {
                        ImagePath = "bag3.jpg",
                        Catagory = "Bag",
                        Size = "L",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 3000M
                    },

                    new Shop
                    {
                        ImagePath = "bag4.jpg",
                        Catagory = "Bag",
                        Size = "L",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 1000M
                    },
                    new Shop
                    {
                        ImagePath = "cap1.jpg",
                        Catagory = "Cap",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 700M
                    },
                    new Shop
                    {
                        ImagePath = "cap2.jpg",
                        Catagory = "Cap",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 200M
                    },
                    new Shop
                    {
                        ImagePath = "cap3.jpg",
                        Catagory = "Cap",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 150M
                    },
                    new Shop
                    {
                        ImagePath = "dress1.jpg",
                        Catagory = "Dress",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha.",
                        Price = 450M
                    },
                    new Shop
                    {
                        ImagePath = "dress2.jpg",
                        Catagory = "Dress",
                        Size = "M",
                        Quantity = 1,
                        Description = "D",
                        Price = 1200M
                    },
                    new Shop
                    {
                        ImagePath = "dress3.jpg",
                        Catagory = "Dress",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha.",
                        Price = 600M
                    },
                    new Shop
                    {
                        ImagePath = "dress4",
                        Catagory = "Dress",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha.",
                        Price = 170M
                    },
                    new Shop
                    {
                        ImagePath = "jacket1.jpg",
                        Catagory = "Jacket",
                        Size = "M",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 600M
                    },

                    new Shop
                    {
                        ImagePath = "jacket2.jpg",
                        Catagory = "Jacket",
                        Size = "L",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 400M
                    },

                    new Shop
                    {
                        ImagePath = "jacket3.jpg",
                        Catagory = "Jacket",
                        Size = "L",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 400M
                    },
                    new Shop
                    {
                        ImagePath = "scarf1.jpg",
                        Catagory = "Scarf",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 700M
                    },
                    new Shop
                    {
                        ImagePath = "scarf2.jpg",
                        Catagory = " Scarf",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 200M
                    },
                    new Shop
                    {
                        ImagePath = "scarf3.jpg",
                        Catagory = "Scarf",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 150M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}