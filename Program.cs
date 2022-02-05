using System;
namespace MyProg
{
    class Stepcounter
    {
        public int[] StepsPerDay = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
        public double[] distance = new double[7] { 0, 0, 0, 0, 0, 0, 0 };
        public void CountStepsAtEnd(int day, int steps)
        {
            if (day == 1)
            {
                for (int i = 1; i < 7; i++)
                {
                    StepsPerDay[i] = 0;
                    distance[i] = 0;
                }
            }
            StepsPerDay[day - 1] = steps;
            distance[day - 1] = steps * 0.0012;
        }
        public void Print()
        {
            for (int i = 0; i < 7; i++)
            {
                if (i + 1 == 1)
                {
                    Console.Write("Mon: ");
                }
                else
                    if (i + 1 == 2)
                {
                    Console.Write("Tue: ");
                }
                else
                    if (i + 1 == 3)
                {
                    Console.Write("Wed: ");
                }
                else
                    if (i + 1 == 4)
                {
                    Console.Write("Thu: ");
                }
                else
                    if (i + 1 == 5)
                {
                    Console.Write("Fri: ");
                }
                else
                    if (i + 1 == 6)
                {
                    Console.Write("Sat: ");
                }
                else
                {
                    Console.Write("Sun: ");

                }
                Console.Write(StepsPerDay[i]);
                Console.Write(" Distance: ");
                Console.Write(Math.Round(distance[i], 1));
                Console.WriteLine();
            }
        }
    }
    class TrainCounter
    {

    }
    class Program
    {
        static void Main()
        {
            Stepcounter a = new Stepcounter();
            a.CountStepsAtEnd(Convert.ToInt32(DateTime.Today.DayOfWeek), 10000);
            a.Print();
        }
    }
}
