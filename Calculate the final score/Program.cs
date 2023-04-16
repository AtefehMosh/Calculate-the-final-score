using System;

namespace Calculate_the_final_score
{
    class Program

    { 
        static void Main(string[] args)
       {
        Console.Write("Please Enter midterm Mark.. ");
        double midtermMark = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please Enter final mark.. ");
        double finalMark = Convert.ToDouble(Console.ReadLine());
            double show = Clac(midtermMark, finalMark);
         
            if (show>= 10)
                Console.WriteLine("You pass the Exam and your grade is: "+show);
        } 
        
        private static double Clac(double x,double y)
        {
            double result = (0.35 * x) + (0.65 * y);
            return result;
                
        }
    
    }
}
