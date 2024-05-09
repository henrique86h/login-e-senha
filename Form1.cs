using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace login_e_senha
{
    public partial class FormSistema : Form
    {
        Thread nt; // cração da thead como 'se fosse uma variável'

        public FormSistema()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Admin" && textBoxSenha.Text == "123456")
            {
                //MessageBox.Show("Bem vindo ao sistema!", "Acesso ao sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                nt = new Thread(novoform)
            }
            else
            {
                MessageBox.Show("Acesso negado!", "Acesso negado !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void novoform(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
