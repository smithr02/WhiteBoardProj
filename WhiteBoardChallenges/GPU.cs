using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    class GPU
    {
        public string Manufacturer;
        public double RequiredEffectiveMemory;

        public GPU(string Manufacturer, double EffectiveMemory)
        {
            this.Manufacturer = Manufacturer;
            this.RequiredEffectiveMemory = EffectiveMemory;
        }


    }
}
