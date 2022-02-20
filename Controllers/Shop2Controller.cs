using EntityEXP02.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityEXP02.Controllers
{
    public class Shop2Controller : Controller
    {
        ShopDbContext _context;
       

        public Shop2Controller(ShopDbContext context)
        {
          
            _context = context;


        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AddDetail(Shop2 shops2)
        {

            _context.Add(shops2);
            _context.SaveChanges();


            return View(shops2);
        }

    }
}
