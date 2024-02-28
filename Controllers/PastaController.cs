using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;

namespace Restaurant.Controllers;

public class PastaController : Controller
{
    public IActionResult Carbonara()
    {
        var carbonaraDish = new PastaDish
        {
            Name = "Carbonara",
            Ingredients = [
                "Eggs",
                "Cheese",
                "Ham",
                "Mushrooms",
            ],
        };
        return View(carbonaraDish);
    }

    public IActionResult Bolognese()
    {
        var bologneseDish = new PastaDish
        {
            Name = "bolognese",
            Ingredients = [
                "Tomato sauce",
                "Carrots",
                "Mince",
                "Cheese",
            ],
        };
        return View(bologneseDish);
    }
}
