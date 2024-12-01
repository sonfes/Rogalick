using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogaliiick
{
    internal class Weapon
    {
        static Random rnd = new Random();
        static string[] weaponNameList = new string[] { "Вексана", "Флорида", "Теризла", "Феникс", "Циклопио", "Диро", "Фаша", "Мелисса" };
        public string weaponName = weaponNameList[rnd.Next(0, 8)];
        public int damage = rnd.Next(10, 61);
    }
}
