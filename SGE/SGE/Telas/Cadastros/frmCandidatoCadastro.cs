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
    public partial class frmCandidatoCadastro : UserControl
    {
        public frmCandidatoCadastro()
        {
            InitializeComponent();
        }
        SGEEntities db = new SGEEntities();

        private void btnsalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadatrar_Click(object sender, EventArgs e)
        {
           

            tb_candidato dto = new tb_candidato();
            tb_alunos dto1 = CboStatus.SelectedItem as tb_alunos;
            tb_vagas dto2 = cboVaga.SelectedItem as tb_vagas;

            dto.id_aluno = dto1.id_aluno;
            dto.id_vaga = dto2.id_vaga;
            dto.ds_status = CboStatus.SelectedText;

            db.tb_candidato.Add(dto);
            db.SaveChanges();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmCandidatoCadastro_Load(object sender, EventArgs e)
        {

        }

        

        private void cboCurso_Validated(object sender, EventArgs e)
        {
            List<tb_alunos> alunos = db.tb_alunos.Where(a => a.ds_qualCurso.Contains(cboCurso.Text)).ToList();


            cboAluno.DisplayMember = nameof(tb_alunos.nm_aluno);
            cboAluno.ValueMember = nameof(tb_alunos.id_aluno);
            cboAluno.DataSource = alunos;
        }
    }
}
