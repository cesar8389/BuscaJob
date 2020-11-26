using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaJob.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (rbCandidato.Checked == true)
            {
                frmCadastroCandi cadastroCandi = new frmCadastroCandi(true);
                cadastroCandi.ShowDialog();
            }
            if (rbEmpresa.Checked == true)
            {

            }
            if (rbCandidato.Checked == false && rbEmpresa.Checked == false)
            {
                MessageBox.Show("Por favor, selecione se seu perfil é de empresa ou candidato.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (rbCandidato.Checked == true) { 
                
            }
            if (rbEmpresa.Checked == true)
            {

            }
            if (rbCandidato.Checked == false && rbEmpresa.Checked == false)
            {
                MessageBox.Show("Por favor, selecione se seu perfil é de empresa ou candidato.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
