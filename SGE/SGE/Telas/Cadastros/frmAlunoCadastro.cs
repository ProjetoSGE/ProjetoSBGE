using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;

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
            try
            {

                SGEEntities db = new SGEEntities();

                tb_alunos tb = new tb_alunos();
                tb.ds_anoEstudo = cboAnoEstudou.Text;
                tb.ds_areaPreferencial = txtPreferencia.Text;
                tb.ds_bairro = txtBairro.Text;
                tb.ds_cep = mskCEP.Text;
                tb.ds_endereco = txtEndereco.Text;
                tb.ds_expProfissional = txtExperiencia.Text;
                tb.ds_idade = Convert.ToInt32(txtIdade.Text);
                tb.ds_numero = Convert.ToInt32(txtNumero.Text);
                tb.ds_qualCurso = cboCurso.Text;
                tb.ds_turno = cboTurno.Text;
                tb.dt_nascimento = dtpDataNasc.Value;
                tb.nm_aluno = txtNome.Text;
                tb.nm_curso = cboSerie.Text;
                tb.nr_celular = mskRecado.Text;
                tb.nr_fixo = mskRes.Text;
                tb.ds_rg = txtrg.Text;

                if (rdnSim.Checked == true)
                {
                    tb.ds_seEstuda = "Sim";
                }

                if (rdbNao.Checked == true)
                {
                    tb.ds_seEstuda = "Não";
                }
                db.tb_alunos.Add(tb);
                db.SaveChanges();

            }

            catch (DbEntityValidationException entry)
            {
                foreach (var eve in entry.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

        }

        private void frmAlunoCadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
