    using System.Collections.Generic;

namespace Escuela.Modelos
{
    public class Profesor : Persona
    {
        public HashSet<Curso> Cursos { get; private set; } = new HashSet<Curso>();

        public Profesor(string nombre) : base(nombre) { }

        public void AsignarCurso(Curso curso)
        {
            Cursos.Add(curso);
        }
    }
}
