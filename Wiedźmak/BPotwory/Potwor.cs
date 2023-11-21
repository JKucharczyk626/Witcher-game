using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPostacie
{
    public abstract class Potwor : Walczacy
    {
        protected String name;
        protected int currentHP;
        protected int maxHP;
        protected int attackPower;

        public Potwor(String name, int HP, int attackPower)
        {
            this.name = name;
            this.currentHP = HP;
            this.maxHP = HP;
            this.attackPower = attackPower;
        }

        public override int attack()
        {
            Console.WriteLine("Potwor atakuje");
            if (this.currentHP > this.maxHP / 2)
                return this.attackPower;
            else
                return this.attackPower * 2;
        }

        public override void takeDamage(int damage)
        {
            this.currentHP -= damage;
            if (this.currentHP < 0) this.currentHP = 0;
            Console.WriteLine("Potwor oberwal, zostalo mu: " + this.currentHP + "HP");
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
            Console.WriteLine("  > Potwor hp: " + this.currentHP);

        }

        public int getMaxHP()
        {
            return this.maxHP;
        }

        public String getName()
        {
            return this.name;
        }

        public void regenerate()
        {
            this.currentHP = this.maxHP;
        }
    }
}
