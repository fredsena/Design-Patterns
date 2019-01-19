using DesignPatterns.Core.Strategy.DuckStrategy.Algorithm;
using DesignPatterns.Core.Strategy.DuckStrategy.Ducks;
using System;

namespace DesignPatterns.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var modelDuck = new ModelDuck();
            modelDuck.DoFly();

            modelDuck.SetFlyBehavior(new FlyWithWings());
            modelDuck.DoFly();

            Console.ReadLine();
        }
    }
}
