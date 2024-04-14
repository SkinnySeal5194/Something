using System;
namespace Level2;
class Program
{
    static void Main(string[] args)
    {
        

        int total = 0;
        int something =0;

        for (int gradeCounter = 1; gradeCounter <= 5; gradeCounter++)
        {

            Console.Write("Enter the grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            total = total + grade;
            something -=grade;

        }
        Console.WriteLine("The average of the class is: " + total / 5);
        Console.Read();
    }
}

