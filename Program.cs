using System;

namespace gradecalculator
{
    class Program
    {   
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Integer Grade 1-100");


            int Grade;
            string input = Console.ReadLine();
            Grade = int.Parse(input);



            if (Grade < 60)
            {
                Console.WriteLine("Grade equals F");
            }
            else if (Grade <= 64)
            {
                Console.WriteLine("Grade equals D-");
            }
            else if (Grade <= 67)
            {
                Console.WriteLine("Grade equals D");
            }
            else if (Grade <= 70)
            {
                Console.WriteLine("Grade equals D+");
            }
            else if (Grade <= 74)
            {
                Console.WriteLine("Grade equals C-");
            }
            else if (Grade <= 77)
            {
                Console.WriteLine("Grade Equals C");
            }
            else if (Grade <= 80)
            {
                Console.WriteLine("Grade equals C+");
            }
            else if (Grade <= 84)
            {
                Console.WriteLine("Grade equals B-");
            }
            else if (Grade <= 87)
            {
                Console.WriteLine("Grade equals B");
            }
            else if (Grade <= 90)
            {
                Console.WriteLine("Grade equals B+");
            }
            else if (Grade <= 94)
            {
                Console.WriteLine("Grade equals A-");
            }
            else if (Grade <= 97)
            {
                Console.WriteLine("Grade equals A");
            }
            else
            {
                Console.WriteLine("Grade equals A+");
            }
            
          
        }
    }
}
 