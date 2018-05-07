using System;
using System.Collections.Generic;
using System.Linq;
//Here is a short warmup program to help you get familiar with C# and Visual Studio.
//Write a program that outputs some information about yourself that others may find interesting.Some suggestions include your major, hometown, hobbies, pets, etc.
//Watch the videos that demonstrate stepping through code and setting breakpoints.
//Along with your program, include a screen shot of you stepping through your program and one of your program running to a breakpoint.

// Christopher K. Dierolf
// 5/7/2018
// Week 1 Warmup

namespace Week1Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Outputting with multiple WriteLine's
            Console.WriteLine("Name: Christopher K. Dierolf\n");
            Console.WriteLine("Age: 32\n");
            Console.WriteLine("Hometown: Hendersonville, TN\n");
            Console.WriteLine("Pets: Aziz (Savannah Cat), Cooper (Tabby Cat)\n\n");

            // Outputting the same content using arrays and loops.
            string[] sDemographicCategorys = { "Name: ", "Age: ", "Hometown: ", "Pets: " };
            string[] sDemographics = { "Christopher K. Dierolf", "32", "Hendersonville, TN", "Aziz (Savannah Cat), Cooper (Tabby Cat)" };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(sDemographicCategorys[i] + " " + sDemographics[i] + Environment.NewLine);
            }

            // Extra Warmup and Exploration

            // Playing with a linq expression that I found on the internet for funsies.
            int[] iScores = new int[] { 93, 32, 31, 64 };
            IEnumerable<int> scoreQuery = from score in iScores where score > 2 select score;
  
            foreach (int i in scoreQuery)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine(Environment.NewLine);

            // Reading console input into ReadLines and toying with conditional statements
            string name, quest, airspeed;
            Console.WriteLine("WHHAAAT Is your name?");
            name = Console.ReadLine();
            Console.WriteLine("WHHAAAT Is your quest?");
            quest = Console.ReadLine();
            Console.WriteLine("WHHAAAT Is the airspeed velocity of an unladen swallow?");
            airspeed = Console.ReadLine();

            if (airspeed == "What do you mean? An African Swallow or a European Swallow?")
            {
                Console.WriteLine("What?! I don't know that!\n");
                Console.WriteLine("AAIIIEEEEEEEE!!!");
            }
            else
            {
                Console.WriteLine("It's got big gnashing teeth!");
            }

            
            Console.ReadLine();
        }
    }
}
