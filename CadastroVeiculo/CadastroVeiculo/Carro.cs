using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroVeiculo
{
    public partial class frmCarro : Form
    {
        cCarro carro;
        public frmCarro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmHome formHome = new frmHome();
            this.Hide();
            formHome.Show();
        }

        private void frmCarro_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            carro = new cCarro(txtMarca.Text, txtModel.Text, txtChassi.Text, txtCor.Text, txtPlaca.Text, txtPortas.Text, txtBagagem.Text, txtCarroceria.Text);
            txtMarca.Clear();
            txtModel.Clear();
            txtChassi.Clear();
            txtCor.Clear();
            txtPlaca.Clear();
            txtPortas.Clear();
            txtBagagem.Clear();
            txtCarroceria.Clear();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
