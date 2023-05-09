using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var lot = new CarLot();

            var car1 = new Car();
            car1.Make = "Hyundai";
            car1.Model = "Kona";
            car1.Year = 2022;
            car1.IsDrivable = true;
            car1.EngineNoise = "vroom vroom";
            car1.HonkNoise = "beep beep";

            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            lot.Cars.Add(car1);

            var car2 = new Car()
            {
                Make = "Honda",
                Model = "Civic",
                Year =2021,
                EngineNoise = "Vroooooom",
                HonkNoise = "Beeeep",
                IsDrivable = true
            };

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            lot.Cars.Add(car2);

            var car3 = new Car("Chevy", "Nova", 1974, "bvrooom", "BEP", true);

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            lot.Cars.Add(car3);

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
}
