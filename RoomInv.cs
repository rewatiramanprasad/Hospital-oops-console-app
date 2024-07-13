using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class RoomInv
    {
        public int normalRoom = 50;
        public int OxygenRoom = 50;
        public int icuRoom = 20;
        public ResourceAvail resourceAvail= new ResourceAvail();

        public bool ReserveRoom(RoomType roomType)
        {
            ResourceReq requirement = GetRequirement(roomType);
            if (requirement == null || !isAvailbale(requirement)) { 
           return false;
            }

            
            decrementRes(requirement);
            decrementRoom(roomType);
            //generatePatientId(roomType);
            return true;

        }

        public ResourceReq GetRequirement(RoomType roomType) {

            if (roomType == RoomType.Normal)
            {
                return new ResourceReq { FlatBeds = 1, NormalMasks = 2 };
            }
            else if (roomType == RoomType.Oxygen)
            {

                return new ResourceReq { ReclinerBeds = 1, OxygenCylinders = 2, NonRebreatherMasks = 3 };
            }
            else if (roomType == RoomType.ICU) {
                return new ResourceReq { ReclinerBeds = 1, Ventilators = 1, OxygenCylinders = 1 };
            
            }else
            {
                return null;
            }
           
  
        }
        public void generatePatientId(RoomType roomType) {
        
            string str=$"{roomType}-{Guid.NewGuid()}";

            Console.WriteLine($"PatientId : {str}");
        }
        public bool isAvailbale(ResourceReq req) {
        return req.FlatBeds <= resourceAvail.FlatBeds
                &&req.ReclinerBeds <= resourceAvail.ReclinerBeds &&
                req.Ventilators <= resourceAvail.Ventilators&&
                req.NormalMasks <= resourceAvail.NormalMasks&&
                req.NonRebreatherMasks <= resourceAvail.NonRebreatherMasks&&
                req.OxygenCylinders <= resourceAvail.OxygenCylinders;
        
        }

        public void decrementRes(ResourceReq req) { 
        resourceAvail.FlatBeds-=req.FlatBeds;
        resourceAvail.ReclinerBeds-=req.ReclinerBeds;
        resourceAvail.Ventilators-=req.Ventilators;
        resourceAvail.OxygenCylinders-=req.OxygenCylinders;
        resourceAvail.NonRebreatherMasks-=req.NonRebreatherMasks;
        resourceAvail.NormalMasks-=req.NormalMasks;

        }

        public void decrementRoom(RoomType roomType) {

            if (roomType == RoomType.Normal)
                normalRoom--;

            if (roomType == RoomType.ICU)
                icuRoom--;

            if(roomType == RoomType.Oxygen)
                OxygenRoom--;

        }

        public void remainAvailibility() {
            Console.WriteLine("------Remaining Avaibility-----------");
            Console.WriteLine($"normalroom = {normalRoom}");
            Console.WriteLine($"ICU = {icuRoom}");
            Console.WriteLine($"oxygenroom = {OxygenRoom}");
            Console.WriteLine($"Ventilator = {resourceAvail.Ventilators}");
            Console.WriteLine($"normalMask = {resourceAvail.NormalMasks}");
            Console.WriteLine($"NonRebreatherMasks = {resourceAvail.NonRebreatherMasks}");
            Console.WriteLine($"ReclinerBeds = {resourceAvail.ReclinerBeds}");
            Console.WriteLine($"FlatBeds = {resourceAvail.FlatBeds}");
        
        }


    }
}
