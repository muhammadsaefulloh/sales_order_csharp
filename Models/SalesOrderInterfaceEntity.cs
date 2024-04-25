using System.ComponentModel.DataAnnotations;

namespace SalesOrder.Models;
public class SalesOrderInterfaceEntity
{
    [Key]
    [MaxLength(10)]
    public string SalesOrderNo { get; set; }
    [MaxLength(225)]
    public string Payload  { get; set; }
}