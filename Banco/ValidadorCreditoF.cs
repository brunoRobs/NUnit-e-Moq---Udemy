namespace Banco
{
    public class ValidadorCreditoF : IValidadorCredito
    {
        //desnecessária já que estamos utilizando o Mock
        public bool ValidarCredito(string cpf, decimal valor)
        {
            //acessa nada
            return true;
        }
    }
}