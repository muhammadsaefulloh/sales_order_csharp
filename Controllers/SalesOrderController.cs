using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalesOrder.Data;
using SalesOrder.Models;
using SalesOrder.ViewModels;
using Newtonsoft.Json;


namespace MSaefullohTechnicalTest.Controllers;

public class SalesOrderController(ApplicationDbContext db) : Controller
{
    private ApplicationDbContext _db = db;

    public IActionResult Index()
    {
        var salesOrder = _db.SalesOrder.ToList();
        return View(salesOrder);
    }
    // public IActionResult Create()
    // {
    //     return View();
    // }
    public IActionResult Create()
    {
        var viewModel = new CreateSalesOrderViewModel
        {
            SalesOrderViewModel = new SalesOrderViewModel
            {
                Product = _db.Product.ToList(),
                Customer = _db.Customer.ToList()
            },
            SalesOrderEntity = new SalesOrderEntity
            {
                OrderDate = DateTime.Today
            }
        };

        return View(viewModel);
    }
    [HttpPost]
    public IActionResult CreateSalesOrder(SalesOrderEntity data)
    {
        var lastSalesOrder = _db.SalesOrder.OrderByDescending(so => so.OrderDate).FirstOrDefault();
        string? maxSalesOrderNoString = lastSalesOrder?.SalesOrderNo;
        var SOData = "";
        if (!string.IsNullOrEmpty(maxSalesOrderNoString))
        {
            string numericPart = maxSalesOrderNoString.Substring(3);
            if (int.TryParse(numericPart, out int maxSalesOrderNo))
            {
                maxSalesOrderNo++;
                SOData = "SO" + maxSalesOrderNo.ToString("D4");
            }
            else
            {
            }
        }
        else
        {
            SOData = "SO0001";
        }

        data.SalesOrderNo = SOData;
        data.OrderDate = DateTime.Now;
        // data.Price =(get from table price)
        DateTime currentDate = DateTime.Now;

        // Retrieve the Price for the given ProductCode where the current date is between PriceValidateFrom and PriceValidateTo
        var price = _db.Price
            .Where(p => p.ProductCode == data.ProductCode && p.PriceValidateFrom <= currentDate && p.PriceValidateTo >= currentDate)
            .FirstOrDefault();
        if (price != null)
        {
            data.Price = price.PriceValue;
        }
        else
        {
            data.Price = 0;
        }


        _db.SalesOrder.Add(data);
        // _db.SalesOrderInterface.Add(data);
        var salesOrderInterfaceData = new SalesOrderInterfaceEntity
        {
            SalesOrderNo = SOData,
        };
        var jsonData = JsonConvert.SerializeObject(data);
        salesOrderInterfaceData.Payload = jsonData;

        // Add data to the SalesOrderInterface table
        _db.SalesOrderInterface.Add(salesOrderInterfaceData);
        _db.SaveChanges();
        TempData["SuccessMessage"] = "Data has been inserted successfully";
        return RedirectToAction("Create");
    }
}