namespace CalculadoraSalarios
{
    public class DocenteContratoFijo : Empleado
    {
        public double SalarioBase { get; set; }

        public DocenteContratoFijo(string nombre, bool alcanzoMeta, double salarioBase) 
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