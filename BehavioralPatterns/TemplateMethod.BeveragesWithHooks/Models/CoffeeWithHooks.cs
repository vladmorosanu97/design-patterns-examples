using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.BeveragesWithHooks.Models
{
    public class CoffeeWithHooks : CaffeineBeverageWithHooks
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        public override bool  CustomerWantsCondiments()
        {
            String answer = GetUserInput();
            if (answer != null && answer.ToLower().StartsWith("y"))
            {
                return true;
            }

            return false;
        }

        private string GetUserInput()
        {
            Console.WriteLine("Would you like milk and sugar?");
            return Console.ReadLine();
        }
    }
}