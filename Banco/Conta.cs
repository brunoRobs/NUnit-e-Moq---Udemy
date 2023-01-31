namespace Banco
{
    public class Conta
    {
        public string cpf;

        public decimal saldo;

        private IValidadorCredito validadorCredito;

        public Conta(string cpf, decimal saldo)
        {
            this.cpf = cpf;
            this.saldo = saldo;
        }

        public void SetValidadorCredito(IValidadorCredito validador)
        {
            this.validadorCredito = validador;
        }

        public bool Sacar(decimal valor)
        {
            if (this.saldo > 0)
            {
                if (this.saldo < valor || valor <= 0)
                    return false;
                this.saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Depositar(decimal valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
                return true;
            }
            return false;
        }

        public bool SolicitarEmprestimo(decimal valor)
        {
            bool resultado = validadorCredito.ValidarCredito(this.cpf, valor);
            if (resultado)
                this.saldo += valor;
            return resultado;
        }
    }
}