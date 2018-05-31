using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CakeShop.Controllers
{
    public class CakeShopController:Controller
    {
        public ActionResult Detail()
        {
            if(DateTime.Today.DayOfWeek==DayOfWeek.Monday)
            {
                return Redirect("/");
            }
            return new ContentResult()
            {
                Content="Hello from CakeShop"
            };

            
        }
    }
}