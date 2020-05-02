using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    class HardDrive
    {
        public double TotalStorage;
        public double AvailableStorage;
        public List<Applications> ApplicationsInHardDrive;

        public HardDrive(double TotalStorage, double AvailableStorage)
        {
            this.ApplicationsInHardDrive = new List<Applications>();
            this.TotalStorage = TotalStorage;
            this.AvailableStorage = AvailableStorage;
        }
    }
}
