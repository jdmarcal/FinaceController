using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;



namespace Modelos.DAL
{
    class MeuContexto : DbContext
    {
        public MeuContexto() : base("strConn")
         {
            Database.SetInitializer<MeuContexto>(new DropCreateDatabaseIfModelChanges<MeuContexto>());
         }

        public DbSet<Conta> Contas { get; set; }
    }
}
