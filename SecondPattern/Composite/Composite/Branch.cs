using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Branch : IPlant
    {
        private readonly IList<IPlant> children;

        public Branch(IList<IPlant> children)
        {
            this.children = children;
        }

        public void Eat()
        {
            foreach (var child in children)
            {
                child.Eat();
            }
        }
    }
}
