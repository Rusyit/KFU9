using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            string[] name = new string[] { "Россия", "Франция", "Китай", "Казахстан" };
            for (int i = 0; i < 4; i++)
            {
                Team team = new Team(name[i]);
                teams.Add(team);
            }
            Console.WriteLine("\nНачитается первый этап из 3-х игр на убывание\n");
            Console.WriteLine("Результаты участников в игре в пляж\n");
            Beach beach = new Beach();
            foreach (Team team in teams)
            {
                ((IGame)beach).Game(team);
            }
            Console.WriteLine("\nРезультаты участников в игре в мышеловки\n");
            Mousetrap mousetrap = new Mousetrap();
            foreach (Team team in teams)
            {
                ((IGame)mousetrap).Game(team);
            }
            Console.WriteLine("\nРезультаты участников в игре в море\n");
            Sea sea = new Sea();
            foreach (Team team in teams)
            {
                ((IGame)sea).Game(team);
            }
            Console.WriteLine("\nРезультаты участников после первого этапа:\n"); 
            Total total = new Total();
            foreach (Team team in teams)
            {
                total.Totall(team);
            }
            total.Remove_Teams(teams);
            foreach (Team team in teams)
            {
                total.Update_Point(team);
            }
            Console.WriteLine("\nНачинает второй этап игр на убывание, очки участников обнуляются"); 
            Console.WriteLine("\nРезультаты участников в игре рыбалка\n"); 
            Fishing fishing = new Fishing();
            foreach (Team team in teams)
            {
                ((IGame)fishing).Game(team);
            }
            Console.WriteLine("\nРезультаты участников в игре почтальоны\n");
            Postmen postmen = new Postmen();
            foreach (Team team in teams)
            {
                ((IGame)postmen).Game(team);
            }
            Console.WriteLine("\nРезультаты участников в игре горки\n"); 
            Gorkp gorkp = new Gorkp();
            foreach (Team team in teams)
            {
                ((IGame)gorkp).Game(team);
            }
            Console.WriteLine("\nРезультаты участников после второго этапа:\n"); 
            foreach (Team team in teams)
            {
                total.Totall(team);
            }
            total.Remove_Teams(teams);
            foreach (Team team in teams)
            {
                total.Update_Point(team);
            }
            Console.WriteLine();
            Console.WriteLine("Начинает второй этап игр на убывание, очки участников обнуляются");
            Console.WriteLine("\nРезултаты участников в игре хоккей");
            Console.WriteLine();
            Hockey hockey = new Hockey();
            foreach (Team team in teams)
            {
                ((IGame)hockey).Game(team);
            }
            Console.WriteLine();
            Console.WriteLine("В финале остались 2 команды: ");
            Console.WriteLine();
            foreach (Team team in teams)
            {
                total.Totall(team);
            }
            Console.WriteLine();
            total.Remove_Teams(teams);
            foreach (Team team in teams)
            {
                total.Update_Point(team);
            }
            Console.WriteLine();
            foreach (Team team in teams)
            {
                total.Winner(team);
            }
        }
    }
}
