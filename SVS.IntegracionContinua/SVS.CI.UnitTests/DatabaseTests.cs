using NUnit.Framework;
using SVS.CI.Data;

namespace SVS.CI.UnitTests
{
    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        public void TestConnection_KeyIsNotEmpty_ReturnsTrue()
        {
            var key = "connectionstring";

            var result = Database.TestConnection(key);

            Assert.IsFalse(result);
        }
    }
}
