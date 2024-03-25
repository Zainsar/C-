using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNCTION
{
    public class polymorphism2
    {
        public virtual void parent()
        {
            Console.WriteLine("ParentClass");
        }
    }

    public class child2 : polymorphism2
    {
        public override void parent()
        {
            base.parent();
            Console.WriteLine("ChildClass");
        }
    }

}
