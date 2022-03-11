using System;
using System.Threading;
namespace UserSpace
{
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
            while (true)
            {
                if (day <= 7 & day >= 1)
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
}