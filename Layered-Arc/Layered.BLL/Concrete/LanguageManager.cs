using Layered.DAL.Abstract;
using Layered.Entiti;
using Layered.Interfaces;
using System.Collections.Generic;

namespace Layered.BLL.Concrete
{
    public class LanguageManager : ILanguageService
    {
        //constructur olustur
        private ILanguage _languageDAL;
        public LanguageManager(ILanguage languageDAL)
        {
            _languageDAL = languageDAL;
        }
        public void Add(Languages language)
        {
            _languageDAL.Add(language);
        }
        public void Delete(int language_id)
        {   
            _languageDAL.Delete(language_id);
        }
        public Languages Get(int language_id)
        {
            return _languageDAL.Get(language_id);
        }
        public List<Languages> GetAll()
        {
            return _languageDAL.GetAll();
        }
        public void Update(int language_id, Languages language)
        {
            _languageDAL.Update(language_id,language);
        }

        Languages ILanguageService.Add(Languages language)
        {
            throw new System.NotImplementedException();
        }
    }
}
