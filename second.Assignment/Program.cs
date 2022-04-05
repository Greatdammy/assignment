using System;

namespace second.Assignment
{

    public class Vehicle
    {
        public string brandName = "FORD";

        public void DisplayVehicleType(string vehicleType)
        {
            Console.WriteLine("This is a {0}", vehicleType);
        }
    }
    

    public class Car : Vehicle
    {
        public string vehicleType = "Car";

        public void GetBrandName()
        {
            Console.WriteLine("Brand: {0}", brandName);
        }
           
    }
      
    public class Truck : Vehicle
    {
        public string vehicleType = "Truck";

        public void GetBrandName()
            {
            Console.WriteLine("Brand: {0}", brandName);
        }
    }

    public class Motorcycle : Vehicle
    {
        public string vehicleType = "Motorcycle";

        public void GetBrandName()
        {
            Console.WriteLine("Brand: {0}", brandName);
        }
    }
    
    public class Program
    {
       public static void Main()
        {
            Car _suv = new Car();
            _suv.DisplayVehicleType("Explorer");
            _suv.GetBrandName();


            Truck truck = new Truck();
            truck.DisplayVehicleType("Ford ranger");
            truck.GetBrandName();

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.DisplayVehicleType("Cleveland");
            motorcycle.GetBrandName();
        }
    }
}
