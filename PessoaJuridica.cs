namespace SistArruda
{
    class PessoaJuridica : Clientes
    {
        public string Cnpj {get; set;}
        public string ie {get; set;}
        public override void PagarImposto (float v)
        {
            this.Valor = v;
            this.ValorImposto = this.Valor * 20/100;
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}