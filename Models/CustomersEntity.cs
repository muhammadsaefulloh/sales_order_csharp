using System.ComponentModel.DataAnnotations;

namespace SalesOrder.Models;
public class CustomerEntity
{
    [Key]
    [MaxLength(10)]
    public required string CustId { get; set; }
    [MaxLength(50)]
    public required string CustName { get; set; }
}
