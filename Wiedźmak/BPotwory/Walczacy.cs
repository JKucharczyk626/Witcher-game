using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPostacie
{
       public abstract class Walczacy
       {
           abstract public int attack();
    
           abstract public bool isAlive();
    
           abstract public void takeDamage(int damage);
       }   
}
