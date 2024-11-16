using System;

namespace TextQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствуем тебя, искатель приключений!");
            Console.WriteLine("Перед тобой непростой путь, полный опасностей и загадок.");
            Console.WriteLine("Сможешь ли ты преодолеть все препятствия и достичь своей цели?");
            System.Threading.Thread.Sleep(2000); // Пауза в 2 секунды

            Console.WriteLine("\nВы просыпаетесь в темной комнате. Как вы будете действовать?");
            Console.WriteLine("1. Осмотреться.");
            Console.WriteLine("2. Выйти из комнаты.");
            Console.Write("Введите номер действия: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                InspectRoom();
            }
            else if (choice == "2")
            {
                ExitRoom();
            }
            else
            {
                Console.WriteLine("Неверный выбор, попробуйте еще раз.");
            }
        }

        static void InspectRoom()
        {
            Console.WriteLine("Вы осматриваетесь и находите старый ключ.");
            Console.WriteLine("Теперь вы можете:\n1. Взять ключ.\n2. Выйти из комнаты.");
            Console.Write("Введите номер действия: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Вы взяли ключ. Он может пригодиться вам позже.");
                // Здесь можно добавить логику с использованием ключа.
            }
            else if (choice == "2")
            {
                ExitRoom();
            }
            else
            {
                Console.WriteLine("Неверный выбор, попробуйте еще раз.");
                InspectRoom();
            }
        }

        static void ExitRoom()
        {
            Console.WriteLine("Вы выходите из комнаты и попадаете в длинный коридор.");
            Console.WriteLine("На вашем пути есть две двери.");
            Console.WriteLine("1. Дверь слева.\n2. Дверь справа.");
            Console.Write("Введите номер действия: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Вы входите в комнату с сокровищами! Вы победили!");
                // Можно добавить дополнительную логику, например, возможность забрать сокровища.
            }
            else if (choice == "2")
            {
                Console.WriteLine("Вы входите в комнату с монстрами и проигрываете!");
                // Можно добавить возможность начать игру заново.
            }
            else
            {
                Console.WriteLine("Неверный выбор, попробуйте еще раз.");
                ExitRoom();
            }
        }
    }
}