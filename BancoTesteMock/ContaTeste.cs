using Banco;
using Moq;

namespace BancoTesteMock
{
    [TestFixture]
    public class ContaTeste
    {
        [Test]
        public void testSolicitarEmprestimo()
        {
            var conta = new Conta("0001", 100);
            var mock = new Mock<IValidadorCredito>();
            mock.Setup(x => x.ValidarCredito(It.IsAny<string>(), It.IsAny<decimal>()).Returns(true);
            conta.SetValidadorCredito(mock.Object);
            int resultadoEsperado = 2100;
            conta.SolicitarEmprestimo(2000);
            Assert.IsTrue(conta.saldo == resultadoEsperado);
        }
    }
}