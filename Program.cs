using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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

        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");
            Console.WriteLine("------------");
            Console.WriteLine("");

            health = 100;
            monsterdamage = 10;
            lives = 3;
            TakeDamage();
        }
        
        static void TakeDamage()
        {
            Console.WriteLine("You are about to take");
            Console.WriteLine(monsterdamage + " Damage");
            health = health - monsterdamage;
            monsterdamage = monsterdamage * 2;
           
            while (health > 0)
            {
                ShowHUD();
                TakeDamage();
                if ( health >= 0 && health <= 10)
                {
                    Console.WriteLine(health);
                    Console.WriteLine("Health Crritcal!");
                }
                if (health > 10 && health <= 20)
                {

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
        
        static void ShowHUD()
        {
            Console.WriteLine("Health " + health);
            Console.WriteLine("Choose your weapon: ");
            Console.WriteLine("1.Pistol 2.Shotgun 3.Spreader 4.Laser 5.Sniper 6.??? or 7. to heal");
            WeaponSelection = Console.ReadLine();
           
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
