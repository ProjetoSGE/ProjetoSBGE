using System;
using System.Windows.Forms;

namespace SGE.Telas.Alteração
{
    public partial class frmAlunoAlterar : Form
    {
        public frmAlunoAlterar()
        {
            InitializeComponent();
        }
        public tb_alunos alunos;

        public void Loadscreen(tb_alunos alu)
        {
            this.alunos = alu;

            cboAnoEstudou.Text = alu.ds_anoEstudo;
            txtPreferencia.Text = alu.ds_areaPreferencial ;
            txtBairro.Text = alu.ds_bairro;
            mskCEP.Text = alu.ds_cep ;
            txtEndereco.Text = alu.ds_endereco ;
            txtExperiencia.Text = alu.ds_expProfissional;
            txtIdade.Text = alu.ds_idade.ToString() ;
            txtNumero.Text =alu.ds_numero.ToString();
            cboCurso.Text = alu.ds_qualCurso ;
            cboTurno.Text = alu.ds_turno;
            dtpDataNasc.Value = alu.dt_nascimento;
            txtNome.Text = alu.nm_aluno;
            cboSerie.Text = alu.nm_curso;
            mskRecado.Text = alu.nr_celular;
            mskRes.Text = alu.nr_fixo;
            txtrgg.Text = alu.ds_rg;

            if (alu.ds_seEstuda == "Sim")
            {
               rdbSim.Checked = true ;
            }

            if (alu.ds_seEstuda == "Não")
            {
                rdbNao.Checked = true;
            }

            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SGEEntities db = new SGEEntities();

            
            alunos.ds_anoEstudo = cboAnoEstudou.Text;
            alunos.ds_areaPreferencial = txtPreferencia.Text;
            alunos.ds_bairro = txtBairro.Text;
            alunos.ds_cep = mskCEP.Text;
            alunos.ds_endereco = txtEndereco.Text;
            alunos.ds_expProfissional = txtExperiencia.Text;
            alunos.ds_idade = Convert.ToInt32(txtIdade.Text);
            alunos.ds_numero = Convert.ToInt32(txtNumero.Text);
            alunos.ds_qualCurso = cboCurso.Text;
            alunos.ds_turno = cboTurno.Text;
            alunos.dt_nascimento = dtpDataNasc.Value;
            alunos.nm_aluno = txtNome.Text;
            alunos.nm_curso = cboSerie.Text;
            alunos.nr_celular = mskRecado.Text;
            alunos.nr_fixo = mskRes.Text;
            alunos.ds_rg = txtrgg.Text;

            if (rdbSim.Checked == true)
            {
                alunos.ds_seEstuda = "Sim";
            }

            if (rdbNao.Checked == true)
            {
                alunos.ds_seEstuda = "Não";
            }


            db.tb_alunos.Add(alunos);
            db.SaveChanges();

            MessageBox.Show("Salvo");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAlunoAlterar_Load(object sender, EventArgs e)
        {

        }
    }
}
