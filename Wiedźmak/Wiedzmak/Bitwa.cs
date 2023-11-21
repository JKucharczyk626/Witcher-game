using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPostacie;

namespace Wiedzmak
{
    public class Bitwa
    {
        Random random = new Random();
        public Wiedzmin Geralt;
        public Potwor Nekker;

        public Bitwa(Wiedzmin Geralt, Potwor Nekker)
        {
            this.Geralt = Geralt;
            this.Nekker = Nekker;
        }

        private string makeDecision()
        {
            if (this.Geralt.attack() > this.Nekker.getCurrentHP())
            {
                return "attack";
            }
            if (2 * Geralt.CurrentHP < 3 * this.Geralt.attack() && this.Geralt.checkIfAnyHealthPotion())
            {
                return "drinkHealthPotion";
            }
            return "attack";
        }
 
        public bool willWitcherWinFight()
        {
            System.Threading.Thread.Sleep(2000);
            while (this.Geralt.isAlive() && this.Nekker.isAlive())
            {
                switch (makeDecision())
                {
                    case "attack":
                        Console.WriteLine(" Wiedzmin atakuje");
                        this.Nekker.takeDamage(this.Geralt.attack());
                        if (!this.Nekker.isAlive()) return true;
                        System.Threading.Thread.Sleep(1000);
                        break;
                    case "drinkHealthPotion":
                        Console.WriteLine(" Wiedzmin pije potke ");
                        this.Geralt.drinkHealthPotion();
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
                
                if (Geralt.Dodge())
                {
                    Console.WriteLine("Wiedźmin uniknął ciosu");
                }
                else
                    this.Geralt.takeDamage(this.Nekker.attack());

                System.Threading.Thread.Sleep(1000);
                this.Geralt.getCurrentHP2();
                this.Nekker.getCurrentHP2();

                Console.WriteLine();

                if(this.Nekker.getCurrentHP() <= this.Nekker.getMaxHP()/2)
                Console.WriteLine("Potwor jest w szale!");

                Console.WriteLine();
                System.Threading.Thread.Sleep(3000);
            }
            return false;
        }


    }

}
