using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Игра в кости
            //Компьюьер (cpu) и пользователь (user) играют в кости 
            //Компьютер "бросает кубик" и пользователь "бросает кубик" (за пользователя тоже играет класс рандом)
            //Значения, которые могут выпасть находятся в диапазоне от 1-6 (включительно)
            //Кто выбросил больший результат, тот и победил в игре
            //бросок выполняется один раз
            //исправленный до рабочего состояния код дает до 10 пунктов 

            //комментарии к переменным: userThrow - бросок пользователем; cpuScore - бросок компьютера;

            
            Random rnd = new Random();

            int userThrow = rnd.Next(1, 7);
            int cpuScore = rnd.Next(1, 7);

            Console.WriteLine("GAME OF DICE");
            Console.WriteLine("User vs Computer");
            Console.WriteLine(" ");

            Console.WriteLine($"Бросок пользователя: выпало {userThrow}");
            Console.WriteLine($"Бросок компьютера: выпало {cpuScore}");
            Console.WriteLine(" ");

            if (userThrow > cpuScore)
            {
                Console.WriteLine("РЕЗУЛЬТАТ - Победил пользователь");
            }
            
            else if(userThrow < cpuScore)
            {
                Console.WriteLine("РЕЗУЛЬТАТ - Победил компьютер");
            }

            else
            {
                Console.WriteLine("РЕЗУЛЬТАТ - Ничья");
            }

        }
    }
}
