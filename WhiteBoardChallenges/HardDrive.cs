using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    class HardDrive
    {
        public Double TotalStorage;
        public Double AvailableStorage;
        public List<Applications> ApplicationsInHardDrive;

        public HardDrive(Double TotalStorage, Double AvailableStorage)
        {
            this.TotalStorage = TotalStorage;
            this.AvailableStorage = AvailableStorage;
        }
    }
}
