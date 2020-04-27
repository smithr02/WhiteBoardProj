using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    class GPU
    {
        string Manufacturer;
        Double EffectiveMemory;

        public GPU(string Manufacturer, Double EffectiveMemory)
        {
            this.Manufacturer = Manufacturer;
            this.EffectiveMemory = EffectiveMemory;
        }
    }
}
