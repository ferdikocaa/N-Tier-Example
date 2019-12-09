using Layered.DAL.Abstract;
using Layered.Entiti;
using Layered.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi_example.API.Models
{
    public class Language : ILanguageService
    {
        private ILanguage _language;
        public Language(ILanguage language)
        {
            _language = language;
        }

        public Languages Add(Layered.Entiti.Languages language)
        {
             _language.Add(language);
            return language;
        }

        public void Delete(int language_id)
        {
            throw new NotImplementedException();
        }

        public Layered.Entiti.Languages Get(int language_id)
        {
            return _language.Get(language_id);
        }

        public List<Layered.Entiti.Languages> GetAll()
        {
            return _language.GetAll();
        }

        public void Update(int language_id, Layered.Entiti.Languages language)
        {
            throw new NotImplementedException();
        }
    }
}