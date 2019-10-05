using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Leaf : IPlant
    {
        public bool IsEaten { get; private set; } = false;

        public void Eat()
        {
            IsEaten = true;
            Console.WriteLine("Leaf eaten!");
        }
    }
}
