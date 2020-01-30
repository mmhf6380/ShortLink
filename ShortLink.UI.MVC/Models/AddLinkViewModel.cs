using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShortLink.UI.MVC.Models
{
    public class AddLinkViewModel
    {
        [Required(ErrorMessage ="حتما می بایست یک لینک کامل وارد شود")]
        [Display(Name ="لینک اصلی")]
        public string Text { get; set; }
    }
}
