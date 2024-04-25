using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesOrder.Models
{
    public class SalesOrderEntity
    {
        [Key]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Sales order number is required")]
        [MaxLength(10)] 
        public string SalesOrderNo { get; set; }

        [Required(ErrorMessage = "Customer code is required")]
        [MaxLength(10)] 
        public string CustCode { get; set; }

        [MaxLength(10)]
        [ForeignKey("ProductCode")] // Specify the name of the foreign key property
        public string ProductCode { get; set; }

        public int Qty { get; set; }
        public decimal Price { get; set; }
    }
}
