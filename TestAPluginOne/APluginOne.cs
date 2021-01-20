using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PluginDemo.Common;

namespace TestAPluginOne
{
    [Serializable]
    public class APluginOne : APlugin
    {
        public override void DoWork()
        {
            Log("DoWork");

            Update();
            //throw new Exception("test");
        }
    }
}
