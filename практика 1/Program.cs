using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задание 1");
            string str1 = "hello";
            string str2 = "world";
            string result = str1 + " " + str2;
            Console.WriteLine(result);

            Console.WriteLine("задание 2");
            int a = 10;
            int b = 5;

            Console.WriteLine("Сложение: " + (a + b));
            Console.WriteLine("Вычитание: " + (a - b));
            Console.WriteLine("Умножение: " + (a * b));
            Console.WriteLine("Деление: " + (a / b));

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите имя:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите фамилию:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введите отчество:");
            string middleName = Console.ReadLine();

            string fullName = $"{lastName} {firstName} {middleName}";
            Console.WriteLine($"Полное имя: {fullName}");

            Console.WriteLine("Задание 4");
            int playerHealth = 100; // здоровье игрока
            int playerDamage = 20; // урон игрока
            int playerDefense = 10; // защита игрока

            int monsterHealth = 80; // здоровье монстра
            int monsterDamage = 15; // урон монстра
            int monsterDefense = 5; // защита монстра

            int playerDamageDealt = (int)Math.Round((double)monsterDamage / playerDefense * 100); // урон, нанесенный игроком
            int monsterDamageDealt = (int)Math.Round((double)playerDamage / monsterDefense * 100); // урон, нанесенный монстром

            playerHealth -= monsterDamageDealt; // уменьшаем здоровье игрока на урон, нанесенный монстром
            monsterHealth -= playerDamageDealt; // уменьшаем здоровье монстра на урон, нанесенный игроком

            Console.WriteLine("Здоровье игрока: " + playerHealth);
            Console.WriteLine("Здоровье монстра: " + monsterHealth);
            Console.WriteLine("Урон, нанесенный игроком: " + playerDamageDealt);
            Console.WriteLine("Урон, нанесенный монстром: " + monsterDamageDealt);



        }
    }
}
  
