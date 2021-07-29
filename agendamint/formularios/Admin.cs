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

namespace agendamint.formularios
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            empresa.Responsavel = txtResponsavel.Text;
            empresa.RazaoSocial = txtRazao.Text;
            empresa.ChavePix    = txtChavePix.Text;
            empresa.TipoPix     = cmbTipo.Text;
            empresa.BancoTxt    = txtBanco.Text;
            empresa.Cnpj        = txtCnpj.Text;
            empresa.Email       = txtEmail.Text;
            empresa.inserir();

            MessageBox.Show("Empresa " + empresa.Id + " cadastrada com sucesso!");
        }
    }
}
