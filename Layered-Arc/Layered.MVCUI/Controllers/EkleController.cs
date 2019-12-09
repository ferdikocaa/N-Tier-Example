using Hangfire;
using Layered.BLL.Concrete;
using Layered.DAL.Concrete.Entiti;
using Layered.Entiti;
using Layered.MVCUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace Layered.MVCUI.Controllers
{
    public class EkleController : Controller
    {
        public static class _ConnectionApiSettings
        {

            public static HttpClient httpClient = new HttpClient();
            static _ConnectionApiSettings()
            {
                httpClient.BaseAddress = new Uri("https://localhost:44303/api/");
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }
        // GET: Ekle
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult AddP(Languages veri)
        {
            LanguageManager _language = new LanguageManager(new EFLanguage());
            string _Durum;
            try
            {
                if (ModelState.IsValid)
                {
 
                    var response = _ConnectionApiSettings.httpClient.PostAsJsonAsync("Example/PostID", veri).Result;
                    RecurringJob.AddOrUpdate(() =>
                    _language.Add(veri),Cron.Minutely);
                    if (response.IsSuccessStatusCode)
                    {
                        _Durum="Basariyla eklendi";
                    }
                    else
                        _Durum ="Eklenirken bir problemle karsilasildi.";
                }
                else
                {
                    _Durum = "Eklenirken bir problemle karsilasildi.";
                }
            }
            catch
            {
                _Durum = "Eklenirken bir problemle karsilasildi.";
            }
            return Json(_Durum, JsonRequestBehavior.AllowGet);
            //LanguageManager _language = new LanguageManager(new EFLanguage());
            //_language.Add(veri);
            //return View();
        }
 
    }
}