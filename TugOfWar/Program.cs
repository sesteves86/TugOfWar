using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugOfWar
{
    class Program
    {
        static void Main(string[] args)
        {
            int levelMax = 3;

            for (int level = 1; level < levelMax; level++)
            {
                //Initial Values
                int PointsA = 100;
                int PointsB = 100;
                int score = 0;
                int spentA = 0;
                int spentB = 0;
                bool isPlaying = true;

                while (isPlaying)
                {
                    //Show score and points
                    Console.WriteLine("Score: " + score);
                    Console.WriteLine("Points A: " + PointsA);
                    Console.WriteLine("Points B: " + PointsB);

                    //Player A inserts a number
                    bool isNumber = false;
                    do
                    {
                        Console.WriteLine("Please insert a number");
                        string pointsSpent = Console.ReadLine();
                        if (int.TryParse(pointsSpent, out spentA))
                            isNumber = true;
                    } while (!isNumber);

                    //Read the AI value
                    switch (level)
                    {
                        case 1:
                            spentB = AI.Level1AI(PointsB);
                            break;
                        case 2:
                            spentB = AI.Level2AI(PointsB);
                            break;
                        case 3:
                            spentB = AI.Level3AI(PointsB);
                            break;
                    }

                    //Update results
                    if (spentA > PointsA)
                        spentA = PointsA;

                    if (spentB > PointsB)
                        spentB = PointsB;

                    PointsA -= spentA;
                    PointsB -= spentB;

                    if (spentA > spentB)
                        score++;
                    if (spentA < spentB)
                        score--;

                    //Check if the game ends
                    if (score >= 10)
                    {
                        isPlaying = false;
                        Console.WriteLine("========================");
                        Console.WriteLine("You won level " + level.ToString());
                        Console.WriteLine("========================");
                    }
                    if (score <= -10)
                    {
                        isPlaying = false;
                        Console.WriteLine("You lost on level " + level.ToString());
                    }


                }
            }

            Console.ReadKey();
        }
    }
}
