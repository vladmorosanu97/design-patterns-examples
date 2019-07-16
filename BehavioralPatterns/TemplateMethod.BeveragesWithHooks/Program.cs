using System;
using TemplateMethod.BeveragesWithHooks.Models;

namespace TemplateMethod.BeveragesWithHooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TeaWithHooks tea = new TeaWithHooks();
            CoffeeWithHooks coffee = new CoffeeWithHooks();

            tea.PrepareRecipe();
            coffee.PrepareRecipe();
        }
    }
}
