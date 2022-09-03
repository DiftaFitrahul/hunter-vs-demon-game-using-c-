using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //class ini merupakan parent class dari demon class dan hunter class
    //di class ini akan mengset HP dan Power Attack masing masing Character
    public class Character
    {
        private int health;
        private int attack;

        public Character(int aHealth, int anAttack)
        {
            Health = aHealth;
            Attack = anAttack;
        }

        //fungsi ini bertujuan agar nilai dari HP dan Attack tetap positif karena tidak mungkin nilai dari HP dan Attack negatif
        public int Health
        {
            get { return health; }
            set => _ = value < 50 ? health = 50 : health = value;
        }

        public int Attack
        {
            get { return attack; }
            set => _ = value < 0 ? attack = value * -1 : attack = value;
        }
    }
}
