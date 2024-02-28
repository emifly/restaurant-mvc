using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;

namespace Restaurant.Controllers;

public class PizzaController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Margherita()
    {
        var margheritaPlate = new PizzaPlate
        {
            Name = "margherita",
            Ingredients = [
                "Tomato sauce",
                "Cheese",
                "Basil",
            ],
        };
        return View(margheritaPlate);
    }
}
