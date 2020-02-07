namespace CalculoIR.Model.Entities
{
    public class Contribuinte : EntityBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double RendaMensal { get; set; }
    }
}
