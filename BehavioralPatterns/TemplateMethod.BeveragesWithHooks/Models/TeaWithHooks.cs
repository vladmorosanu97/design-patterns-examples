using System;

namespace TemplateMethod.BeveragesWithHooks.Models
{
    public class TeaWithHooks: CaffeineBeverageWithHooks
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}
