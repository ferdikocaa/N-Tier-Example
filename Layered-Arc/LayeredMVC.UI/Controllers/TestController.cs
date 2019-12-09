using System.Collections.Generic;
using System.Web.Http;
using Layered.DAL;
using Layered.DAL.Concrete.Entiti;
using Layered.Entiti;
using LayeredMVC.UI.Models;

namespace LayeredMVC.UI.Controllers
{
    public class TestController : ApiController
    {
        LanguageAPI _api = new LanguageAPI(new EFLanguage());
         public List<Languages> GetAll()
         {
            return _api.GetAll();
         }
        public Languages Get(int id)
        {
            return _api.Get(id);
        }
    }
}
