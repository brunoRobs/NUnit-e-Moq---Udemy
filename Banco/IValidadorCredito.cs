namespace Banco
{
    public interface IValidadorCredito
    {
        bool ValidarCredito(string cpf, decimal valor);
    }
}