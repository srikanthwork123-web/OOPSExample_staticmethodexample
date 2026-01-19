using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_staticmethodexample
{
    internal class employee
    {
        public int employeeNumber;//non static variable or normal variable
        public static string companyname;//static variable
        public static string companylocation;//static variable
        static employee()
        {//To assign the data for static variables we will use static constuctor.
            companyname = "wipro";
            companylocation = "hyderabad";
           // employeeNumber = 100;//you can't assign data to normal variable in static constuctor.
        }
        public employee()
        {
            this.employeeNumber = 10;
        }
        public static void displaycompanydetails()//static method
        {
            Console.WriteLine("company name is:" + companyname);
            Console.WriteLine("company location is:" + companylocation);
        }
        public void displayempdateils()
        {
            Console.WriteLine("employeenumber is" + employeeNumber);
        }
    }
}
