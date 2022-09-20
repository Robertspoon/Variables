using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables");
            Console.WriteLine();

            // variables 
            int score; //declaraction -- declare "score" is an interger
            score = 0; //initialization -- int, "score" to be 0
            int enemyPoints;
            enemyPoints = 100;
            Console.WriteLine("Score: " + score);

            score = score + enemyPoints;
            Console.WriteLine("Score: " + score); //display score
            Console.WriteLine();

            // floating points
            float lapTime; //declaration
            lapTime = 0.0f; //initialization
            Console.WriteLine("lapTime: " + lapTime);
            lapTime = 65.357f;
            Console.WriteLine("lapTime: " + lapTime);
            Console.WriteLine();

            //string (text)
            string title; //declaration
            title = "Newbie";
            Console.WriteLine(title);
            title = "Pro";
            Console.WriteLine(title);


            Console.ReadKey(true);
        }
    }
}
