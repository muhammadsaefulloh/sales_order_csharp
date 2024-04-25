using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalesOrder.Data;
using SalesOrder.Models;

namespace MSaefullohTechnicalTest.Controllers;

public class ProductController : Controller
{
    private ApplicationDbContext _db;

    public ProductController(ApplicationDbContext db)
    {
        _db = db;

    }

    public IActionResult Index()
    {
        var product = _db.Product.ToList();
        return View(product);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateProduct(ProductEntity product)
    {
        _db.Product.Add(product);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
}