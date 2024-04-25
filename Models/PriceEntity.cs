using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SalesOrder.Models;

public class PriceEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Add this attribute to make it an auto-generated key
    public int PriceId { get; set; } // Define a primary key property

    [MaxLength(10)]
    [ForeignKey("ProductCode")] // Specify the name of the navigation property
    public string ProductCode { get; set; } // Assuming this is your foreign key property

    public decimal PriceValue { get; set; }
    public DateTime PriceValidateFrom { get; set; }
    public DateTime PriceValidateTo { get; set; }
}
