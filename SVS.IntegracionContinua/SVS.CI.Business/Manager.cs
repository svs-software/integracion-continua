using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVS.CI.Business
{
    public class Manager
    {
        public void Covered()
        {
            Console.WriteLine("Running covered method")
        }

        public void Uncovered()
        {
            Console.WriteLine("Running uncovered method");
        }
    }
}
