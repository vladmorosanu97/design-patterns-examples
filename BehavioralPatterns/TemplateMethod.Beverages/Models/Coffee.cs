using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.BeveragesWithHooks.Models
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}