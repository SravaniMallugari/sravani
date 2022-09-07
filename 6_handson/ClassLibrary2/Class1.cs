using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public abstract class person
    {

        public abstract void work();

    }
    public class employees : person
    {


        public override void work()
        {
            Console.WriteLine("he is an employee");
        }
    }
    public class manager : person
    {


        public override void work()
        {
            Console.WriteLine("he is a manager ");
        }
    }
    public class clerk : person
    {


        public override void work()
        {
            Console.WriteLine("he is a  clerk");
        }
    }

}

