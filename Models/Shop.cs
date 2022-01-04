using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WomenShop.Models
{
    public class Shop
    {
        public int Id { get; set; }

       
        [Required]
        [StringLength(20)]
        public string? Catagory { get; set; }

        [StringLength(10)]
        public string Size { get; set; }


        //[DataType(DataType.Currency)]
        public int Quantity { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }


        //[DataType(DataType.)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Price { get; set; }


        [StringLength(100)]
        [Required]
        public string ImagePath { get; set; }
    }
}
