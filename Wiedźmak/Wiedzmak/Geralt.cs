using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPostacie;

namespace Wiedzmak
{
   
        public class Geralt : Wiedzmin
        {
            Random random = new Random();
            private string name;
            private int maxHP;
            private int currentHP;
            private int dodgeChance;
            private int attackPower;
            private int healthPotion;

            public Geralt(string name, int HP, int dodgeChance, int attackPower, int healthPotion) : base(name,HP,dodgeChance,attackPower,healthPotion)
            {
                this.name = name;
                this.currentHP = HP;
                this.maxHP = HP;
                this.dodgeChance = dodgeChance;
                this.attackPower = attackPower;
                this.healthPotion = healthPotion;
            }

        public void increasePotionNumber(int number)
            {
                healthPotion += number;
            }
            public bool Dodge()
            {
                if (random.Next(1, 100) < this.dodgeChance)
                    return true;
                else
                    return false;
            }
            public void heal()
            {
                this.currentHP = this.maxHP;
            }

            public void drinkHealthPotion()
            {
                if (this.healthPotion > 0)
                {
                    this.currentHP = this.maxHP;
                    this.healthPotion--;
                }
                Console.WriteLine(" Zostalo: " + this.healthPotion);
                Console.WriteLine(" Wiedzmin hp: " + this.currentHP);
            }

            public bool checkIfAnyHealthPotion()
            {
                return this.healthPotion > 0;
            }

            public override int attack()
            {
                return this.attackPower;
            }

            public override void takeDamage(int damage)
            {
                CurrentHP -= damage;
                if (CurrentHP < 0) CurrentHP = 0;
                Console.WriteLine(" - Geralt: 'Zaraza...'");
                Console.WriteLine("Wiedzmin oberwał, zostało " + CurrentHP + "HP");
            }
            public override bool isAlive()
            {

                return this.currentHP > 0;

            }
            public int getCurrentHP()
            {

                return this.currentHP;
            }

            public void getCurrentHP2()
            {
                Console.WriteLine("  > Wiedzmin hp: " + this.currentHP);

            }

            public int getMaxHP()
            {
                return this.maxHP;
            }

            public string getName()
            {
                return this.name;
            }

            public int getPotionCount()
            {
                return this.healthPotion;
            }


        }
    }