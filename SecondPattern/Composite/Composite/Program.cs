using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var plants = new List<IPlant>();

            var branch = new Branch(new List<IPlant>() { new Leaf(), new Leaf() });
            var anotherBranch = new Branch(new List<IPlant>() { new Leaf(), new Leaf(), new Leaf(), new Leaf() });

            plants.Add(new Branch(
                new List<IPlant>()
                    { branch, anotherBranch }
            ));

            plants.Add(new Leaf());
            plants.Add(new Branch(new List<IPlant>() { new Leaf(), new Leaf(), new Leaf(), new Leaf(), new Leaf() }));
            plants.Add(new Leaf());

            foreach (IPlant plant in plants)
            {
                plant.Eat();
            }
            Console.ReadKey();
        }
    }
}
