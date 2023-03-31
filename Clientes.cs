namespace SistArruda
{
    class Clientes
    {
        public string Nome {get; set;}
        public string Endereco {get; set;}
        public float Valor {get; set;}
        public float ValorImposto {get; protected set;}
        public float Total{get; protected set;}
        public virtual void PagarImposto (float v)
        {
            this.Valor = v;
            this.ValorImposto = this.Valor*10/100;
            this.Total = this.ValorImposto + this.Valor;
        }
    }
}