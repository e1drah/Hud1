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

            //Naming the guy

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" O");
            Console.WriteLine("/|7");
            Console.WriteLine(" /7");
            Console.WriteLine();
            Console.WriteLine("Enter their name");
            playerName = Console.ReadLine();
            Console.WriteLine("Their name is " + playerName + "!");
            Console.WriteLine("Press ANY KEY to continue ");
            Console.ReadKey();
            Console.Clear();

            //Actual "game"

            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: " + attackPower + " Score Multiplier: " + scoreMultipier);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" O");
            Console.WriteLine("/|7");
            Console.WriteLine(" /7");
            Console.WriteLine();
            Console.WriteLine(playerName + "'s adventure begins!");
            Console.ReadKey(true);
            Console.Clear();

            // player finds a abandoned house

            score += (locationFoundPoints * scoreMultipier);

            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: " + attackPower + " Score Multiplier: " + scoreMultipier);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    " +   "  ____");
            Console.WriteLine(" O  " +  @" /____\");
            Console.WriteLine("/|7 " +   " | __ |");
            Console.WriteLine(" /7 " +   " |_||_| ");
            Console.WriteLine();
            Console.WriteLine(playerName + " has found an abandoned house");
            Console.WriteLine(playerName + " gains " + (locationFoundPoints * scoreMultipier) + " Points!!");
            Console.ReadKey(true);
            Console.Clear();

            // player finds a monster

            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: " + attackPower + " Score Multiplier: " + scoreMultipier);
            Console.WriteLine("Monster Health: " + monsterWeakHealth + " Attack Power: " + monsterWeakPower);
            Console.WriteLine();
            Console.WriteLine("    " +  " {}");
            Console.WriteLine(" O  " + @"/()\");
            Console.WriteLine("/|7 " +  " []");
            Console.WriteLine(" /7 " +  " ||");
            Console.WriteLine();
            Console.WriteLine(playerName + " has found a WEAK Monster!!");
            Console.ReadKey(true);
            Console.Clear();

            //player attacks the monster

            monsterWeakHealth -= attackPower;
            health -= monsterWeakPower;

            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: " + attackPower + " Score Multiplier: " + scoreMultipier);
            Console.WriteLine("Monster Health: " + monsterWeakHealth + " Attack Power: " + monsterWeakPower);
            Console.WriteLine();
            Console.WriteLine("    " +  " {}");
            Console.WriteLine(" O  " + @"/()\");
            Console.WriteLine("/|7 " +  " []");
            Console.WriteLine(" /7 " +  " ||");
            Console.WriteLine();
            Console.WriteLine(playerName + " attacks the WEAK Monster!!");
            Console.WriteLine("The WEAK Monster atacks "+ playerName+"!!");
            Console.ReadKey(true);
            Console.Clear();

            //player attacks the monster again!!

            monsterWeakHealth -= attackPower;
            health -= monsterWeakPower;

            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: " + attackPower + " Score Multiplier: " + scoreMultipier);
            Console.WriteLine("Monster Health: " + monsterWeakHealth + " Attack Power: " + monsterWeakPower);
            Console.WriteLine();
            Console.WriteLine("    " + " {}");
            Console.WriteLine(" O  " + @"/()\");
            Console.WriteLine("/|7 " + " []");
            Console.WriteLine(" /7 " + " ||");
            Console.WriteLine();
            Console.WriteLine(playerName + " attacks the WEAK Monster!!");
            Console.WriteLine("The WEAK Monster atacks " + playerName + "!!");
            Console.ReadKey(true);
            Console.Clear();

            //player defeats the monster!!

            monsterWeakHealth -= attackPower;
            scoreMultipier += 1;
            score += (monsterKillPoints * scoreMultipier);

            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: " + attackPower + " Score Multiplier: " + scoreMultipier);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    ");
            Console.WriteLine(" O  ");
            Console.WriteLine("/|7 ");
            Console.WriteLine(" /7 ");
            Console.WriteLine();
            Console.WriteLine(playerName + " defeats the WEAK Monster!!");
            Console.WriteLine(playerName + " continued into the house.");
            Console.WriteLine(playerName + " gains " + (monsterKillPoints * scoreMultipier) + " Points!!");
            Console.ReadKey(true);
            Console.Clear();

            //player finds a sword!!

            attackPower += 15;
            score += (itemFoundPoints * scoreMultipier);

            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: " + attackPower + " Score Multiplier: " + scoreMultipier);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    " + " ^");
            Console.WriteLine(" O  " + " |");
            Console.WriteLine("/|7 " + " |");
            Console.WriteLine(" /7 " + " T");
            Console.WriteLine();
            Console.WriteLine(playerName + " Finds a sword");
            Console.WriteLine(playerName + "'s attack power increases by 15.");
            Console.WriteLine(playerName + " gains " + (itemFoundPoints * scoreMultipier) + " Points!!");
            Console.ReadKey(true);
            Console.Clear();

            //Player tries to escape

            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: " + attackPower + " Score Multiplier: " + scoreMultipier);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    " + "");
            Console.WriteLine(" O  " + "");
            Console.WriteLine("/|7 " + "");
            Console.WriteLine(" /7 " + "");
            Console.WriteLine();
            Console.WriteLine(playerName + " decides to go home");
            Console.ReadKey(true);
            Console.Clear();

            //player is cornered by a STRONG Monster!!

            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: " + attackPower + " Score Multiplier: " + scoreMultipier);
            Console.WriteLine("Monster Health: " + monsterStronghealth + " Attack Power: " + monsterStongPower);
            Console.WriteLine();
            Console.WriteLine("    " +  "^ {_}");
            Console.WriteLine(" O  " + @"|/( )\");
            Console.WriteLine("/|7 " +  "| [_]");
            Console.WriteLine(" /7 " +  "| | |");
            Console.WriteLine();
            Console.WriteLine(playerName + " is cornered by a STRONG Monster!!");
            Console.ReadKey(true);
            Console.Clear();

            //The fight begins

            health -= monsterStongPower;
            monsterStronghealth -= attackPower;

            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: " + attackPower + " Score Multiplier: " + scoreMultipier);
            Console.WriteLine("Monster Health: " + monsterStronghealth + " Attack Power: " + monsterStongPower);
            Console.WriteLine();
            Console.WriteLine("    " +  "^ {_}");
            Console.WriteLine(" O  " + @"|/( )\");
            Console.WriteLine("/|7 " +  "| [_]");
            Console.WriteLine(" /7 " +  "| | |");
            Console.WriteLine();
            Console.WriteLine("The STRONG monster attacks " + playerName + "!!!");
            Console.WriteLine(playerName + " attacks the STRONG Monster");
            Console.ReadKey(true);
            Console.Clear();

            //Player dies

            health -= monsterStongPower;

            Console.WriteLine();
            Console.WriteLine("Monster Health: " + monsterStronghealth + " Attack Power: " + monsterStongPower);
            Console.WriteLine();
            Console.WriteLine("    " +  "^ {_}");
            Console.WriteLine("    " + @"|/( )\");
            Console.WriteLine("    " +  "| [_]");
            Console.WriteLine("    " +  "| | |");
            Console.WriteLine();
            Console.WriteLine("The STRONG monster attacks " + playerName + "!!!");
            Console.WriteLine(playerName + " falls to the ground");
            Console.ReadKey(true);
            Console.Clear();

            //Player gets back up 

            lives -= 1;
            health = 100;
            monsterStronghealth -= attackPower;

            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: " + attackPower + " Score Multiplier: " + scoreMultipier);
            Console.WriteLine("Monster Health: " + monsterStronghealth + " Attack Power: " + monsterStongPower);
            Console.WriteLine();
            Console.WriteLine("    " + "^ {_}");
            Console.WriteLine(" O  " + @"|/( )\");
            Console.WriteLine("/|7 " + "| [_]");
            Console.WriteLine(" /7 " + "| | |");
            Console.WriteLine();
            Console.WriteLine(playerName + " gets up surprising the STRONG Monster!!");
            Console.WriteLine(playerName + " attacks the STRONG Monster!!");
            Console.ReadKey(true);
            Console.Clear();

            //The fight continues

            health -= monsterStongPower;
            monsterStronghealth -= attackPower;

            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: " + attackPower + " Score Multiplier: " + scoreMultipier);
            Console.WriteLine("Monster Health: " + monsterStronghealth + " Attack Power: " + monsterStongPower);
            Console.WriteLine();
            Console.WriteLine("    " + "^ {_}");
            Console.WriteLine(" O  " + @"|/( )\");
            Console.WriteLine("/|7 " + "| [_]");
            Console.WriteLine(" /7 " + "| | |");
            Console.WriteLine();
            Console.WriteLine("The STRONG monster attacks " + playerName + "!!!");
            Console.WriteLine(playerName + " attacks the STRONG Monster");
            Console.ReadKey(true);
            Console.Clear();

            //they kill each other

            health -= monsterStongPower;
            monsterStronghealth -= attackPower;

            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: " + attackPower + " Score Multiplier: " + scoreMultipier);
            Console.WriteLine("Monster Health: " + monsterStronghealth + " Attack Power: " + monsterStongPower);
            Console.WriteLine();
            Console.WriteLine("    " + "^ {_}");
            Console.WriteLine(" O  " + @"|/( )\");
            Console.WriteLine("/|7 " + "| [_]");
            Console.WriteLine(" /7 " + "| | |");
            Console.WriteLine();
            Console.WriteLine("The STRONG monster attacks " + playerName + "!!!");
            Console.WriteLine(playerName + " attacks the STRONG Monster");
            Console.ReadKey(true);
            Console.Clear();

            //they are both dead

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Both " + playerName + " and the STRONG monster fall to the ground");
            Console.ReadKey(true);
            Console.Clear();

            //player gets back up

            health = 100;
            lives -= 1;
            scoreMultipier += 1;
            score += (monsterKillPoints * scoreMultipier);


            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: " + attackPower + " Score Multiplier: " + scoreMultipier);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    " + "");
            Console.WriteLine(" O  " + "");
            Console.WriteLine("/|7 " + "");
            Console.WriteLine(" /7 " + "");
            Console.WriteLine();
            Console.WriteLine(playerName + " get's up!!");
            Console.WriteLine(playerName + " gains " + (monsterKillPoints * scoreMultipier) + " Points!!");
            Console.ReadKey(true);
            Console.Clear();

            //Player runs home

            Console.WriteLine(playerName + ": Health: " + health + " Lives: " + lives + " score: " + score + " Attack Power: " + attackPower + " Score Multiplier: " + scoreMultipier);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine( "  ____  " + "");
            Console.WriteLine(@" /____\ " + "  O  ");
            Console.WriteLine( " | __ | " + " /|7 ");
            Console.WriteLine( " |_||_| " + "  /7 ");
            Console.WriteLine();
            Console.WriteLine(playerName + " runs home.");
            Console.ReadKey(true);
            Console.Clear();

            //the end

            Console.WriteLine("Final score: " + score);
            Console.WriteLine(@" _____ _   _  _____   _____ _   _______ ");
            Console.WriteLine(@"|_   _| | | ||  ___| |  ___| \ | |  _  \");
            Console.WriteLine(@"  | | | |_| || |__   | |__ |  \| | | | |");
            Console.WriteLine(@"  | | |  _  ||  __|  |  __|| . ` | | | |");
            Console.WriteLine(@"  | | | | | || |___  | |___| |\  | |/ / ");
            Console.WriteLine(@"  \_/ \_| |_/\____/  \____/\_| \_/___/  ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadKey(true);
            Console.Clear();

        }
    }
}
