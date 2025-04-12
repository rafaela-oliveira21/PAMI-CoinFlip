using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    internal class Coin
    {
        //ModificadorDeAcesso Tipo Nome 
        private string ladoSorteado;

        public string LadoSorteado {get => ladoSorteado; set => ladoSorteado = value;}

        public Coin()
        {
        }

        public string Flip()
        {   
            
            Random random = new Random();
            /*
            if (random.Next(2) == 0)
            {
                LadoSorteado = "Cara";
            }
            else
            {
                LadoSorteado = "Coroa";
            }
            */

            LadoSorteado = random.Next(2) == 0 ? "Cara" : "Coroa";
            return (LadoSorteado);



        }
        


    }
}
