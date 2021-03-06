using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using agendamint.classes;
using agendamint.formularios;

namespace agendamint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var admin = new Administrador();

            bool loginVerification = admin.doLogin(txtLogin.Text, txtSenha.Text);

            if (loginVerification)
            {
                var frmAdmin = new Admin();
                frmAdmin.Show();
            }
        }
    }
}
