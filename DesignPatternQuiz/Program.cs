using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternQuiz
{
    class Program
    {
        public static void FullFight()
        {
            Hero SpiderMan = new Hero(new Weapon("Web Shooter", 25));
            Monster GreenGoblin = new smallMonster();
            void fight()
            {
                Console.WriteLine("You're about to get into a fight");
                Console.ReadLine();
               

                while (GreenGoblin.Health > 0 || SpiderMan.Health > 0)
                {
                    SpiderMan.Fight(GreenGoblin);
                    Console.WriteLine(GreenGoblin.Name + " has " + GreenGoblin.Health + " left");
                    Console.ReadLine();
                    GreenGoblin.Fight(SpiderMan);
                    Console.WriteLine(SpiderMan.Name + " has " + SpiderMan.Health + " left");
                    Console.ReadLine();
                }

            }
            fight();
            
            Console.WriteLine(SpiderMan.Name + " Won!");
            Console.WriteLine("Would you like to change your weapon?");
            var YesOrNo = Console.ReadLine().ToUpper();
            if(YesOrNo == "YES")
            {
                SpiderMan = new Hero(new Weapon("BALLISTIC WEB SHOOTER", 50));
            }
            else
            {
                Console.WriteLine("You suck!");
            }

            fight();

        }

        public static void BuyTicket()
        {
            Console.WriteLine("For which month would you like to use train?");
            var result = Console.ReadLine().ToUpper();
            if(result == "DECEMBER")
            {
                decemberTicket DecemberTicket = new decemberTicket();
                DecemberTicket.Buy();
            }
            else if(result == "JULY" || result == "JUNE")
            {
                JuneOrJulyTicket juneOrJulyTicket = new JuneOrJulyTicket();
                juneOrJulyTicket.Buy();
            }
            else if(result != "JULY" || result != "DECEMBER" || result != "JUNE")
            {
                OtherMonthTicket otherTickets = new OtherMonthTicket();
                otherTickets.Buy();
            }
            
        }
        static void Main(string[] args)
        {
            //FullFight();
            BuyTicket();
            
        }
    }
}
