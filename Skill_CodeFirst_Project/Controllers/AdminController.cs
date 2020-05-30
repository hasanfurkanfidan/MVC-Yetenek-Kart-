using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Skill_CodeFirst_Project.Models.siniflar;

namespace Skill_CodeFirst_Project.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            CONTEXT context = new CONTEXT();
            var degerler = context.Yeteneklers.ToList();

            return View(degerler);
        }
        [HttpGet]
        public ActionResult YetenekEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YetenekEkle(Yetenekler yetenek)
        {
        CONTEXT context = new CONTEXT();
        context.Yeteneklers.Add(yetenek);
        context.SaveChanges();
        return View();


        }

        public ActionResult YetenekSil(int Id)
        {
            CONTEXT context = new CONTEXT();
            var silinecek = context.Yeteneklers.Find(Id);
            context.Yeteneklers.Remove(silinecek);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}