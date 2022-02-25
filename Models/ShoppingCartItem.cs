using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LPApi.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCartId { get; set; }

      
        public int ProductId { get; set; }
        public int Qty { get; set; }

        [NotMapped]
        public string? Name { get; set; }
        [NotMapped]
        public string? Pic { get; set; }
        [NotMapped]
        public double Price { get; set; }
        public double Amount { get; set; }  //per item

      
        public int UserId { get; set; }
     
    }
}
