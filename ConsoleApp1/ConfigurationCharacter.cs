using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static internal class ConfigurationCharacter
    {
        //fungsi untuk mengatur default character
        public static void DefaultCharacter()
        {
            Hunter hunter1 = new Hunter(700, 70, "Mihawk");
            Demon demon1 = new Demon(1000, 55, "Lucifier");
            BattleGround.playGame(hunter1, demon1);
        }

        //fungsi untuk mengatur custom character
        public static void CustomCharacter()
        {
            string HunterName, DemonName;
            int HealthHunter, AttackHunter, HealthDemon, AttackDemon;
            Console.WriteLine("## Custom Hunter ##");
            Console.WriteLine("Input name of the Hunter : ");
            HunterName = Console.ReadLine();
            Console.WriteLine("Input the number of HealthPoint :");
            HealthHunter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the power of Basic Attack : ");
            AttackHunter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n## Custom Demon ##");
            Console.WriteLine("Input name of the Demon : ");
            DemonName = Console.ReadLine();
            Console.WriteLine("Input the number of HealthPoint :");
            HealthDemon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the power of Basic Attack : ");
            AttackDemon = Convert.ToInt32(Console.ReadLine());

            Hunter hunter = new Hunter(HealthHunter, AttackHunter, HunterName);
            Demon demon = new Demon(HealthDemon, AttackDemon, DemonName);
            BattleGround.playGame(hunter, demon);
        }


    }
}
