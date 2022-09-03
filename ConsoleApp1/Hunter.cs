using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //class hunter merupakan child class
    // di class ini akan mendeklarasikan dan mengset basic attack dan skills hunter
    internal class Hunter : Character
    {
        public string name;
        public string[] SkillsName = { "1. Basic Attack", "2. Meteor Excalibur", "3. Thunder Wave" };
        private int attkPowerMeteor = 100;
        private int attkPowerThunder = 120;
        public Hunter(int health, int attack, string name) : base(health, attack)
        {
            this.name = name;
        }
        public int MeteorExcalibur() => attkPowerMeteor;
        public int ThunderWave() => attkPowerThunder;
    }
}
