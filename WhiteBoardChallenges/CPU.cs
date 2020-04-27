using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    class CPU
    {
        String Manufacturer;
        String Name;
        public CPU(String Manufacturer, String Name)
        {
            this.Manufacturer = Manufacturer;
            this.Name = Name;
        }

        public void ProcessInstall(Applications app, HardDrive hd, RAM ram)
        {
            if (checkRequirements(app,hd,ram))
            {
                hd.ApplicationsInHardDrive.Add(app);
            }
        }

        public bool checkRequirements(Applications app, HardDrive hd, RAM ram)
        {

        }
    }
}
