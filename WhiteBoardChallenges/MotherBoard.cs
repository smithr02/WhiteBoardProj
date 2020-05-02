using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    class MotherBoard
    {
        String Manufacturer;
        CPU Processor;
        RAM TemporaryMemory;
        HardDrive Storage;
        GPU Graphics;

        public MotherBoard(string manufacturer, RAM ram, CPU cpu, HardDrive hardDrive, GPU gpu)
        {
            Manufacturer = manufacturer;
            TemporaryMemory = ram;
            Processor = cpu;
            Storage = hardDrive;
            Graphics = gpu;
        }

        public void InstallApplication(Applications application)
        {
            Processor.ProcessInstall(application, Storage, TemporaryMemory, Graphics);
        }
    }

   
}
