using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    class Computer
    {
        public GPU gpu;
        public CPU cpu;
        public HardDrive hd;
        public RAM ram;
        public MotherBoard motherB;
        public Computer()
        {
            gpu = new GPU("Ryden", 10.0);
            cpu = new CPU("Corsair", "Butt Pirate");
            hd = new HardDrive(1000.0, 970.0);
            ram = new RAM(36.0, "Corsair");
            motherB = new MotherBoard("Ryzen", ram, cpu, hd, gpu);
        }
    }
}
