using System;

namespace OOP
{
    // This program demo. how to copy constructor
    class ConstructorDemo
    {
        static void Main()
        {
            Student student1 = new Student(456, "Rachana");
            Student student2 = new Student(student1);
            Console.WriteLine($"RollNo={student2.StdRollNo}\nName={student2.StdName}");
            Console.ReadLine();

        }
    }
}
