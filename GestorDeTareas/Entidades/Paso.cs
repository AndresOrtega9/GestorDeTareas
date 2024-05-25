namespace GestorDeTareas.Entidades
{
    public class Paso
    {
        public int Id { get; set; }
        public int TareaId { get; set; } //Llave foranea de la tabla Tarea
        public Tarea Tareas { get; set; } //Propiedad de navegacion 
        public string Descripcion { get; set; }
        public bool Realizado { get; set; }
        public int Orden { get; set; }


    }
}
