using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractic
{
    public class Employee
    {
        public string employeName = "Abdul Wahab";
        public Employee() 
        {
            Console.WriteLine("Hello World Employee Class");
        }
        //static void Main(string[] args)
        //{
        //    Employee emp = new Employee();
        //}
        public string getEmployeeName() 
        {
            return this.employeName;
        }
    }
}
