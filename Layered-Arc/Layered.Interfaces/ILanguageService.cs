using Layered.Entiti;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layered.Interfaces
{
    public interface ILanguageService
    {
        List<Languages> GetAll();
        Languages Get(int language_id);
        Languages Add(Languages language);
        void Delete(int language_id);
        void Update(int language_id, Languages language);
    }
}
