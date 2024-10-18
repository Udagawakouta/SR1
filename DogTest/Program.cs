using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog hachi = new Dog();
            hachi.Bark();

            Dog pochi = new Dog();
            pochi.Bark();
            pochi.Run();

            Console.ReadLine();
        }
    }
}
