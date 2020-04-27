using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    class Applications
    {
        public string ApplicationName;
        public string ApplicationType;
        public double RequriedRam;
        public double RequriedStorage;

        public Applications()
        {
            ApplicationName = "Slack";
            ApplicationType = "Messaging service";
            RequriedRam = 4.0;
            RequriedStorage = 0.512;
        }
    }
}
