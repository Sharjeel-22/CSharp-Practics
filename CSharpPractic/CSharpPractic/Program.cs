using CSharpPractic;
using System;

namespace HelloWorldDemoApplication
{
    public static class Product
    {
        private static string productName = "";
        private static int price = 0;
        private static string description = "";

        static Product()
        {
            productName = "Mobile";
            price = 36000;
            description = "This is brand new mobile for sell";
        }
        public static void getProduct()
        {
            Console.WriteLine("Product Name is  {0}", productName);
            Console.WriteLine("Product Price is  {0}", price);
            Console.WriteLine("Product Details is  {0}", description);
        }

    }
    
    public class HelloWorld
    {
        private string name;
        private int age;
        private string address;
        private string phone;
        private static string gender = "Man";
        private static string City = "Islamabad";
        private static string address2 = "dddd";

        // Default constructor
        public HelloWorld()
        {
            this.name = "Sharjeel";
            this.age = 24;
            this.address = "Islamabad";
            this.phone = "0300000000";
            Console.WriteLine("User name is {0}", this.name);
            Console.WriteLine("User age is {0}", this.age);
            Console.WriteLine("User address is {0}", this.address);
            Console.WriteLine("User phone is {0}", this.phone);
            Console.WriteLine("User Gender is {0}", gender);
        }

        // Parameterized constructor
        public HelloWorld(string name, int age, string address, string phone)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.phone = phone;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("User name is {0}", this.name);
            Console.WriteLine("User age is {0}", this.age);
            Console.WriteLine("User address is {0}", this.address);
            Console.WriteLine("User phone is {0}", this.phone);
            Console.WriteLine("User Gender is {0}", gender);
        }
        public class EmployeeDetail : Employee
        {
            public EmployeeDetail()
            {
                Console.WriteLine("EmployeeDetail");
            }
        }

        // Copy constructor
        public HelloWorld(HelloWorld hello)
        {
            this.name = hello.name;
            this.age = hello.age;
            this.address = hello.address;
            this.phone = hello.phone;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Copy constructor is called");
            Console.WriteLine("Copy User name is {0}", this.name);
            Console.WriteLine("Copy User age is {0}", this.age);
            Console.WriteLine("Copy User address is {0}", this.address);
            Console.WriteLine("Copy User phone is {0}", this.phone);
            Console.WriteLine("User Gender is {0}", gender);
        }

        // Static constructor
        static HelloWorld()
        {
            City = "Hello";
            address2 = "Lahore";
        }

        static void Main(string[] args)
        {
            Product.getProduct();
            HelloWorld user = new HelloWorld();
            HelloWorld user2 = new HelloWorld("Rehan Rajpoot", 25, "Islamabad", "03222222222");
            user2.name = "Zeshaan";
            user2.age = 30;
            user2.address = "Islamabad";
            user2.phone = "0366666666666";
            HelloWorld user3 = new HelloWorld(user2);
            EmployeeDetail ed = new EmployeeDetail();
            Console.WriteLine("Inherit from other class :: {0}", ed.getEmployeeName()); ;
        }
    }
}
