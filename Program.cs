using System;

namespace SuperHeroInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SuperMan sm = new SuperMan();

            sm.Fly();
            sm.LookThroughObjects();



            Batman batman = new Batman();

            batman.Fly();
            batman.LookThroughObjects();


        }
    }
}
