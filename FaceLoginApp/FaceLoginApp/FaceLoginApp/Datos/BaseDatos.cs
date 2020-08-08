using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Xamarin.Forms;
using FaceLoginApp.Modelos;
using System.Text;
using System.Threading.Tasks;

namespace FaceLoginApp.Datos
{
    public class BaseDatos : DbContext

    {
        public DbSet<Usuario> Usuarios { get; set; }

        private readonly string rutaDB;

        public BaseDatos(string rutaDB)
        {
            this.rutaDB = rutaDB;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = DependencyService.Get<IBaseDatos>().GetDatabasePath();
            optionsBuilder.UseSqlite($"Filename={dbPath}");

        }
    }

}
