using NUnit.Framework;
using SVS.CI.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
