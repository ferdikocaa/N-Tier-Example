using Layered.DAL.Concrete.Entiti;
using Layered.Entiti;
using LayeredMVC.UI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LayeredMVC.UI.Controllers
{
    public class LanguageController : ApiController
    {
        LanguageAPI _api = new LanguageAPI(new EFLanguage());
        //public List<Languages> GetAll()
        //{
        //    return _api.GetAll();
        //}
        public Languages Get(int id)
        {
            return _api.Get(id);
        }   
        public string GetSelam(string name)
        {
            return "SELAM"+name;
        }
    }
}
