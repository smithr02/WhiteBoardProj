using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    class Games : Applications
    {
        public Games(double RequiredEffectiveMemory, string Appname, string AppType, double RequiredRam, double RequiredStorage)
        {
            this.RequiredEffectiveMemory = RequiredEffectiveMemory;
            ApplicationName = Appname;
            ApplicationType = AppType;
            RequriedRam = RequiredRam; //In Gigabytes
            RequriedStorage = RequiredStorage; //In Gigabytes
        }
    }
}
