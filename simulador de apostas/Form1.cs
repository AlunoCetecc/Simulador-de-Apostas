using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulador_de_apostas
{
    public partial class Form1 : Form
    {
        private CaoCinza[] _caes;
        private Apostador[] _caras;
        
        public Form1()
        {
            InitializeComponent();
            _caes = new CaoCinza[4];
            _caras = new Apostador[3];          
        }
              
        private void Form1_Load(object sender, EventArgs e)
        {

            for(int c = 0; c < 4; c++)
            {
                CaoCinza cao = new CaoCinza();
                cao.comprimentoPista = pbPista1.Width;
                cao.MinhaCaixaImagem = (PictureBox)this.Controls["pbCachorro" + (c + 1).ToString()];
                cao.TomePosiçãoInicial();
                cao.MyRandom = new Random();
                cao.MyRandom.Next(10);
                _caes[c] = cao;
            }
            for(int c2 = 0; c2 < 3; c2++)
            {
                Apostador Homens = new Apostador();
                Homens.Nome = ((RadioButton)this.Controls ["RBn" + (c2 + 1).ToString()]).Text;
                Homens.MeuLabel.Text = Homens.Nome;
                
          }
        }

        private void RBn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
            {
                lblNome.Text = button.Text;
            }
        }
    }
}
