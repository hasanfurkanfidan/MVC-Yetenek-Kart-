using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Skill_CodeFirst_Project.Models.siniflar;
using Context = Microsoft.Ajax.Utilities.Context;

namespace Skill_CodeFirst_Project.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            CONTEXT context = new CONTEXT();
            var degerler = context.Yeteneklers.ToList();
            

           return View(degerler);
        }
    }
}