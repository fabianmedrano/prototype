using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character originalCharacter = new Character();
            originalCharacter.Health = 100;
            originalCharacter.Strength = 150;
            originalCharacter.Defence = 200;

            Character clone = originalCharacter.Clone();
            clone.Defence = 600;
            clone.Health = 60;

            Console.WriteLine(originalCharacter);
            Console.WriteLine(clone);

        }
    }
}
