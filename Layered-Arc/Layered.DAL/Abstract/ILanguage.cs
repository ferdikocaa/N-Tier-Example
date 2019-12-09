using Layered.Entiti;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layered.DAL.Abstract
{
    public interface ILanguage
    {
        List<Languages> GetAll();
        Languages Get(int language_id);
        void Add(Languages language);
        void Delete(int language_id);
        void Update(int language_id, Languages language);
    }
}
