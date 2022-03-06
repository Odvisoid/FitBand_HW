
using System.Threading;
namespace MyProg
{
    public class StepExtension
    {
        public int DistanceToSteps(double distance, int height)
        {
            return Convert.ToInt32(distance / (height * 0.45 / 100000));
        }
        public double StepsToDistance(int steps, int height)
        {
            return Math.Round(steps * height * 0.45 / 100000, 1);
        }
    }
    abstract class ForFuncShow
    {
        public abstract void Show();
    }
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
            if (day == 1 &ClearingNumber == 0)
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
    class TimeShower : ForFuncShow
    {
        public DateTime date = new DateTime();
        public TimeShower()
        {
            date = DateTime.Now;
        }
        public override void Show()
        {
            Console.WriteLine(date);
        }
    }
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
    class User
    {
        public string name, fam, search;
        public int height, weight;
        Stepcounter UserStepcounter = new Stepcounter();
        TimeShower UserTimeShower = new TimeShower();
        Timing UserTiming = new Timing();
        public User()
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            fam = Console.ReadLine();
            Console.WriteLine("Введите рост(в см)");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вес(в кг)");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Данные удачно записаны");
        }

        public void Interact()
        {
            Console.Write("Добрый день, ");
            Console.WriteLine(name);
            int day;
            Console.WriteLine("Какой сегодня день недели?(по номеру)");
            day = Convert.ToInt32(Console.ReadLine());
            while (true) {
                if(day <= 7 & day >= 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Такого дня нет. Введите день недели(по номеру) еще раз");
                    day = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("С чего желаете начать?");
            while (true)
            {
                search = Console.ReadLine();
                if (search != "Завершение работы")
                {
                    if (search == "Подсчитать шаги")
                    {
                        while (search != "Ничего из перечисленного")
                        {
                            Console.WriteLine("Хотите узнать статистику, записать шаги, записать результаты пробежки или узнать историю пробежек?");
                            search = Console.ReadLine();
                            if (search == "Узнать статистику")
                            {
                                UserStepcounter.Show();
                            }
                            else if (search == "Записать шаги")
                            {
                                int steps;
                                Console.WriteLine("Сколько сделал шагов?");
                                steps = Convert.ToInt32(Console.ReadLine());
                                UserStepcounter.CountStepsAtEnd(day, steps, height);
                            }
                            else if (search == "Записать результаты пробежки")
                            {
                                double distance;
                                int time;
                                Console.WriteLine("Сколько пробежали? (в км)");
                                distance = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Сколько потратили времени? (в часах)");
                                time = Convert.ToInt32(Console.ReadLine());
                                UserStepcounter.CountRunning(day, distance, time, height);
                            }
                            else if (search == "Узнать историю пробежек")
                            {
                                UserStepcounter.ShowHistory();
                            }
                        }
                    }
                    else if (search == "Узнать время")
                    {
                        UserTimeShower.Show();
                    }
                    else if (search == "Таймер")
                    {
                        UserTiming.StartTimer();
                    }
                    else
                    {
                        Console.WriteLine("Команда не опознана");
                    }
                }
                else
                {
                    break;
                }
                Console.WriteLine("Что желаете сделать?");
            }
        }

    }
    class Program
    {
        static void Main()
        {
            User user = new User();
            user.Interact();
        }
    }
}

