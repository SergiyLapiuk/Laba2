using System;
using System.Text;
namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            // Create ConcreteComponent and two Decorators
            Console.OutputEncoding = Encoding.UTF8;
            spruce setTree = new spruce();
            HangToy hangToy = new HangToy();
            Garland turnOnGarland = new Garland();

            // Link decorators
            hangToy.SetComponent(setTree);
            turnOnGarland.SetComponent(hangToy);

            turnOnGarland.beautify();

            // Wait for user
            Console.Read();
        }
    }
    // "Component"
    abstract class Tree
    {
        public abstract void beautify();
    }

    // "ConcreteComponent"
    class spruce : Tree
    {
        public override void beautify()
        {
            Console.WriteLine("Ялинку встановлено");
        }
    }
    // "Decorator"
    abstract class Decorator : Tree
    {
        protected Tree component;

        public void SetComponent(Tree component)
        {
            this.component = component;
        }
        public override void beautify()
        {
            if (component != null)
            {
                component.beautify();
            }
        }
    }

    // "ConcreteDecoratorA"
    class HangToy : Decorator
    {
        private string toy;

        public override void beautify()
        {
            base.beautify();
            toy = "blue toy";
            Console.WriteLine("Встановлено синю іграшку");
        }
    }

    // "ConcreteDecoratorB" 
    class Garland : Decorator
    {
        public override void beautify()
        {
            base.beautify();
            garland();
        }
        void garland()
        { Console.WriteLine("Гірлянду увімкнено"); }
    }
}
