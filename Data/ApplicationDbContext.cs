namespace SalesOrder.Data;
using Microsoft.EntityFrameworkCore;
using SalesOrder.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }
    public DbSet<ProductEntity> Product {get; set;}
    public DbSet<CustomerEntity> Customer {get; set;}
    public DbSet<PriceEntity> Price {get; set;}
    public DbSet<SalesOrderEntity> SalesOrder {get; set;}
    public DbSet<SalesOrderInterfaceEntity> SalesOrderInterface {get; set;}
}
