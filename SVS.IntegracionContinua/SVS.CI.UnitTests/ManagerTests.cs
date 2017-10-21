using NUnit.Framework;
using SVS.CI.Business;

namespace SVS.CI.UnitTests
{
    [TestFixture]
    public class ManagerTests
    {
        [Test]
        public void RunMethodTest()
        {
            var manager = new Manager();

            manager.Covered();
        }
    }
}
