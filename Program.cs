using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static float health;
        static float monsterhealth;
        static int monsterdamage;
        static int playerdamage;
        static int lives;
        static string WeaponSelection;
        static string Start;

        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");
            Console.WriteLine("------------");
            Console.WriteLine("");

            health = 100;
            monsterdamage = 10;
            lives = 3;
            Console.WriteLine("Are you ready to begin? " + "Type Yes to begin");
            Start = Console.ReadLine();
            if(Start == "Yes")
            {
                ShowHUD();
            }
            TakeDamage();
        }
        
        static void TakeDamage()
        {
            Console.WriteLine("You are about to take");
            Console.WriteLine(monsterdamage + " Damage");
            health = health - monsterdamage;
           
            while (health > 0)
            {
                ShowHUD();
                TakeDamage();
                if ( health > 0 && health <= 10)
                {
                    Console.WriteLine(health);
                    Console.WriteLine("Health Critcal!");
                }
                if (health > 10 && health <= 30)
                {
                    Console.WriteLine(health);
                    Console.WriteLine("Health low!");
                }
                if (health > 30 && health  <= 50)
                {
                    Console.WriteLine(health);
                    Console.WriteLine("Health okay");
                }
                if (health > 50 && health <= 75)
                { 
                    Console.WriteLine(health);
                    Console.WriteLine("Health good");
                }
                if (health > 75 && health < 100) ;
                {
                    Console.WriteLine(health);
                    Console.WriteLine("Health great");
                }
                if (health <= 0)
                {
                    health = 0;

                    Console.WriteLine("Health " + health);
                    Console.WriteLine("Player died");
                    Console.ReadKey();
                }
            }

            Console.ReadKey(true);
        }
        static void

        static void ShowHUD()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Health " + health);
            Console.WriteLine("Choose your weapon: ");
            Console.WriteLine("1.Pistol 2.Shotgun 3.Spreader 4.Laser 5.Sniper 6.??? 7. to heal 8. Shield");
            WeaponSelection = Console.ReadLine();
            Console.WriteLine("---------------------------------");
            if (WeaponSelection == "1")
            {
                pistol();
                Console.WriteLine("Pistol selected");
            }
            
            if (WeaponSelection == "2")
            {
                ShotGun();
                Console.WriteLine("Shotgun selected");
            }
            
            if (WeaponSelection == "3") 
            {
                Spreader();
                Console.WriteLine("Spreader selected");
            }
            
            if (WeaponSelection == "4")
            {
                Laser();
                Console.WriteLine("Laser selected");
            }
            
            if (WeaponSelection == "5")
            {
                Sniper();
                Console.WriteLine("Sniper selected");
            }
            
            if (WeaponSelection == "6")
            {
                BFG();
                Console.WriteLine("BFG SELECTED");
                Console.WriteLine("ELIMINATE YOUR FOES");
            }
            
            if (WeaponSelection == "7")
            {
                health = health + 10;
                Console.WriteLine("Health up! +10");
            }
            if (WeaponSelection == "8")
            {
                monsterdamage = monsterdamage / 2;
            }
        }
        
        static void pistol()
        {
            
            if (health > 0) 
            { 
                playerdamage = 10;
            }

        }
        
        static void ShotGun()
        {
            if (health > 10)
            {
                playerdamage = 20;
            }
            else if (health < 10)
            {
                playerdamage = 10;
            }
            
        }
        
        static void Spreader()
        {
            if (health > 20)
            {
                playerdamage = 40;
            }
            else  if (health < 20)
            {
                playerdamage = 20;
            }
           
        }
       
        static void Laser()
        {
            if (health > 30)
            {
                playerdamage = 80;
            }
            else if (health < 30)
            {
                playerdamage = 40;
            }
        }
        
        static void Sniper()
        {
            if (health > 40)
            {
                playerdamage = 100;
            }
            else if (health < 40)
            {
                playerdamage = 50;
            }
        }
        
        static void BFG()
        {
            if (health > 50)
            {
                playerdamage = 200;
            }
            else if (health < 50)
            {
                Console.WriteLine("Player health too low");
                Console.WriteLine("BFG unavailible");
                playerdamage = 0;
            }
        }

    }
}
