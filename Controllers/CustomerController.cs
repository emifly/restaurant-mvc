using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers;

public class CustomerController : Controller
{
    [HttpGet("[controller]/{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        // Hard-coded for now
        var customer = new Customer
        {
            Id = id,
            Name = "Emily",
            PastOrders = [
                "margherita",
                "carbonara",
            ],
        };
        return View("~/Views/Customer/Details.cshtml", customer);
    }
}
