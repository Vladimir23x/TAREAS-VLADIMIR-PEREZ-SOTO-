namespace Escuela.Modelos
{
    public class Estudiante : Persona
    {
        public int NumeroUnico { get; set; }

        public Estudiante(string nombre, int numeroUnico) : base(nombre)
        {
            NumeroUnico = numeroUnico;
        }
    }
}
