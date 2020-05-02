using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    class TextEditor : Applications
    {
        public TextEditor(string Appname, string AppType, double RequiredRam, double RequiredStorage)
        {
            ApplicationName = Appname;
            ApplicationType = AppType;
            RequriedRam = RequiredRam; //In Gigabytes
            RequriedStorage = RequiredStorage; //In Gigabytes
        }
    }
}
