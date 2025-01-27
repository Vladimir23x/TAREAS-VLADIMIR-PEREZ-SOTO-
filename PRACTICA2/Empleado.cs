using System;

namespace CalculadoraSalarios
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public bool AlcanzoMeta { get; set; }

        public Empleado(string nombre, bool alcanzoMeta)
        {
            Nombre = nombre;
            AlcanzoMeta = alcanzoMeta;
        }

        public abstract double CalcularSalario();
    }
}