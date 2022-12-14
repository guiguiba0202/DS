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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            frmCarro formCarro = new frmCarro();
            this.Hide();
            formCarro.Show();
        }

        private void btnCaminhao_Click(object sender, EventArgs e)
        {
            frmCaminhao formCaminhao = new frmCaminhao();
            this.Hide();
            formCaminhao.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
