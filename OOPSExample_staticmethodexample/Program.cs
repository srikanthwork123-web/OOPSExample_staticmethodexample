using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_staticmethodexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to access the static varibales or static methods in outside class
            //static method calling syntax:classname.methodname    
            employee.displaycompanydetails();


            //to access the normal methods outside
            //normal method synatx:classname objectname=new classname();
            employee objectname = new employee();
            objectname.displayempdateils();
        }
    }
}
