using Microsoft.AspNetCore.Mvc;
using SoapMvcApp.Models;
using System.Collections.Generic;

public class SoapController : Controller
{
    public IActionResult Index()
    {
        var soaps = new List<Soap>
        {
            new Soap { Id = 1, Name = "Lavender Bliss", Scent = "Lavender", Price = 5.99m, Description = "A calming lavender-scented soap." },
            new Soap { Id = 2, Name = "Citrus Splash", Scent = "Citrus", Price = 4.99m, Description = "A refreshing citrus-scented soap." },
            new Soap { Id = 3, Name = "Minty Fresh", Scent = "Mint", Price = 6.99m, Description = "An invigorating mint-scented soap." }
        };
        return View(soaps);
    }
}
