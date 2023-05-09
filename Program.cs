using System;

delegate void MenuAction();

class Program
{
    static void Main()
    {
        MenuAction[] actions = { NewGame, LoadGame, Rules, About, Exit };
        int choice;
        do
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1 - Новая игра");
            Console.WriteLine("2 - Загрузить игру");
            Console.WriteLine("3 - Правила");
            Console.WriteLine("4 - Об авторе");
            Console.WriteLine("0 - Выход");
            Console.Write("Выберите пункт меню: ");
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 4)
            {
                Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                continue;
            }
            actions[choice]();
        } while (choice != 0);
    }

    static void NewGame()
    {
        Console.WriteLine("Новая игра.");
    }

    static void LoadGame()
    {
        Console.WriteLine("Загрузка игры.");
    }

    static void Rules()
    {
        Console.WriteLine("Правила игры.");
    }

    static void About()
    {
        Console.WriteLine("Об авторе.");
    }

    static void Exit()
    {
        Console.WriteLine("Выход из программы.");
    }
}