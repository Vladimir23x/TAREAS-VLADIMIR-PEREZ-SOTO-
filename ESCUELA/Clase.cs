using System.Collections.Generic;

namespace Escuela.Modelos
{
    public class Clase
    {
        public string Identificador { get; private set; }
        public List<Estudiante> Estudiantes { get; private set; } = new List<Estudiante>();
        public HashSet<Profesor> Profesores { get; private set; } = new HashSet<Profesor>();

        public Clase(string identificador)
        {
            Identificador = identificador;
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public void AgregarProfesor(Profesor profesor)
        {
            Profesores.Add(profesor);
        }
    }
}
