using System.Reflection.Metadata;

namespace Hospital
{


    public class Hospital
    {
        private Reservation reservation;
        public Hospital()
        {

            RoomInv roomInv = new RoomInv();
            reservation = new Reservation(roomInv);

        }

        public void reserveRoom(RoomType roomType)
        {
            if (reservation.ReserveRoom(roomType))
            {
                Console.WriteLine($" 01{roomType} reserved ");
                reservation.generatePatientId(roomType);
                reservation.DisplayAvailability();
                
               
            }


            else
            {
                Console.WriteLine("Sorry no rooms are available");
                reservation.DisplayAvailability();
            }


        }


    }
    public class Program
    {

        public static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            //hospital.reserveRoom(RoomType.Normal);
            //hospital.reserveRoom(RoomType.Normal);
            //hospital.reserveRoom(RoomType.Normal);
            int N = 0;
            do {
                Console.WriteLine("Please enter the type of room you want to reserve:");
                Console.WriteLine("1. NormalRoom");
                Console.WriteLine("2. OxygenRoom");
                Console.WriteLine("3. ICURoom");
                Console.WriteLine("4. EXIT ");
                Console.WriteLine("  Select :  ");
                N = Convert.ToInt32(Console.ReadLine());
                switch (N) {
                
                case 1:
                        hospital.reserveRoom(RoomType.Normal);
                        Console.WriteLine(" ");
                        break;

                case 2: hospital.reserveRoom(RoomType.Oxygen);
                        Console.WriteLine(" ");
                        break;

                case 3: hospital.reserveRoom(RoomType.ICU);
                        Console.WriteLine(" "); 
                        break;

                default:
                        //Console.WriteLine("choose the option correctly");
                        break;
                        
                
                }
                

            } while (N!=4);

        }
    }
}