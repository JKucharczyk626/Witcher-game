using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedzmak;
using BPostacie;


namespace Main
{
    /// <summary>
    // wlasciwosci pól !
    // lista potworow (dziedziczac po klasie potwor)
    // potwor, walczacy, wiedzmin -> klasy abstrakcyjne jako oddzielne biblioteki(?)
    // main implementuje wszystko, Wilkolak impelemntuje potwory
    /// </summary>
    class main
    {
        static void Main(string[] args)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Music\Witcher.wav");
            player.Play();

            Wiedzmin Geralt = new Geralt("Geralt", 100, 30, 40, 2);
            Potwor Nekker = new Nekker("Nekker", 200, 30);

            Console.WriteLine("!!! POCZATEK WALKI !!!");
            Geralt.getCurrentHP2();
            Nekker.getCurrentHP2();
            Console.WriteLine();



            Bitwa bitwa = new Bitwa(Geralt, Nekker);
            if (bitwa.willWitcherWinFight())
            {
                Console.WriteLine(" --- Wiedzmin zwyciezyl --- ");
            }
            else
                Console.WriteLine(" --- Wiedzmin padl --- ");

            Console.ReadKey();
        }
        
    }




}
