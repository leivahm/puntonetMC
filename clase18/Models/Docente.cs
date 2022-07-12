namespace clase18.Models
{
    public class Docente : IPersona
    {
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string DNI {get; set;}
        public int Horas {get; set;}
    }
}