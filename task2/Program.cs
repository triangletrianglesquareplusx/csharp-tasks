using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputGrossSalary = int.Parse(Console.ReadLine());
            double netSalary = 0;
            if (inputGrossSalary <= 1000)
            {
                netSalary = inputGrossSalary;
            }
            else
            {
                double taxableAmount = inputGrossSalary - 1000;
                double incomeTax = taxableAmount * 0.1;
                double socialContribution = 0;
              
                if (isValueAboveTreeK(inputGrossSalary))
                {
                    //here the user should contribute social tax - how much??
                    socialContribution = (taxableAmount - (inputGrossSalary - 3000)) * 0.15;
                    netSalary = inputGrossSalary - (incomeTax + socialContribution);
                    
                }
                else
                {
                    socialContribution = taxableAmount * 0.15;
                    netSalary = inputGrossSalary - (incomeTax + socialContribution);
                }
                
            }
            Console.WriteLine(netSalary);
            //this is where I want to mention that I have no idea what you mean by "how new taxes can be implemented". Sorry about that. 
        }
        
        static bool isValueAboveTreeK(double value)
        {
            return value > 3000;
        }
       

    }
}
