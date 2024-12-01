using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.Design;
using System.Xml.Linq;

namespace Rogaliiick
{

    internal class Program
    {
        static bool hhh = true;
        static string enName = "";
        static int hpEn = 0;
        static bool escape = true;
        static int escapeReRun = 0;
        static int Hp = 0;
        static int damage = 0;
        static int aidCount = 3;


        static void Main()
        {
            Console.Clear();
            Player name = new Player();
            Weapon weapon = new Weapon();
            Weapon weaponDamage = new Weapon();
            Player hp = new Player();
            Console.WriteLine("Здравствуй молодой игрок, скажи свое имя\n");
            string playerName = name.nameC = Console.ReadLine();
            string WeaponName = weapon.weaponName;
            damage = weaponDamage.damage;
            Hp = hp.Hp;
            Console.WriteLine($"{playerName} Добро пожаловать в игру\nНажми enter чтобы продолжить");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"{playerName} вам был послан {WeaponName} ({damage}) \nУ вас ({Hp}) hp ");
            Console.WriteLine("Нажми enter чтобы продолжить");
            Console.ReadLine();
            Console.Clear();
            ChocieFigts();
        }



        static string EnemyInicialisatonName(string en)
        {
            Enemy enemyName = new Enemy();
            string enName = enemyName.enemyName;
            return enName;

        }
        static int EnemyIncialsationHp(int hp)
        {
            Enemy enemyHp = new Enemy();
            int hpEn = enemyHp.enemyHp;
            return hpEn;
        }
        static void ChocieFigts()
        {
            Console.Clear();
            if (Hp > 0)
            {
                if (escapeReRun == 3)
                {
                    escapeReRun = 0;
                    escape = true;
                }
                if (hhh == false)
                {
                    Console.WriteLine($"У вас {Hp} хп у монстра {hpEn} хп\n1 Убежать \n2 Ударить \n3 Аптечка");
                }
                if (hhh == true)
                {
                    enName = EnemyInicialisatonName(enName);
                    hpEn = EnemyIncialsationHp(hpEn);
                    Console.WriteLine($"На пути {enName} {hpEn} HP. Что же вам делать?\n1 Убежать \n2 Ударить \n3 Аптечка");
                    hhh = false;

                }
                Aid HpRegen = new Aid();
                int hpRegenFromAid = HpRegen.hp;
                Enemy dam = new Enemy();
                int damageEn = dam.enemyDamage;
                string choiceStr = Console.ReadLine();
                int choice = 0;
                try
                {
                    choice = Convert.ToInt32(choiceStr);
                }
                catch { Console.WriteLine("Неверный формат ввода\n"); }
                try
                {
                    switch (choice)
                    {
                        case 1:
                            if (escape == true)
                            {
                                Random rnd = new Random();
                                int digit = rnd.Next(0, 11);
                                if (digit >= 5)
                                {
                                    Console.WriteLine("Вы убежали\n");
                                    hhh = true;
                                    ChocieFigts();
                                }
                                else
                                {
                                    Console.WriteLine("Вы не смогли убежать\n");
                                    Hp -= damageEn;
                                    escape = false;
                                    ChocieFigts();


                                }
                            }
                            else { Console.WriteLine("Вы уже пытались сбежать. Подождите 3 хода"); ChocieFigts(); }

                            break;
                        case 2:
                            Hp -= damageEn;
                            escapeReRun += 1;
                            hpEn -= damage;
                            if (hpEn <= 0)
                            {
                                Console.WriteLine("монстр убит\nНажми enter чтобы продолжить");
                                Console.ReadLine();
                                hhh = true;
                                Random rnd = new Random();
                                int rand = rnd.Next(0, 11);
                                if (rand >= 7)
                                {
                                    aidCount++;
                                    Console.WriteLine("Вы получили 1 аптечку\nПродолжить");
                                }
                            }

                            ChocieFigts();

                            break;
                        case 3:
                            if (aidCount > 0)
                            {
                                Hp += hpRegenFromAid;
                                aidCount--;
                                Console.WriteLine($"Вы использовали аптечку.\n Востановлено {hpRegenFromAid} ");
                                ChocieFigts();
                            }
                            else
                            {
                                Console.WriteLine("У вас больше нету аптечек\n продолжить");
                                Console.ReadLine();
                                ChocieFigts();
                            }

                            break;

                        default:
                            Console.WriteLine("такого выбора нету");
                            ChocieFigts();
                            break;



                    }


                }
                catch { Console.WriteLine("неверный формат ввода"); }

            }
            else
            {
                Console.WriteLine("Вы умерли. Начать заново? y/n");
                string restart = Console.ReadLine();
                if (restart == "y")
                {
                    bool hhh = true;
                    string enName = "";
                    int hpEn = 0;
                    bool escape = true;
                    int escapeReRun = 0;
                    int Hp = 0;
                    int damage = 0;
                    int aidCount = 3;
                    Main();

                }
            }
        }
    }


}
