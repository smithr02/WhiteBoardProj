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

        public void ProcessInstall(Applications app, HardDrive hd, RAM ram, GPU gpu)
        {
            if (checkRequirements(app,hd,ram,gpu))
            {
                hd.ApplicationsInHardDrive.Add(app);
                hd.AvailableStorage -= app.RequriedStorage;
            }
        }

        public bool checkRequirements(Applications app, HardDrive hd, RAM ram, GPU gpu)
        {
            if (app.ApplicationType.Equals("Game"))
            {
                if (ram.TotalGigbytes >= app.RequriedRam && hd.AvailableStorage >= app.RequriedStorage && gpu.RequiredEffectiveMemory >= app.RequiredEffectiveMemory)
                {
                    return true;
                }
            }
            else
            {
                if (ram.TotalGigbytes >= app.RequriedRam && hd.AvailableStorage >= app.RequriedStorage)
                {
                    return true;
                }
            }
            return false;
            
        }
    }
}
