using Lab07.Data;
using Microsoft.AspNetCore.Mvc;

namespace Lab07.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            var data = _context.Suppliers != null ? _context.Suppliers.ToList() :

            new List<Supplier>();

            return View(data);
        }
        private readonly MvcNiieLabContext _context;

        public SupplierController(MvcNiieLabContext context)
        {
            _context = context;
        }
    }
}
