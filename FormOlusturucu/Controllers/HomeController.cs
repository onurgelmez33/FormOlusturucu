using FormOlusturucu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormOlusturucu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<FormElement> els = new List<FormElement>()
            {
                new FormElement{Id = 1, InputType = "text", Name = "adi", Placeholder = "Adınınızı Giriniz", Value = "Onur", ValueType = "string" },
                new FormElement{Id = 2, InputType = "text", Name = "soyadi", Placeholder = "Soyadını Giriniz", Value = "Gelmez", ValueType = "string" },
                new FormElement{Id = 3, InputType = "select", Name = "dersler", Placeholder = "Dersleri Seçiniz", Value = "", ValueType = "string", Options = "1:Programlama;2:Psikoloji;3:İktisat" }
            };
            return View(els);
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            return View("Basarili", form);
        }

        public ActionResult FormOlustur()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FormOlustur(IEnumerable<FormElement> model)
        {
            var form = Request.Form;
            return View();
        }
    }
}