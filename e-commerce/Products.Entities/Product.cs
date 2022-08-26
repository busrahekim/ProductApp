using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Entities
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId { get; set; }
        public string productName { get; set; }
        public string productCategory { get; set; }
        public string productTag { get; set; }
        public string productQuantity { get; set; }
        public string productPrice { get; set; }
        public string productCreatedAt { get; set; }
        
    }
}
