using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMegaSena
{
    public class MegaSena
    {
        protected int maxNumero;
        protected List<int> sorteados;

        public MegaSena(int maxNumero)
        {
            this.maxNumero = maxNumero;
            this.sorteados = new List<int>();
        }
        public virtual void Sortear()
        {
            Random random = new Random();
            List<int> numerosPossiveis = Enumerable.Range(1, maxNumero).ToList();

            for (int i = 0; i < 6; i++)
            {
                int index = random.Next(0, numerosPossiveis.Count);
                sorteados.Add(numerosPossiveis[index]);
                numerosPossiveis.RemoveAt(index);
            }

            sorteados.Sort();
            Console.WriteLine($"Os números sorteados foram: {string.Join(",", sorteados)} ");

        }

        public int Verificar(List<int> numerosUsuario)
        {
            int acertos = sorteados.Intersect(numerosUsuario).Count();
            return acertos;
        }

        public void ExibirResultado(int acertos)
        {
            switch (acertos)
            {
                case 6:
                    Console.WriteLine("Parabéns acertou 6, você está rico! Quero um carro!");
                    break;
                case 5:
                    Console.WriteLine("Parabéns acertou 5, quero um churrasco!");
                    break;
                case 4:
                    Console.WriteLine("Parabéns acertou 4, mas ganhou pouco dinheiro.");
                    break;
                default:
                    Console.WriteLine("Que pena, não foi dessa vez. Tente novamente!");
                    break;
            }
        }
    }
}