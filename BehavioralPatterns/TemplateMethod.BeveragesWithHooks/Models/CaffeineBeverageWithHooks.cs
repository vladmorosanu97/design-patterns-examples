using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.BeveragesWithHooks.Models;

namespace TemplateMethod.BeveragesWithHooks.Models
{
    public abstract class CaffeineBeverageWithHooks : CaffeineBeverageAbstract
    {
        public sealed override void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCoup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
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

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}