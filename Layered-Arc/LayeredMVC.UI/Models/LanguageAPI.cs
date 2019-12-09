using Layered.DAL.Abstract;
using Layered.Entiti;
using Layered.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
namespace LayeredMVC.UI.Models
{
    public class LanguageAPI : ILanguageService
    {
        private ILanguage _language;
        public LanguageAPI(ILanguage language)
        {
            _language = language;
        }
        public void Add(Languages language)
        {
            throw new NotImplementedException();
        }

        public void Delete(int language_id)
        {
            throw new NotImplementedException();
        }

        public Languages Get(int language_id)
        {
            return _language.Get(language_id);
        }

        public List<Languages> GetAll()
        {
            return _language.GetAll().ToList();
        }

        public void Update(int language_id, Languages language)
        {
            throw new NotImplementedException();
        }
        // dursun bu şekilde bakalım 
        Languages ILanguageService.Add(Languages language)
        {
            throw new NotImplementedException();
        }
    }
}