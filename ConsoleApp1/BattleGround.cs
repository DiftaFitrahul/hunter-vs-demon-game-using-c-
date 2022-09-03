using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Class ini merupakan class untuk melakukan pertarungan
    //kalkulasi pertarungan di definisikan di class ini
    static internal class BattleGround
    {
        private static int demonHealth;
        private static int hunterHealth;
        private static int setHPhunter;
        private static int setHPdemon;
        private static string hunterName;
        private static string demonName;
        public static void playGame(Hunter hunter, Demon demon)
        {
            hunterName = hunter.name;
            demonName = demon.name;
            demonHealth = demon.Health;
            hunterHealth = hunter.Health;
            setHPhunter = hunterHealth / 50; //bertujuan agar bar HP yang ditampilkan sama berapapun inputan jumlah HP
            setHPdemon = demonHealth / 50;   //bertujuan agar bar HP yang ditampilkan sama berapapun inputan jumlah HP
            
            do
            {
                Console.Clear();
                HunterAttack(hunter);
                if (demonHealth <= 0) break; //bertujuan agar demon tidak dijalankan ketika HP demon sudah habis
                DemonAttack(demon);
            } while (demonHealth > 0 && hunterHealth > 0);

            EndGame(hunter, demon);
        }

        //fungsi untuk men-display bar HP
        public static void generateHP()
        {
            Console.Write("[");
            if(hunterHealth > 0)
            {
                for (int i = 0; i < (hunterHealth / setHPhunter); i++)
                {
                    Console.Write("I");
                }
                for (int i = (hunterHealth / setHPhunter); i < 50; i++)
                {
                    Console.Write(" ");
                }
            } else if(hunterHealth <= 0)
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.Write(" ");
                }
            }
            Console.Write($"]   {hunterName} Health [Hunter]\n");

            Console.Write("[");
            if(demonHealth > 0)
            {
                for (int i = 0; i < (demonHealth / setHPdemon); i++)
                {
                    Console.Write("I");
                }
                for (int i = (demonHealth / setHPdemon); i < 50; i++)
                {
                    Console.Write(" ");
                }
            } else if(demonHealth <= 0)
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.Write(" ");
                }
            }          
            Console.Write($"]   {demonName} Health [Demon]\n");
        }

        //fungsi untuk menampilkan option skiil dari hunter ketika akan menyerang, dan juga untuk melakukan kalkulasi 
        private static void HunterAttack(Hunter hunter)
        {
            Option HunterAttack = new Option("\nIt's time for Hunter to attack : ", hunter.SkillsName);
            int selectSkills = HunterAttack.PlayTheGameNow();

            switch (selectSkills)
            {
                case 0:
                    demonHealth -= hunter.Attack;
                    break;
                case 1:
                    demonHealth -= hunter.MeteorExcalibur();
                    break;
                case 2: 
                    demonHealth -= hunter.ThunderWave();
                    break;
            }
        }

        //fungsi untuk menampilkan option skiil dari demon ketika akan menyerang, dan juga untuk melakukan kalkulasi
        private static void DemonAttack(Demon demon)
        {
            Option DemonAttack = new Option("\nIt's time for Demon to attack : ", demon.SkillsName);
            int selectSkills = DemonAttack.PlayTheGameNow();

            switch (selectSkills)
            {
                case 0:
                    hunterHealth -= demon.Attack;
                    break;
                case 1:
                    hunterHealth -= demon.fangAttack();
                    break;
                case 2:
                    hunterHealth -= demon.cycloneBreath();
                    break;
            }
        }

        //fugsi untuk mengakhiri game
        private static void EndGame(Hunter hunter, Demon demon)
        {
            if (demonHealth <= 0)
            {
                Option endGame = new Option("\nIt's time for Hunter to attack : ", hunter.SkillsName);
                endGame.EndBattle();
                Console.WriteLine(@"
        ╦ ╦┬ ┬┌┐┌┌┬┐┌─┐┬─┐  ╦ ╦┬┌┐┌┌─┐
        ╠═╣│ ││││ │ ├┤ ├┬┘  ║║║││││└─┐
        ╩ ╩└─┘┘└┘ ┴ └─┘┴└─  ╚╩╝┴┘└┘└─┘
");

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(true);
                Environment.Exit(0);
            }
            else if (hunterHealth <= 0)
            {
                Option endGame = new Option("\nIt's time for Demon to attack : ", demon.SkillsName);
                endGame.EndBattle();
                Console.WriteLine(@"
        ╔╦╗┌─┐┌┬┐┌─┐┌┐┌  ╦ ╦┬┌┐┌┌─┐
         ║║├┤ ││││ ││││  ║║║││││└─┐
        ═╩╝└─┘┴ ┴└─┘┘└┘  ╚╩╝┴┘└┘└─┘
                ");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(true);
                Environment.Exit(0);
            }
        }
    }
}
