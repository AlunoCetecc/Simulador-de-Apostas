using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulador_de_apostas
{
    public class Aposta
    {
        public int Quantidade { get; set; }
        public int NumCachorro { get; set; }
        public Apostador MeuApostador { get; set; }

        public string ObterDescricao()
        {
            if (Quantidade == 0)
            {
                return string.Format("{0} não apostou", MeuApostador.Nome);
            }

            return string.Format("{0} apostou {1} no cachorro {2}",
                                 MeuApostador.Nome,
                                 Quantidade,
                                 NumCachorro);
        }

        public int ObterPagamento(int Winner)
        {
            if (Winner == NumCachorro)
            {
                return Quantidade;
            }
            else
            {
                return Quantidade * (-1);
            }
        }
    }
}









