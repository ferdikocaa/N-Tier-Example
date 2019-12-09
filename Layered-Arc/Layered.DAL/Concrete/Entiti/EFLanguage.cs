using Layered.DAL.Abstract;
using Layered.Entiti;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Layered.DAL.Concrete.Entiti
{
    public class EFLanguage : ILanguage
    {
        ProjectContext _context = new ProjectContext();
        public void Add(Languages language)
        {
            _context.Languages.Add(language);
            _context.SaveChanges();
        }
        public void Delete(int language_id)
        {
            _context.Languages.Remove(_context.Languages.FirstOrDefault(l=>l.ID==language_id));
             _context.SaveChanges();
        }
        public Languages Get(int language_id)
        {
            return _context.Languages.FirstOrDefault(l=>l.ID==language_id);
        }
        public List<Languages> GetAll()
        {
            return _context.Languages.ToList();
        }
        public void Update(int language_id, Languages language)
        {
            Languages UpdateLang = _context.Languages.FirstOrDefault(l=>l.ID==language.ID);
            UpdateLang.IsPopular = language.IsPopular;
            UpdateLang.Founder = language.Founder;
            _context.SaveChanges();
        }
    }
}
