using GestorDeTareas.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestorDeTareas
{
    public class ContextoDb : IdentityDbContext
    {
        public ContextoDb(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Paso> Pasos { get; set; }
        public DbSet<ArchivoAdjunto> ArchivosAdjuntos { get; set; }
    }
}
