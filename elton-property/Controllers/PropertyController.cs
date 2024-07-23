using elton_property.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace elton_property.Controllers
{
    public class PropertyController : Controller
    {
        private readonly ILogger<PropertyController> _logger;

        public PropertyController(ILogger<PropertyController> logger)
        {
            _logger = logger;
        }

        public IActionResult PropertyList()
        {
            return View();
        }
    }
}
