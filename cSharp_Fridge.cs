// C# fridge object

using System;
using System.Collections.Generic;

namespace FridgeApp
{
    public class Fridge
    {
        public List<string> Foods { get; set; }

        public Fridge()
        {
            Foods = new List<string>();
        }

        public void AddFood(string food)
        {
            Foods.Add(food);
        }

        public void RemoveFood(string food)
        {
            Foods.Remove(food);
        }

        public void ClearFridge()
        {
            Foods.Clear();
        }

        public void PrintFoods()
        {
            Console.WriteLine("Foods in the fridge:");
            foreach (string food in Foods)
            {
                Console.WriteLine(food);
            }
        }
    }
}


// Add food and output whats in the fridge
Fridge fridge = new Fridge();
fridge.AddFood("Milk");
fridge.AddFood("Eggs");
fridge.AddFood("Butter");
fridge.PrintFoods(); // Outputs: "Foods in the fridge: Milk, Eggs, Butter"

