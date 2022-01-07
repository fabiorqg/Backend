using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace D05_EF6_Migrations_DAL
{
    class BibliotecaContext : DbContext
    {
        public BibliotecaContext() : base ("BibliotecaContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Desativar a pluralização das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        
        public DbSet<Editora> Editora { get; set; }
        public DbSet<Livro> Livro { get; set; }
    }
}
