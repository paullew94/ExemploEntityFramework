using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo00
{
    public class SistemaContext : DbContext
    {
        public DbSet<Animal> Animais{get;set;}

        public DbSet<Habilidades> Habilitades { get; set; }

        public SistemaContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\ExemploEmpiryFramework.mdf;Integrated Security=True;Connect Timeout=30")
        {
            Database.SetInitializer<SistemaContext>(null);
        }

    }
}
