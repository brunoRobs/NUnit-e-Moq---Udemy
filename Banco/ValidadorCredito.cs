namespace Banco
{
    public class ValidadorCredito : IValidadorCredito
    {
        public bool ValidarCredito(string cpf, decimal valor)
        {
            bool statusSerasa = VerificarSituacaoSerasa(cpf);
            bool statusSPC = VerificarSituacaoSPC(cpf);
            return (statusSerasa && statusSPC);
        }

        private bool VerificarSituacaoSPC(string cpf)
        {
            //chamada webservice
            return true;
        }

        private bool VerificarSituacaoSerasa(string cpf)
        {
            //chamada webservice
            return true;
        }
    }
}