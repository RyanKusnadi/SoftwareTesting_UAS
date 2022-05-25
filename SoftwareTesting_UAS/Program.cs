using System;
using System.Collections.Generic;

namespace SoftwareTesting_UAS
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //instansiasi agent bernama player, attack pointnya 300
            Agent player = new Agent("Player", "Player1", 500, 500, 300);
            
            //instansiasi agent bernama enemy1, labelnya Boss, missing HPnya = 3500 (max-current)
            Agent Enemy1 = new Agent("Boss", "Turtle", 5000, 1500, 100);
            Agent Enemy2 = new Agent("Boss", "Lord", 45000, 5000, 100);

            int damage = player.Ability1(Enemy1); //400 + (60%*300) + (30%*3500) = 1580
            int damage2 = player.Ability1(Enemy2); //400 + (60%*300) + (30%*40000) = 12580, tp boss, jd max 2500
            Console.WriteLine(damage); //1580
            Console.WriteLine(damage2); //2500

        }
    }
}
