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
    public partial class frmCaminhao : Form
    {
        public frmCaminhao()
        {
            InitializeComponent();
        }

        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            frmHome formHome = new frmHome();
            this.Hide();
            formHome.Show();
        }
    }
}
