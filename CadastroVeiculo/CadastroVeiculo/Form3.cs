using CadastroVeiculo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DsVeiculo
{
    public partial class frmCaminhao : Form
    {
        Caminhao caminhao;
        public frmCaminhao()
        {
            InitializeComponent();
        }

        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome formHome = new frmHome();
            formHome.Show();
        }

        private void frmCaminhao_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar1_Click(object sender, EventArgs e)
        {
            caminhao = new Caminhao(txtMarca1.Text, txtModelo1.Text, txtChassi1.Text, txtCor1.Text, txtPlaca1.Text, txtPortas1.Text, txtCapacidade.Text, txtCabine.Text);
            txtMarca1.Clear();
            txtModelo1.Clear();
            txtChassi1.Clear();
            txtCor1.Clear();
            txtPlaca1.Clear();
            txtPortas1.Clear();
            txtCapacidade.Clear();
            txtCabine.Clear();
        }

        private void btnExibir1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caminhao.FunfaLogo());
        }
    }
}
