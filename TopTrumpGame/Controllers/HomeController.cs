using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopTrumpGame.Models;

namespace TopTrumpGame.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpPost]
        public ActionResult Index(HomePlayerName player)
        {
            Session["Player"] = player.PlayerName;
            return View();
        }
        [HttpGet]
        public ActionResult Index()
        {
            
            return View();
        }

    }
}