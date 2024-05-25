using System.ComponentModel.DataAnnotations;

namespace GestorDeTareas.Entidades
{
    public class Tarea
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<Paso> Pasos { get; set; } //Propiedad de navegacion para cargar los pasos de la tarea
        public List<ArchivoAdjunto> ArchivoAdjuntos { get; set; }
    }
}
