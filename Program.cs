using System;

namespace sortingByBubbleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] grade = new double[25];
            Console.Write("Enter the first student's first grade: ");
            grade[0] = double.Parse(Console.ReadLine());
            Console.Write("Enter the first student's second grade: ");
            grade[1] = double.Parse(Console.ReadLine());
            Console.Write("Enter the first student's third grade: ");
            grade[2] = double.Parse(Console.ReadLine());
            Console.Write("Enter the first student's fourth grade: ");
            grade[3] = double.Parse(Console.ReadLine());
            Console.Write("Enter the first student's fifth grade: ");
            grade[4] = double.Parse(Console.ReadLine());  
            Console.Write("Enter the second student's first grade: ");
            grade[5] = double.Parse(Console.ReadLine());
            Console.Write("Enter the second student's second grade: ");
            grade[6] = double.Parse(Console.ReadLine());
            Console.Write("Enter the second student's third grade: ");
            grade[7] = double.Parse(Console.ReadLine());
            Console.Write("Enter the second student's fourth grade: ");
            grade[8] = double.Parse(Console.ReadLine());
            Console.Write("Enter the second student's fifth grade: ");
           grade[9] = double.Parse(Console.ReadLine());
            Console.Write("Enter the third student's first grade: ");
            grade[10] = double.Parse(Console.ReadLine());
            Console.Write("Enter the third student's second grade: ");
            grade[11] = double.Parse(Console.ReadLine());
            Console.Write("Enter the third student's third grade: ");
            grade[12] = double.Parse(Console.ReadLine());
            Console.Write("Enter the third student's fourth grade: ");
            grade[13] = double.Parse(Console.ReadLine());
            Console.Write("Enter the third student's fifth grade: ");
            grade[14] = double.Parse(Console.ReadLine());           
            Console.Write("Enter the fourth student's first grade: ");
           grade[15] = double.Parse(Console.ReadLine());
            Console.Write("Enter the fourth student's second grade: ");
            grade[16] = double.Parse(Console.ReadLine());
            Console.Write("Enter the fourth student's third grade: ");
            grade[17] = double.Parse(Console.ReadLine());
            Console.Write("Enter the fourth student's fourth grade: ");
            grade[18] = double.Parse(Console.ReadLine());
            Console.Write("Enter the fourth student's fifth grade: ");
            grade[19] = double.Parse(Console.ReadLine());           
            Console.Write("Enter the fifth student's first grade: ");
            grade[20] = double.Parse(Console.ReadLine());
            Console.Write("Enter the fifth student's second grade: ");
            grade[21] = double.Parse(Console.ReadLine());
            Console.Write("Enter the fifth student's third grade: ");
            grade[22] = double.Parse(Console.ReadLine());
            Console.Write("Enter the fifth student's fourth grade: ");
            grade[23] = double.Parse(Console.ReadLine());
            Console.Write("Enter the fifth student's fifth grade: ");
            grade[24] = double.Parse(Console.ReadLine());

            double sum1 = grade[0] + grade[1] + grade[2] + grade[3] + grade[4];
            double sum2 = grade[5] + grade[6] + grade[7] + grade[8] + grade[9];
            double sum3 = grade[10] + grade[11] + grade[12] + grade[13] + grade[14];
            double sum4 = grade[15] + grade[16] + grade[17] + grade[18] + grade[19];
            double sum5 = grade[20] + grade[21] + grade[22] + grade[23] + grade[24];

            Console.WriteLine("");
            double average1 = sum1 / 5;
            Console.WriteLine($"The first student's semester grade is: {average1}:f2");
            double average2 = sum2 / 5;
            Console.WriteLine($"The second student's semester grade is: {average2}:f2");
            double average3 = sum3 / 5;
            Console.WriteLine($"The third student's semester grade is: {average3}:f2");
            double average4 = sum4 / 5;
            Console.WriteLine($"The fourth student's semester grade is: {average4}:f2");
            double average5 = sum5 / 5;
            Console.WriteLine($"The fifth student's semester grade is: {average5}:f2");
            Console.WriteLine("");

            double averageClassGrade = (average1 + average2 + average3 + average4 + average5) / 5;
            Console.WriteLine($"The average class grade for the semester is: {averageClassGrade}:f2");

        }
    }
}
