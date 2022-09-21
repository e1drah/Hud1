using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hud1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables int
            //Player stats
            int health;
            int score;
            int lives;
            int attackPower;
            int scoreMultipier;

            //Monster stars
            int monsterKillPoints;

            int monsterStongPower;
            int monsterStronghealth;

            int monsterWeakPower;
            int monsterWeakHealth;

            int monsterMediumPower;
            int monsterMediumHealth;

            int locationFoundPoints;
            int itemFoundPoints;

            //variables string
            string playerName;

            //initialization
            health = 100;
            score = 0;
            lives = 3;
            attackPower = 10;
            scoreMultipier = 1;
            
            locationFoundPoints = 50;
            monsterKillPoints = 100;
            itemFoundPoints = 75;

            monsterStongPower = 50;
            monsterWeakPower = 10;
            monsterMediumPower = 25;

            monsterWeakHealth = 25;
            monsterMediumHealth = 50;
            monsterStronghealth = 100;

            Console.WriteLine(" O");
            Console.WriteLine("/|7");
            Console.WriteLine(" /7");
            Console.WriteLine();
            Console.WriteLine("Enter their name");
            playerName = Console.ReadLine();
            Console.WriteLine(" Your name is " + playerName + ".");
            Console.WriteLine("Press ANY KEY to continue ");
            Console.ReadKey();
            Console.Clear();

            //Actual "game"
            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score);
            Console.WriteLine();
            Console.WriteLine(" O");
            Console.WriteLine("/|7");
            Console.WriteLine(" /7");
            Console.WriteLine();
            Console.WriteLine(playerName + "'s adventure begins!");
            Console.ReadKey(true);
            Console.Clear();

            // player finds a abandoned house
            score += 50;
            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: ");
            Console.WriteLine();
            Console.WriteLine("    " +   "  ____");
            Console.WriteLine(" O  " +  @" /____\");
            Console.WriteLine("/|7 " +   " | __ |");
            Console.WriteLine(" /7 " +   " |_||_| ");
            Console.WriteLine();
            Console.WriteLine(playerName + " has found an abandoned house");
            Console.ReadKey(true);
            Console.Clear();

            // player finds a monster
            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: " + attackPower);
            Console.WriteLine("Monster Health: " + monsterWeakHealth + " Attack Power: " + monsterWeakPower);
            Console.WriteLine();
            Console.WriteLine("    " +  " {}");
            Console.WriteLine(" O  " + @"/()\");
            Console.WriteLine("/|7 " +  " []");
            Console.WriteLine(" /7 " +  " ||");
            Console.WriteLine();
            Console.WriteLine(playerName + " has found a WEAK Monster!!");
            Console.ReadKey(true);

        }
    }
}
