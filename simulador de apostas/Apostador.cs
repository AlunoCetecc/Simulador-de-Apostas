using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulador_de_apostas
{
    public class Apostador
    {
        public string Nome { get; set; }// O nome do cara
        public Aposta MinhaApostas { get; set; } //Uma instancia de Bet () que mantem as apostas
        public int Dinheiro { get; set; } // Quanto dinheiro resta
        // Os ultimos dois campos sao os controles no formulario da gui dos caras 
        public RadioButton MyRadioButton { get; set; }//botao de radio
        public Label MeuLabel { get; set; }

        public Apostador()
        {
            MeuLabel = new Label();
        }
 
        public void AtualizarLabels()
        {
              
        }
        //Atribua meu rotulo a descriçao da minha aposta, e ao rotulo do 
        //meu botao de radio o meu dinheiro ("Joao tem 4 reais")

        public void LimparAposta() // reinicialize minha aposta para que ela zere
        {
            MinhaApostas.Quantidade = 0;
        }

        public bool NovaApostas(int Quantidade, int MeuCão)
        {

            if (Dinheiro > Quantidade)// Retorne verdadeiro se o cara tem dinheiro suficiente para apostar
            {
                MinhaApostas = new Aposta(); // crie uma nova aposta e armazene-a no meu campo bet
                MinhaApostas.NumCachorro = MeuCão;
                MinhaApostas.Quantidade = Quantidade;
                return true;
            }
            return false;
        }
        public void coletar(int Winner) // cobre minha apostas se eu ganhei
        {
            MinhaApostas.ObterPagamento(Winner);
            Dinheiro = Dinheiro + MinhaApostas.ObterPagamento(Winner);


        }
    }
}