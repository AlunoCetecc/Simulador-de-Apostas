using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulador_de_apostas
{
   public class CaoCinza
    {
        public int PosiçaoInicial { get;set;} // onde a minha caixa de imagem inicia
        public int comprimentoPista { get; set; } // o quanto a pista de corrida tem de comprimeinto
        public PictureBox MinhaCaixaImagem = null; //Meu objeto caixa de imagem
        public int localizaçao = 0; // Minha posiçao na pista 
        public Random MyRandom; // Uma instancia de random

        public bool Run()
        {
                  // Mova-se para frente 1 , 2, 3 ou 4 espaços aleatoriamente 
                  // Atualize a posiçao da minha caixa dde imagem no formulario
                  //TODO: Retorna True se eu ganhei a corrida
                  

            return false;
        }
        public void TomePosiçãoInicial()
        {
           // MinhaCaixaImagem.Location = new Point(12, MinhaCaixaImagem.Location.Y);  //TODO: volte minha posiçao para a linha de partida
            
        }
    }
}
