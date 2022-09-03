using ConsoleApp1;
using System;

namespace ConsoleApp1
{
    class Game2D 
    { 
        public static void Main()
        {
            string h1 = @"


     ██▓ ██▓                                                     ██▓ ██▓       
    ▓██▒▓██▒                                                    ▓██▒▓██▒
    ▒██▒▒██▒    ╦ ╦┬ ┬┌┐┌┌┬┐┌─┐┬─┐  ┬  ┬┌─┐  ╔╦╗┌─┐┌┬┐┌─┐┌┐┌    ▒██▒▒██▒
    ░██░░██░    ╠═╣│ ││││ │ ├┤ ├┬┘  └┐┌┘└─┐   ║║├┤ ││││ ││││    ░██░░██░
    ░██░░██░    ╩ ╩└─┘┘└┘ ┴ └─┘┴└─   └┘ └─┘  ═╩╝└─┘┴ ┴└─┘┘└┘    ░██░░██░
    ░▓  ░▓                                                      ▓  ░▓  
     ▒ ░ ▒ ░                                                     ▒ ░ ▒ ░    
     ▒ ░ ▒ ░                                                     ▒ ░ ▒ ░
     ░   ░                                                       ░   ░  

Welcome to the Hunter vs Demon Game
(Use the arrow to cycle through option and press enter to select an option)
";          //Mendeklarasikan option pada tampilan awal game
            string[] options= { "Play Game", "About Us", "Exit" };
            Option HomeOption = new Option(h1, options);
            int getOption = HomeOption.start();

            switch (getOption)
            {
                case 0:
                    SettingCharacter();
                    break;
                case 1:
                    AboutUs();
                    break;
                case 2:
                    Exit();
                    break;
            }
        }

        //Fungsi ini bertujuan untuk Menampilkan option setelah user meng-click tombol enter
        private static void SettingCharacter()
        {
            string HeaderSetting = "Choose your configuration Character";
            string[] options = { "1.Default Character", "2.Custom Character" };
            Option ConfigurationOption = new Option(HeaderSetting, options);
            int getOption = ConfigurationOption.start();

            switch (getOption)
            {
                case 0:
                    Console.Clear();
                    ConfigurationCharacter.DefaultCharacter(); //Bermain dengan karakter default
                    break;
                case 1:
                    Console.Clear();
                    ConfigurationCharacter.CustomCharacter(); //Bermain dengan karakter yang bisa di custom nama, jumlah HP, dan power dari basic attack
                    break;
            }
        }

        //Fungsi untuk menampilkan text mengenai about us
        private static void AboutUs()
        {
            Console.Clear();
            Console.WriteLine("This Game is created by DFQ");
            Console.WriteLine("If yo want to know about us, follow on : ");
            Console.WriteLine("@ComuniyDF");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
            Environment.Exit(0);
        }

        //Fungsi untuk keluar dari program
        private static void Exit() {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
    }
}

