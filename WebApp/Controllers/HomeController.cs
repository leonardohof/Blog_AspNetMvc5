using Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public readonly IPostService _postService;

        public HomeController(IPostService postService)
        {
            this._postService = postService;
        }

        public ActionResult Index(int page = 1)
        {
            var data = _postService.GetAllPosts(page, 10);
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}