using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_staticmethodexample
{
    internal class employee
    {//Note:If you want to access static members outside no need to create a object
        public int employeeNumber;//non static variable or normal/instance variable or fields
        public static string companyname;//static variable
        public static string companylocation;//static variable
        static employee()//static constructor=>before classname() if u use static keyword.we called this as static constructor.
        {//To assign the data for static variables we will use static constuctor.
            companyname = "wipro";
            companylocation = "hyderabad";
            //employeeNumber = 100;//you can't assign data to normal variable in static constuctor.it will throe compiletime error..
        }
        public employee()//non static constructor or instance constructor or normal constuctor.
        {//To assign the data to non static variables we will use normal or instance constructor.
            this.employeeNumber = 10;
        }
        /*methodsynatx:
        accessmodifier qualifier returntype methodname(arguments or parameters)
        {
          return data;
        }
        Note:qualifier  means static...this is optional
         */
        public static void displaycompanydetails()//static method
        {//static method is used to acces or dispaly only static variables data  only.
            Console.WriteLine("company name is:" + companyname);
            Console.WriteLine("company location is:" + companylocation);
            //Console.WriteLine("company location is:" + employeeNumber);//u can't use normalor non static  variables in static method.it will throw compiletime error.
        }
        public void displayempdateils()//non static method or instance method or normal method.
        {
            Console.WriteLine("company name is:" + companyname);//we can access static variables in non static method
            Console.WriteLine("company location is:" + companylocation);//it will not throw any compiletime error
            Console.WriteLine("employeenumber is" + employeeNumber);
        }
    }
}
//Normal/instance/static/non static variables we can access and call in normal/non static method.
//but in static constuctor or static method we can access only static related things only.(non static memebers we can't access.it will throw compiletime error)