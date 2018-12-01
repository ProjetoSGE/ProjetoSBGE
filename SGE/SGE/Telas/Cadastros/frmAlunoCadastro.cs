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
    public partial class frmAlunoCadastro : UserControl
    {
        public frmAlunoCadastro()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            SGEEntities db = new SGEEntities();

            tb_alunos tb = new tb_alunos();
            tb.ds_anoEstudo = comboBox2.Text;
            tb.ds_areaPreferencia = txtPreferencia.Text;
            tb.ds_bairro = txtBairro.Text;
            tb.ds_cep = mskCEP.Text;
            tb.ds_endereco = txtEndereco.Text;
            tb.ds_expProfissional = txtExperiencia.Text;
            tb.ds_idade =Convert.ToInt32(txtIdade.Text);
            tb.ds_numero = Convert.ToInt32(txtN.Text);
            tb.ds_qualCurso = comboBox1.Text;
            tb.ds_seEstuda = null;
            tb.ds_turno = null;
            tb.dt_nascimento = dateTimePicker1.Value;
            tb.nm_aluno = txtNome.Text;
            tb.nm_curso = null; // repete duas vezes?
            tb.nr_celular = mskRecado.Text;
            tb.nr_fixo = mskRes.Text ;
            tb.tb_candidato = null; // o que é isso?


            db.tb_alunos.Add(tb);
            db.SaveChanges();


            
        }
    }
}
