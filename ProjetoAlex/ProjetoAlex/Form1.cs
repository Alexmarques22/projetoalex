using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAlex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            primeiramensagem.Visible = false;
        
                
         }

        private void botao_Click(object sender, EventArgs e)
        {
            primeiramensagem.Visible = true;
            primeiramensagem.Text = "nova mensagem";
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void load(object sender, EventArgs e)
        {

        }

        private void botao2_Click(object sender, EventArgs e)
        {
           
            label1.Text = "";
        
                
         }

        private void chega_Click(object sender, EventArgs e)
        {
            ultimamensagem.Visible = false;
        }
    }
}
