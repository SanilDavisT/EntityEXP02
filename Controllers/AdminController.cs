using EntityEXP02.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityEXP02.Controllers
{
    public class AdminController : Controller
    {


        ShopDbContext _context;
        

        public AdminController(ShopDbContext context)
        {
            
            _context = context;


        }



        //public IActionResult Index()
        //{
        //    return View();
        //}
        //public IActionResult Index2()
        //{
        //    return View();
        //}
        //public IActionResult Index3()
        //{
        //    return View();
        //}

        public IActionResult Index4()
        {


            var result = _context.Shops.ToList();
            return View(result);
        }

    }
}
