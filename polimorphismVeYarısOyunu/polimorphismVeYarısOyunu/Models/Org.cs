using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorphismVeYarısOyunu.Models
{
   public class Org : Character
    {
        Random rnd = new Random();

        public override int GetSpeed()
        {
            return rnd.Next(6,12);
        }
    }
}
