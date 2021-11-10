using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroInterfaceDemo
{
    public abstract class SuperHero
    {

    }
    public abstract class Alien : SuperHero
    {

    }

    public abstract class Human : SuperHero
    {

    }


    public class Batman : Human, IFlyable, ISeeThroughThings
    {
        public void Fly()
        {
            Console.WriteLine("I defy gravity by gliding with my cloak");
        }

        public void LookThroughObjects()
        {
            Console.WriteLine("I have use my special gadgets to get X-Ray Vision");
        }
    }



    public class SuperMan : Alien, IFlyable, ISeeThroughThings
    {
        public void Fly()
        {
            // throw new NotImplementedException();
            Console.WriteLine("I defy gravity with my special powers");
        }

        public void LookThroughObjects()
        {
            Console.WriteLine("I have X-Ray Vision");
        }
    }


}
