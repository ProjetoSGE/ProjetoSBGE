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
    public partial class AlunoEmail : UserControl
    {
        public AlunoEmail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.Enviar(textBox1.Text, conteudo.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_alunos;
        }
    }
}
