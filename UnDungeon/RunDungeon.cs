using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnDungeonLibrary;

namespace UnDungeon
{
    class RunDungeon
    {
        static void Main(string[] args)
        {
            Console.Title = "";
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Welcome, {0}. Your journey begins...", name);

            int killCount = 0;

            Weapon sc2 = new Weapon("Shining Scimitar", 2, 9, +15, false);
            Weapon ss = new Weapon("SHORTSWORD", 1, 4, 0, false);
            Weapon ba = new Weapon("BATTLEAXE", 1, 5, 0, false);
            Weapon sc = new Weapon("SCIMITAR", 1, 6, +5, false);
            Weapon ls = new Weapon("LONGSWORD", 1, 5, +3, false);
            Weapon ga = new Weapon("GREATAXE", 1, 6, +5, true);
            Weapon gs = new Weapon("GREATSWORD", 2, 8, +5, true);
            Weapon ss2 = new Weapon("SHINING SHORTSWORD", 2, 7, +10, false);
            Weapon ba2 = new Weapon("SHINING BATTLEAXE", 2, 8, +10, false);
            Weapon ls2 = new Weapon("SHINING LONGSWORD", 2, 8, +10, false);
            Weapon ga2 = new Weapon("SHINING GREATAXE", 2, 9, +10, true);
            Weapon gs2 = new Weapon("SHINING GREATSWORD", 3, 12, +10, true);
            Weapon[] weapons = { ss, ss, ss, ba, ba, ba, sc, sc, sc, ls, ls, ls, ga, ga, ga, gs, gs, gs, ss2, ba2, sc2, ls2, ga2, gs2 };
            Weapon weapon = weapons[new Random().Next(weapons.Length)];
            Player player = new Player(name, 60, 5, 40, 40, Race.Human, weapon);

            Console.WriteLine("You open the front door and enter the ruin of an ancient fortress. There is a strange feeling that you are not alone.");

            bool exit = false;

            do
            {
                Monster m1 = new Monster("GOOMBA", 30, 5, 8, 8, 1, 4, "It's a mushroom. Just stomp on its head.");
                Monster m2 = new BigMonster("DRAGON HATCHLING", 40, 10, 12, 12, 1, 6, "This very young dragon may be small, but it makes up for its lack of size with its ferocity.", false);
                Monster m3 = new BigMonster("DRAGON HATCHLING", 40, 10, 12, 12, 1, 6, "This very young dragon may be small, but it makes up for its lack of size with its ferocity.", true);
                Monster m4 = new BigMonster("WYRM", 65, 20, 30, 30, 2, 10, "This ancient dragon is slowing in its old age but makes up for its age with bulk and brutality.", false);
                Monster m5 = new BigMonster("WYRM", 65, 20, 30, 30, 2, 10, "This ancient dragon is slowing in its old age but makes up for its age with bulk and brutality.", true);

                Monster[] monsters = { m1, m1, m1, m1, m1, m1, m2, m2, m3, m3, m4, m5 };
                Monster monster = monsters[new Random().Next(monsters.Length)];

                Console.WriteLine(Area.AreaDescription() + "\nYou see a " + monster.Name + " in this area!");

                bool reloadRoom = false;

                do
                {
                    Console.WriteLine("\nChoose an action:\n" +
                        "A)ttack\n" +
                        "R)UN AWAY!\n" +
                        "H)ero Stats\n" +
                        "M)onster Stats\n" +
                        "(Esc to exit game)");
                    ConsoleKey userChoice = Console.ReadKey().Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Combat.DoBattle(player, monster);
                            if (monster.Life < 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You beat the {0}!" + "\nEnemies defeated: {1}",
                                    monster.Name,
                                    killCount);
                                Console.ResetColor();
                                reloadRoom = true;
                                killCount++;
                            }
                            break;

                        case ConsoleKey.R:
                            Console.WriteLine("The " + monster.Name + " attacks you as you retreat!");
                            Combat.DoAttack(monster, player);
                            reloadRoom = true;
                            break;

                        case ConsoleKey.H:
                            Console.WriteLine(player + "\nEnemies defeated: " + killCount);
                            break;

                        case ConsoleKey.M:
                            Console.WriteLine(monster);
                            break;

                        case ConsoleKey.Escape:
                            Console.WriteLine("You have chosen to let fear win. Good bye.");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("");
                            break;
                    }
                    if (player.Life < 1)
                    {
                        Console.WriteLine("You were killed by the " + monster.Name + "! Better luck next time.");
                        exit = true;
                    }


                } while (reloadRoom == false && exit == false);

            } while (!exit);
            Console.WriteLine("You defeated {0} monster{1}. \n\nGAME OVER",
                killCount,
                killCount == 1 ? "" : "s");
        }
    }
}
