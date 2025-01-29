using System.IO;
using EmployeeLibrary;


namespace OOP01
{
    internal class Program
    {

        static void Main(string[] args)
        {
           //Name Space : -  هيكل تنظيمي للكود بتاعى  -- is a container 
           // forbidden the Name Conflicts
           //using / can skip the fully qualified in the Name Space -- and write Direct Class Name 
         ///*  EmployeeLibrary.*/Employee employee = new EmployeeLibrary.Employee();
         //   Salary salary = new Salary();

         //   EmployeeHR.Employee employeeHR = new EmployeeHR.Employee();
         //   EmployeeLibrary.Employee employee1 = new EmployeeLibrary.Employee();
       
            Employee employee = new Employee();
        }


    }
   
}

// Currently -> have Two Class Employee in different Name Space
// How to Select Employee in different Name Space

//namespace EmployeeLibrary
//{
//class Employee
//    {

//    }
//    class Salary
//    {

//    }
//}

//namespace EmployeeHR
//{
//    class Employee
//    {

//    }

//}
