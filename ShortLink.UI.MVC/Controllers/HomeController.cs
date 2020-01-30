using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShortLink.Core.Contracts.Links;
using ShortLink.UI.MVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShortLink.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILinkService linkService;

        public HomeController(ILinkService linkService)
        {
            this.linkService = linkService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create([FromRoute]int id, AddLinkViewModel model)
        {
            string result = linkService.CreateShortLink(id, model.Text);
            TempData["ShortLink"] = result;
            return View();
        }
    }
}
