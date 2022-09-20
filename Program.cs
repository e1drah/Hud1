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
            int health;
            int score;
            int lives;
            int attackPower;
            int monsterKillPoints;
            int locationFoundPoints;
            int itemFoundPoints;
            int monsterStongPower;
            int monsterWeakPower;
            int monsterMPower;
            //variables string
            string playerName;
            //initialization
            health = 100;
            score = 0;
            lives = 3;
            attackPower = 10;
            monsterKillPoints = 100;
            locationFoundPoints = 50;
            monsterStongPower = 50;
            monsterWeakPower = 10;
            monsterMPower = 25;
            Console.WriteLine(" O");
            Console.WriteLine("/|7");
            Console.WriteLine(" /7");
            Console.WriteLine();
            Console.WriteLine("Enter name");
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
            Console.WriteLine(playerName + " 's adventure begins!");
            Console.ReadKey(true);
            Console.Clear();
            // player finds a abandoned house
            score += 50;
            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: ");
            Console.WriteLine();
            Console.WriteLine(" O" +  "MMMM  ");
            Console.WriteLine("/|7" + "|  | ");
            Console.WriteLine(" /7" + "|[]|");
            Console.WriteLine();
            Console.WriteLine(playerName + " has found an abandoned house");
            
        }
    }
}
