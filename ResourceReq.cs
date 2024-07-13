using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public enum RoomType { 
    Normal,
    Oxygen,
    ICU
    
    }
    public class ResourceReq
    {
        public int FlatBeds { get; set; }
        public int ReclinerBeds { get; set; }
        public int Ventilators { get; set; }
        public int OxygenCylinders { get; set; }
        public int NormalMasks { get; set; }
        public int NonRebreatherMasks { get; set; }
    }
}
