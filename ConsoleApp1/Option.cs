using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Option
    {
        private string gameScreen;
        private string[] options;
        private int selectOption;

        public Option (string gameScreen, string[] options)
        {
            this.gameScreen = gameScreen;
            this.options = options;
            selectOption = 0;
        }

        //fungsi untuk mengenerate option
        private void optionGenerator()
        {
            Console.WriteLine(gameScreen);
            for(int i= 0; i < options.Length; i++)
            {
                string optionNow = options[i];
                string sign;
                if (i == selectOption)
                {
                    sign = "►";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    sign = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine($"{sign} {optionNow}");
            }
            Console.ResetColor();
        }

        //fungsi untuk membuat option interface bisa berinteraksi dengan user menggunakan tombol up and down
        public int start()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                optionGenerator();
                ConsoleKeyInfo keyinfo = Console.ReadKey(true);
                keyPressed = keyinfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    selectOption--;
                    if(selectOption == -1)
                    {
                        selectOption = options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    selectOption++;
                    if (selectOption == options.Length) 
                    {
                        selectOption = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);

            return selectOption;
        }

        //fungsi yang hampir sama dengan yang diatas, tapi fungsi ini dipanggil ketika game dimulai
        //tujuannya untuk men-generate HP dan mengupdate tampilan HP
        public int PlayTheGameNow()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                BattleGround.generateHP();
                optionGenerator();
                ConsoleKeyInfo keyinfo = Console.ReadKey(true);
                keyPressed = keyinfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    selectOption--;
                    if (selectOption == -1)
                    {
                        selectOption = options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    selectOption++;
                    if (selectOption == options.Length)
                    {
                        selectOption = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);

            return selectOption;
        }

        //fungsi ini digunakan ketika HP salah satu character 0, tujuannya untuk menampilkan bar hp menjadi kosong dan mengakhiri game
        public void EndBattle()
        {
            Console.Clear();
            BattleGround.generateHP();
            optionGenerator();
        }


    }
}
