using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GestorDeTareas.Entidades
{
    public class ArchivoAdjunto
    {
        public int Id { get; set; }
        public int TareaId { get; set; }
        public Tarea Tareas { get; set; }
        [Unicode]
        public string Url { get; set; }
        [MaxLength(250)]
        public string Titulo { get; set; }

        public int Orden { get; set; }
        public DateTime FechaCracion { get; set; }
    }
}
