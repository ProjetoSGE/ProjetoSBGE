using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGE.Telas.plugin;

namespace SGE.Telas.Adicionais
{
    public partial class emailempresa : UserControl
    {
        public emailempresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.Enviar(txEmail.Text, conteudo.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_empresas empresa = comboBox1.SelectedItem as tb_empresas;
            txEmail.Text = empresa.ds_email;
        }
    }
}
