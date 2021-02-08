using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deji_programming_assignment
{
    class DivideByZeroExceptionHandling
    {
        static void Main(string[] args)
        {
            bool continueLoop = true; //determines whether to keep looping

            do
            {
                //retrieve user input and calculate miles per galon
                try
                {
                    //Convert.ToInt32 generates FormatException
                    //if arguement cannot be converted to an integer
                    Console.Write("Enter an integer milesdriven");
                    int milesdriven = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter an integer gallonsused");
                    int gallonsused = Convert.ToInt32(Console.ReadLine());

                    //division generates DivideByZeroException
                    //if denominator is 0
                    int result = milesdriven / gallonsused;

                    //display result
                    Console.WriteLine("\nResult: {0} / {1} = {2}", milesdriven, gallonsused, result);
                    continueLoop = false;

                } //end try
                catch (FormatException formatException)
                {
                    Console.WriteLine("\n" + formatException.Message);
                    Console.WriteLine("You must enter two intergers. Please try again.\n");
                } //end catch
                catch (DivideByZeroException divideByZeroException)
                {
                    Console.WriteLine("\n" + divideByZeroException.Message);
                    Console.WriteLine("Zero is an invalid gallonused. Please try again.\n");
                } //end catch
            } while (continueLoop);
        }
    }
}