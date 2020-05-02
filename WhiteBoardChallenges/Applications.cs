using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    public abstract class Applications
    {
        public string ApplicationName;
        public string ApplicationType;
        public double RequriedRam;
        public double RequriedStorage;
        public double RequiredEffectiveMemory;

        public Applications()
        {
            ApplicationName = "Slack";
            ApplicationType = "Messaging service";
            RequriedRam = 4.0; //In Gigabytes
            RequriedStorage = 0.512; //In Gigabytes
        }
    }
}
