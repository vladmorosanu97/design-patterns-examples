using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.BeveragesWithHooks.Models;

namespace TemplateMethod.BeveragesWithHooks
{
    public abstract class CaffeineBeverage: CaffeineBeverageAbstract
    {
        public sealed override void  PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCoup();
            AddCondiments();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }


        public void PourInCoup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public abstract void Brew();
        public abstract void AddCondiments();
    }
}