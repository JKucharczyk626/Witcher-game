using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPostacie
{
    public abstract class Wiedzmin : Walczacy
    {
        Random random = new Random();
        private string name;
        private int maxHP;
        private int currentHP;
        private int dodgeChance;
        private int attackPower;
        private int healthPotion;

        public int CurrentHP { get => currentHP; set => currentHP = value; }

        public Wiedzmin(string name, int HP, int dodgeChance, int attackPower, int healthPotion)
        {
            this.name = name;
            this.CurrentHP = HP;
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
            this.CurrentHP = this.maxHP;
        }

        public void drinkHealthPotion()
        {
            if (this.healthPotion > 0)
            {
                this.CurrentHP = this.maxHP;
                this.healthPotion--;
            }
            Console.WriteLine(" Zostalo: " + this.healthPotion);
            Console.WriteLine(" Wiedzmin hp: " + this.CurrentHP);
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
            this.CurrentHP -= damage;
            if (this.CurrentHP < 0) this.CurrentHP = 0;
            Console.WriteLine(" - Geralt: 'Zaraza...'");
            Console.WriteLine("Wiedzmin oberwał, zostało " + this.CurrentHP + "HP");
        }
        public override bool isAlive()
        {

            return this.CurrentHP > 0;

        }
        public int getCurrentHP()
        {
            return this.CurrentHP;
        }

        public void getCurrentHP2()
        {
            Console.WriteLine("  > Wiedzmin hp: " + this.CurrentHP);
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
