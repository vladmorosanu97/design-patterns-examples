using TemplateMethod.BeveragesWithHooks.Models;

namespace TemplateMethod.BeveragesWithHooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            tea.PrepareRecipe();
            coffee.PrepareRecipe();
        }
    }
}
