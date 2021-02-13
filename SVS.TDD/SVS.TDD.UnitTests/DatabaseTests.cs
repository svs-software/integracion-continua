using NUnit.Framework;
using SVS.CI.Data;

namespace SVS.TDD.UnitTests
{
    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        public void PruebaTemporal()
        {
            var resultado = Database.TestConnection(null);

            Assert.IsFalse(resultado);
        }
    }
}
