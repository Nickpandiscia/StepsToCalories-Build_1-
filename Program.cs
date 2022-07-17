using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepsToCalories
{
    public class Program
    {
        static void Main(string[] args)
        {            
                DateTime now = DateTime.Now;

                    Console.WriteLine($"Welcome. Todays date is {now}. ");
                Console.WriteLine("Type exit to quit program, or press any key to continue.");
                string exitAnswer = Console.ReadLine();
            do
            {
                if (exitAnswer == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("");
                }
                Console.WriteLine("How Many steps did you take today?");
                double userSteps = double.Parse(Console.ReadLine());
                double oneStepCalorieBurn = .04;
                double totalAmount = userSteps * oneStepCalorieBurn;
                Console.WriteLine($"You burned {totalAmount} calories from taking {userSteps} steps today.");
                if (userSteps < 10000)
                {
                    FileBuilder.CalorieLog($"You burned {totalAmount} calories from taking {userSteps} steps today.");
                    Console.WriteLine("Sorry. Try to walk up to 10,000 steps a day.");
                    Console.WriteLine($"Your calorie logs can be found here {FileBuilder.FilePath}.");
                    Console.WriteLine("Type exit to quit.");
                    exitAnswer = Console.ReadLine();
                }
                else
                {
                    FileBuilder.CalorieLog($"You burned {totalAmount} calories from taking {userSteps} steps today.");
                    Console.WriteLine("That is awesome! Keep up the good work!");
                    Console.WriteLine($"Your calorie logs can be found here {FileBuilder.FilePath}.");
                    Console.WriteLine("Press any key to continue, or type exit to quit.");
                    exitAnswer = Console.ReadLine();
                }
            } while (exitAnswer != "exit");
        }        
    }
}
