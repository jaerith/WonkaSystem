using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WonkaSystem.TestHarness;

namespace WonkaSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WonkaSimpleTest SimpleTest = new WonkaSimpleTest();

                SimpleTest.Execute();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }

            return;
        }
    }
}
