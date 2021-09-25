using System;
namespace OOP
{
    // This program demo. how to call overriden function
    class FunctionOverriding
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            Console.WriteLine(myMath.Increment(10));
            Employee employee = new Employee(100, "Scott", "scott@gmail.com");
            Console.WriteLine(employee.ToString());

            Console.ReadLine();

        }

    }
}
