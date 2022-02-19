using EntityEXP02.Models;
using EntityEXP02.Utils;
using Microsoft.AspNetCore.Mvc;

namespace EntityEXP02.Controllers
{
    public class ShopController : Controller
    {

        IHelper helper;

        public ShopController(IHelper helper)
        {
            this.helper = helper;

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
