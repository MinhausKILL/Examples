﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите имя пользователя: ");
        string username = Console.ReadLine();

        if (username.ToLower() == "маша")
        {
            Console.WriteLine("Ура, этоже МАША!");
        }
        else
        {
            Console.Write("Привет, ");
            Console.WriteLine(username);
        }
    }
}