class Stepcounter : ForFuncShow
    {
        static int ClearingNumber;
        public StepExtension counter = new StepExtension();
        public int[] StepsPerDay = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
        public double[] distance = new double[7] { 0, 0, 0, 0, 0, 0, 0 };
        public int[] history = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
        public void ShowHistory()
        {
            for (int i = 0; i < 7; i++)
            {
                if (i + 1 == 1)
                {
                    Console.Write("Пн: ");
                }
                else
                    if (i + 1 == 2)
                {
                    Console.Write("Вт: ");
                }
                else
                    if (i + 1 == 3)
                {
                    Console.Write("Ср: ");
                }
                else
                    if (i + 1 == 4)
                {
                    Console.Write("Чт: ");
                }
                else
                    if (i + 1 == 5)
                {
                    Console.Write("Пт: ");
                }
                else
                    if (i + 1 == 6)
                {
                    Console.Write("Сб: ");
                }
                else
                {
                    Console.Write("Вс: ");
                }
                Console.Write(history[i]);
                Console.WriteLine(" шагов");
            }
        }
        public void CountRunning(int day, double distance, int time, int height)
        {
            CountStepsAtEnd(day, counter.DistanceToSteps(distance, height), height);
            Console.Write("Вы прошли ");
            Console.Write(counter.DistanceToSteps(distance, height));
            Console.WriteLine(" шагов");
            Console.Write("Ваша средняя скорость: ");
            Console.Write(Math.Round(distance / time, 1));
            Console.WriteLine(" км/ч");
            history[day - 1] += counter.DistanceToSteps(distance, height);
        }
        public void CountStepsAtEnd(int day, int steps, int height)
        {
            if (day == 1 & ClearingNumber == 0)
            {
                for (int i = 1; i < 7; i++)
                {
                    StepsPerDay[i] = 0;
                    distance[i] = 0;
                    history[i] = 0;
                }
            }
            ClearingNumber++;
            if (day == 7 & ClearingNumber != 0)
            {
                ClearingNumber = 0;
            }
            StepsPerDay[day - 1] += steps;
            distance[day - 1] += counter.StepsToDistance(steps, height);
        }
        public override void Show()
        {
            for (int i = 0; i < 7; i++)
            {
                if (i + 1 == 1)
                {
                    Console.Write("Пт: ");
                }
                else
                    if (i + 1 == 2)
                {
                    Console.Write("Вт: ");
                }
                else
                    if (i + 1 == 3)
                {
                    Console.Write("Ср: ");
                }
                else
                    if (i + 1 == 4)
                {
                    Console.Write("Чт: ");
                }
                else
                    if (i + 1 == 5)
                {
                    Console.Write("Пт: ");
                }
                else
                    if (i + 1 == 6)
                {
                    Console.Write("Сб: ");
                }
                else
                {
                    Console.Write("Вс: ");

                }
                Console.Write(StepsPerDay[i]);
                Console.Write(" Дистанция: ");
                Console.Write(Math.Round(distance[i], 1));
                Console.WriteLine(" км");
            }
        }
    }