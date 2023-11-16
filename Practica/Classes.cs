using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Beach : IGame
    {
        Random random = new Random();
        void IGame.Game(Team teams)
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                count += random.Next(0, 5);
            }
            teams.point += count;
            Console.WriteLine($"Команда {teams.name} набрала {count} очков");
        }
    }

    internal class Mousetrap : IGame
    {
        Random random = new Random();
        void IGame.Game(Team teams)
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                count += random.Next(0, 5);
            }
            teams.point += count;
            Console.WriteLine($"Команда {teams.name} набрала {count} очков");
        }
    }

    internal class Sea : IGame
    {
        Random random = new Random();
        void IGame.Game(Team teams)
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                count += random.Next(0, 5);
            }
            teams.point += count;
            Console.WriteLine($"Команда {teams.name} набрала {count} очков");
        }
    }

    internal class Fishing : IGame
    {
        Random random = new Random();
        void IGame.Game(Team teams)
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                count += random.Next(0, 5);
            }
            teams.point += count;
            Console.WriteLine($"Команда {teams.name} набрала {count} очков");
        }
    }

    internal class Postmen : IGame
    {
        Random random = new Random();
        void IGame.Game(Team teams)
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                count += random.Next(0, 5);
            }
            teams.point += count;
            Console.WriteLine($"Команда {teams.name} набрала {count} очков");
        }
    }

    internal class Gorkp : IGame
    {
        Random random = new Random();
        void IGame.Game(Team teams)
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                count += random.Next(0, 5);
            }
            teams.point += count;
            Console.WriteLine($"Команда {teams.name} набрала {count} очков");
        }
    }

    internal class Hockey : IGame
    {
        Random random = new Random(); 
        void IGame.Game(Team teams)
        {
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                count += random.Next(0, 2);
            }
            teams.point += count;
            Console.WriteLine($"Команда {teams.name} забила {count} гол(ов)");
        }
    }

    internal class Team
    {
        internal string name { get; set; }
        internal int point { get; set; }
        public Team(string name) { this.name = name; }
    }

    internal class Total
    {
        public void Totall(Team teams)
        {
            Console.WriteLine($"Команда {teams.name} набрала в сумме {teams.point} очков");
        }
        public void Remove_Teams(List<Team> teams)
        {
            int minScore_1 = teams.Min(p => p.point);
            int minScore_2 = teams.IndexOf(teams.First(team => team.point == minScore_1));
            Console.WriteLine($"Одна из команд покидает игру");
            teams.RemoveAt(minScore_2);
        }
        public void Update_Point(Team teams)
        {
            teams.point = 0;
        }
        public void Winner(Team teams)
        {
            Console.WriteLine($"Команда {teams.name} победила");
        }
    }
}
