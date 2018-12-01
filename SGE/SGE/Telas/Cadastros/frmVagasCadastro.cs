using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE.Telas.Cadastros
{
    public partial class frmVagasCadastro : UserControl
    {
        public frmVagasCadastro()
        {
            InitializeComponent();
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            TimeSpan time = TimeSpan.Parse(mtkInicio.Text);
            TimeSpan time1 = TimeSpan.Parse(mtkIntervalo.Text);
            TimeSpan time2 = TimeSpan.Parse(mtkVolta.Text);
            TimeSpan time3 = TimeSpan.Parse(mtkFim.Text);

            SGEEntities db = new SGEEntities();

            tb_vagas tb = new tb_vagas();
            tb.ds_compPessoal = txtTarefa.Text;
           
            tb.ds_horario = time;
            tb.ds_intervalo = time1;
           

        }
    }
}
