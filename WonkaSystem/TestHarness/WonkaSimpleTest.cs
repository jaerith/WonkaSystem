using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WonkaPrd;
using WonkaRef;

namespace WonkaSystem.TestHarness
{
    public class WonkaSimpleTest
    {

        public WonkaSimpleTest()
        {
        }

        public void Execute()
        {
            WonkaRefEnvironment RefEnv =
                WonkaRefEnvironment.CreateInstance(false, new WonkaMetadataTestSource());

            // Cue the rules engine
        }
    }
}
