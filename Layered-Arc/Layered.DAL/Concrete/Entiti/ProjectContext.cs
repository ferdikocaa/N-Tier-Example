using Layered.Entiti;
using System.Data.Entity;
namespace Layered.DAL.Concrete.Entiti
{

    /// <summary>
    /// entiti veritabani islemi
    /// </summary>
    public class ProjectContext : DbContext
    {
        public DbSet<Languages> Languages { get; set; }
    }
}
