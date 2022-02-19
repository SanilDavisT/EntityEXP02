using EntityEXP02.Models;
using EntityEXP02.Utils;
using Microsoft.AspNetCore.Mvc;

namespace EntityEXP02.Controllers
{
    public class ShopController : Controller
    {
        ShopDbContext _context;
        IHelper helper;

        public ShopController(ShopDbContext context, IHelper helper)
        {
            this.helper = helper;
            _context = context;


        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AddDetail(Shop newshop)
        {


            helper.filewrite(newshop);
            return View();
        }
    }
}
