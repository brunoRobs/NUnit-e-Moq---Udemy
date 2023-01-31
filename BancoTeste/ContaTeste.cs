using Banco;

namespace BancoTeste
{
    [TestFixture]
    public class ContaTeste
    {
        //[OneTimeSetUp] SetUp inicial do código, ocorre apenas 1 vez
        //[SetUp] ocorre antes da execução de todos os testes
        //[OneTimeTearDown] TearDown final do código, ocorre apenas 1 vez
        //[TearDown] ocorre após a execução de todos os testes
        //[Category("")] utilizamos para categorizar testes de tipos específicos
        //[TestCase()] utilizamos para parametrizar o teste
        //[Timeout()] utilizmos para abortar testes que tenham duração superior
        //ao tempo definido em milissegundos

        Conta? conta;

        [OneTimeSetUp]
        public void SetUp()
        {
            conta = new Conta("0001", 100);
        }

        [OneTimeTearDown]
        public void TearDowm()
        {
            conta = null;
        }

        [Test]
        public void TestSacar()
        {
            bool resultado = conta.Sacar(100);
            Assert.IsTrue(resultado);
        }

        [Test]
        public void TestSacarMuitoDinheiro()
        {
            bool resultado = conta.Sacar(120);
            Assert.IsFalse(resultado);
        }

        [Test]
        public void TestSacarZero()
        {
            bool resultado = conta.Sacar(0);
            Assert.IsFalse(resultado);
        }

        [Test]
        public void TestSacarNegativo()
        {
            bool resultado = conta.Sacar(-50);
            Assert.IsFalse(resultado);
        }

        [Test]
        public void TestSacarSemSaldo()
        {
            conta = new Conta("0001", 0); //rearrange para redefinir saldo
            bool resultado = conta.Sacar(10);
            Assert.IsFalse(resultado);
        }

        [Test]
        public void TestDepositar()
        {
            bool resultado = conta.Depositar(50);
            Assert.IsTrue(resultado);
        }

        [Test]
        public void TestDepositarNegativo()
        {
            bool resultado = conta.Depositar(-10);
            Assert.IsFalse(resultado);
        }

        [Test]
        public void TestDepositarZero()
        {
            bool resultado = conta.Depositar(0);
            Assert.IsFalse(resultado);
        }
    }
}