using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMegaSena
{
    public class MegaNivel2 : MegaSena
    {
        public MegaNivel2() : base(60)
        {
        }

        public override void Sortear()
        {
            Console.WriteLine("Sorteando números do Nível 2...");
            base.Sortear();
        }
    }
}
