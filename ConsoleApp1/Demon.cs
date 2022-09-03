using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    //class demon merupakan child class
    // di class ini akan mendeklarasikan dan mengset basic attack dan skills demon
    internal class Demon : Character
    {
        public string name;
        public string[] SkillsName = { "1. Basic Attack","2. Fang Attack", "3. Cyclone Breath" };
        private int attPowerFang = 120;
        private int attPowerCyclone = 90;
        public Demon(int health, int attack, string name) : base(health, attack)
        {
            this.name = name;
        }
        public int fangAttack() => attPowerFang;
        public int cycloneBreath() => attPowerCyclone;
    }
}