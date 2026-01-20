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
        {//=========================calling static varibales /static methods in outside class ==============================
            //to access the static varibales or static methods in outside class,no need to create a object
            //static method calling syntax:classname.methodname();
            //static variable calling syntax:classname.variablename;
            employee.displaycompanydetails();
            employee.companyname = "sampledata";
            employee.companylocation = "hyderabad";
            employee.displaycompanydetails();//we can call methods multiple times also.based on your requirment.
//=========================calling non static varibales /non static methods in outside class ==============================
            //to access  normal methods(without static) in  outsideclass,we need to create a object
            //object creation syntax:classname objectname=new classname();
            //non static or instance method calling synatx:objectname.methodname();
            //non static or instance variable calling synatx:objectname.variablename;

            employee objectname = new employee();//created object for employee class.for accessing non static items/members outside.
            objectname.displayempdateils();//access the non static method using objectname.methodname();
            objectname.employeeNumber = 1000;//access the non static variable using objectname.variablename;
        }
    }
}
