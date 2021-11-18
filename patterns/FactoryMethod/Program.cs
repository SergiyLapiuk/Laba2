using System;
namespace FactoryMethodExample
{
    //абстрактний клас творця, який має абстрактний метод FactoryMethod, що приймає тип продукта
    public abstract class Creator
    {
        public abstract  Car FactoryMethod(int type);
    }

    public class ConcreteCreator : Creator
    {
        public override Car FactoryMethod(int type)
        {
            switch (type)
            {
                
                case 1: return new Merecedes();
                
                case 2: return new BMW();
                default: throw new ArgumentException("Invalid type.", "type");
            }
        }
    }

    public abstract class Car 
    {
        abstract public void info();
    } 

    //конкретні продукти з різною реалізацією
    public class Merecedes : Car
    {
        override public void info()
        {
            Console.WriteLine("Створено Mercedes!");
        }
    }

    public class BMW : Car
    {
        override public void info()
        {
            Console.WriteLine("Створено BMW!");
        }
    }

    class MainApp
    {
        static void Main()
        {       //створюємо творця
            Creator creator = new ConcreteCreator();
            for (int i = 1; i <= 2; i++)
            {
                //створюємо спочатку продукт з типом 1, потім з типом 2
                var car = creator.FactoryMethod(i);
                Console.Write("Where id = {0} ", i);
                car.info();
            }
            Console.ReadKey();
        }
    }
}

