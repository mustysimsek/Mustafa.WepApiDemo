using System;
using System.ComponentModel.DataAnnotations;

namespace Support.Domain.Entities
{
    public class Product
    {
        [Key]
        public int PKProductId { get; set; }
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public int FKCategoryId { get;set; }
        public DateTime CreatedOn { get; set; }  
    }
}
