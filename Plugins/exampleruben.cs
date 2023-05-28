using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionPlanner.plugins
{
    internal class exampleruben: MissionPlanner.Plugin.Plugin
    {
        public override string Name 
        {
            get { return "Sailboat Expansion"; }
        }
        public override string Version 
        {
            get { return "1"; }
        }
        public override string Author 
        {
            get { return "Ruben van Tonder"; }
        }

        public override bool Init()
        {
            // number of times plugin is called per second
            CustomMessageBox.Show("Hello World");
            return true;
        }

        public override bool Loaded()
        {
            return true;
        }
        public override bool Loop()
        {
          
            return base.Loop();
        }

        public override bool Exit()
        {
            return true;
        }
    }
}
