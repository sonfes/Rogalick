using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogaliiick
{
    internal class Enemy
    {
        static Random rnd = new Random();
        static string[] enemyNameList = new string[] { "Лорд", "Маг", "Киборг", "Троль", "Огр", "Дракон", "ЗмейГорыныч", "Малифсента" };
        public string enemyName = enemyNameList[rnd.Next(0, 5)];
        public int enemyHp = rnd.Next(40, 81);
        public int enemyDamage = rnd.Next(0, 11);

    }
}