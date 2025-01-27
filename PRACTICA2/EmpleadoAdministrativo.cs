namespace CalculadoraSalarios
{
    public class EmpleadoAdministrativo : Empleado
    {
        public double SalarioBase { get; set; }

        public EmpleadoAdministrativo(string nombre, bool alcanzoMeta, double salarioBase) 
            : base(nombre, alcanzoMeta)
        {
            SalarioBase = salarioBase;
        }

        public override double CalcularSalario()
        {
            return AlcanzoMeta ? SalarioBase : SalarioBase / 2;
        }
    }
}