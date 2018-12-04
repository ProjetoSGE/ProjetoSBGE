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

        private void btnsalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadatrar_Click(object sender, EventArgs e)
        {
            SGEEntities db = new SGEEntities();

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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
