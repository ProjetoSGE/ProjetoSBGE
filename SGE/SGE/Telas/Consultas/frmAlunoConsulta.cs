using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGE.Telas.Alteração;

namespace SGE.Telas.Consultas
{
    public partial class frmAlunoConsulta : UserControl
    {
        public frmAlunoConsulta()
        {
            InitializeComponent();
        }

        SGEEntities db = new SGEEntities();


        private void button1_Click(object sender, EventArgs e)
        {
            List<tb_alunos> alunos = db.tb_alunos.Where(a => a.nm_aluno.Contains(textBox1.Text)).ToList();
                                                 
        }

        private void dgvAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                tb_alunos alunos = dgvAluno.Rows[e.RowIndex].DataBoundItem as tb_alunos;


                frmAlunoAlterar tela = new frmAlunoAlterar();
                tela.LoadScreen(alunos);
                tela.ShowDialog();
                this.Hide();

            }

            if (e.ColumnIndex == 5)
            {
                tb_alunos alunos = dgvAluno.CurrentRow.DataBoundItem as tb_alunos;

                DialogResult r = MessageBox.Show("Deseja excluir o aluno ?", "Instituto Nossa Senhora de Fatima",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    db.tb_alunos.Remove(alunos);
                    db.SaveChanges();
                }
            }

        }
    }
}
