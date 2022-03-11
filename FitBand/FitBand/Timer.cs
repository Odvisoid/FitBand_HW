class Timing
    {
        public void StartTimer()
        {
            int sec, min;
            Console.WriteLine("Сколько секунд");
            sec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько минут");
            min = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < sec + min * 60 + 1; i++)
            {
                Thread.Sleep(1000);
                Console.Write(Convert.ToInt32(i / 60));
                Console.Write(" : ");
                Console.Write(i - Convert.ToInt32(i / 60) * 60);
                Console.WriteLine();
            }
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.WriteLine("Время вышло");
        }

    }