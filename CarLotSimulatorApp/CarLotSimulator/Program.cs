using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();
            
            //TODO
            
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            
            var carOne = new Car();
            carOne.Make = "Honda";
            carOne.Model = "Accord";
            carOne.Year = 2005;
            carOne.isDriveable = true;
            
           carOne.MakeEngineNoise("burrrrrmmm");
           carOne.MakeHonkNoise("HONKKKKKKKK");
           
           carLotOne.ParkingLot.Add(carOne);

           var carTwo = new Car()
           {
               Make = "Toyota",
               Model = "Camery",
               Year = 2020,
               isDriveable = true,

           };
           
           carTwo.MakeEngineNoise(" " );
           carTwo.MakeHonkNoise("BEEP");
           
           carLotOne.ParkingLot.Add(carTwo);
           
           var carThree = new Car(make: "Hyundai", model:"Veloster", year:2013,isDriveable:true);
            carThree.MakeEngineNoise("Vrooom");
            carThree.MakeHonkNoise("Beep beep");
            
            carLotOne.ParkingLot.Add(carThree);
            

           //*************BONUS X 2*************//

           //Create a CarLot class
           //It should have at least one property: a List of cars
           //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
           //At the end iterate through the list printing each of car's Year, Make, and Model to the console
           
           
           
           carLotOne.CheckCars();
        }
        
    }
}
