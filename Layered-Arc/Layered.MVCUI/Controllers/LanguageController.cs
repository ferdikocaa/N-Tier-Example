using Layered.BLL.Concrete;
using Layered.DAL.Concrete.Entiti;
using Layered.Entiti;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;

//Install-Package Microsoft.AspNet.WebApi.Client package managerdan yükle bunu.

namespace Layered.MVCUI.Controllers
{
    public class LanguageController : Controller
    {
        // GET: Language
        LanguageManager _language = new LanguageManager(new EFLanguage());
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
        public ViewResult Index()
        {
            try
            {
                var response = _ConnectionApiSettings.httpClient.GetAsync("Example/Get").Result;
                var _data = response.Content.ReadAsAsync<List<Languages>>().Result;
                return View(_data);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //return View(_language.GetAll());
        }
        public ActionResult Del(int id)
        {
            string _Durum;
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _ConnectionApiSettings.httpClient.GetAsync("Example/PostDel/"+id).Result;
                    //var response = _ConnectionApiSettings.httpClient.PostAsJsonAsync("Example/PostDel", id).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        _Durum = "Basariyla silindi";
                    }
                    else
                        _Durum = "Silme sirasindas bir problemle karsilasildi.";
                }
                else
                {
                    _Durum = "Silme sirasinda bir problemle karsilasildi.";
                }
            }
            catch
            {
                _Durum = "Silme sirasinda bir problemle karsilasildi.";
            }
            return Json(_Durum, JsonRequestBehavior.AllowGet);
            //_language.Delete(ID);
            //return RedirectToAction("Index");
        }
    }
}