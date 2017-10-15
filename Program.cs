using System;
//Must have for Lists
using System.Collections.Generic;

namespace C_
{
    class Program
    {
        //Make Lists
        static List<string> cars = new List<string>{"Audi", "Mazda", "toyota", "Nissan"};
        static List<string> drivers = new List<string>{"Matt", "Jeff", "Tom","Harry"};
       
       
       //Prints string DisplayDriver to screen
        static void Main(string[] args)
        {
           Console.WriteLine(DisplayDriver());
           Console.WriteLine(DisplayDriver());
           Console.WriteLine(DisplayDriver());
        }
        //Makes Random Number
        static int GenerateRandomNumber(List<string> myList){
             var rand = new Random();
             //Lets random number be as long as list
             return rand.Next(1, myList.Count);

        }
        //Create variables that = string name / Genertate Random numbers
        static string DisplayDriver(){
            var selectedCar = cars[GenerateRandomNumber(cars)];
            var selectedDriver = drivers[GenerateRandomNumber(drivers)];
            //Return Driver / Car
            return $"{selectedDriver} is driving the = {selectedCar}";
        }
    }
}
