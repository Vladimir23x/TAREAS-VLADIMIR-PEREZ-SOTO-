using System.Collections.Generic;

namespace Escuela.Modelos
{
    public class Escuela
    {
        public List<Clase> Clases { get; private set; } = new List<Clase>();

        public void AgregarClase(Clase clase)
        {
            Clases.Add(clase);
        }
    }
}
