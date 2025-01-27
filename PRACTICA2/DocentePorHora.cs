namespace CalculadoraSalarios
{
    public class DocentePorHora : Empleado
    {
        public int HorasTrabajadas { get; set; }
        private const double TarifaPorHora = 800;

        public DocentePorHora(string nombre, bool alcanzoMeta, int horasTrabajadas) 
            : base(nombre, alcanzoMeta)
        {
            HorasTrabajadas = horasTrabajadas;
        }

        public override double CalcularSalario()
        {
            return HorasTrabajadas * TarifaPorHora;
        }
    }
}