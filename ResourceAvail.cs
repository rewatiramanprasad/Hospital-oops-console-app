using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class ResourceAvail
    {

        public int FlatBeds { get; set; } = 80;
        public int ReclinerBeds { get; set; } = 100;
        public int Ventilators { get; set; } = 16;
        public int OxygenCylinders { get; set; } = 110;
        public int NormalMasks { get; set; } = 200;
        public int NonRebreatherMasks { get; set; } = 120;
    }
}
