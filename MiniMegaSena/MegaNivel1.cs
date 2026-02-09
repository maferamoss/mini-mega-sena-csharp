using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMegaSena
{
    public class MegaNivel1 : MegaSena
    {
        public MegaNivel1() : base(30)
        {
        }

        public override void Sortear()
        {
            Console.WriteLine("Sorteando números do Nível 1...");
            base.Sortear(); 
        }
    }
}
