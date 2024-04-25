using System.ComponentModel.DataAnnotations;

namespace SalesOrder.Models;
public class ProductEntity
{
    [Key]
    [MaxLength(10)]
    public string ProductCode { get; set; }
    [MaxLength(225)]
    public string ProductName { get; set; }
}
