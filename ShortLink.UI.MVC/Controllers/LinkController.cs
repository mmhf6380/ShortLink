using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShortLink.Core.Contracts.Links;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShortLink.UI.MVC.Controllers
{
    public class LinkController : Controller
    {
        private readonly ILinkService linkService;

        public LinkController(ILinkService linkService)
        {
            this.linkService = linkService;
        }
        public IActionResult Index([FromRoute]string ShortLink)
        {
            var resulte = linkService.GetLink(ShortLink);
            if (resulte !=null)
            { 
                return Redirect(resulte.Text.ToString());
            }
            return BadRequest();
            
        }

    }
}
