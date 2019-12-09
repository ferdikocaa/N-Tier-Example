using Layered.DAL.Concrete.Entiti;
using Layered.Entiti;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi_example.API.Models;

namespace webapi_example.API.Controllers
{
    public class ExampleController : ApiController
    {
        Language _language = new Language(new EFLanguage());
        //public List<Languages> Get()
        //{
        //    return _language.GetAll();
        //}
        ///REQUEST GELDIGINDE RESPONSE OLARAK DONMESI GEREKMEKTEDIR
        //[Route("api/Example/GetById/{id:int}")]
        //public Languages GetById(int id)
        //{
        //    return _language.Get(id);
        //}
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var languages = _language.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, languages);
        }
        [Route("api/Example/GetId/{id:int}")]
        public HttpResponseMessage GetId(int id)
        {
            var dt = _language.Get(id);
            if (dt == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Kayıt bulunamadi");
            }
            return Request.CreateResponse(HttpStatusCode.OK, dt);
        }
        [HttpPost]
        public HttpResponseMessage PostID(Languages lang) //POSTMAN ile pointer kullanarak verilen geldiğini görebiliriz.
        {
            var createdLanguages = _language.Add(lang);
            return Request.CreateResponse(HttpStatusCode.Created,createdLanguages);
        }
        public HttpResponseMessage Del(int language_id)
        {
             _language.Delete(language_id);
            return Request.CreateResponse(HttpStatusCode.OK, language_id);
            
        }
    }
}
