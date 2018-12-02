using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE.Telas.Consultas
{
    public partial class frmCandidatoConsulta : UserControl
    {
        public frmCandidatoConsulta()
        {
            InitializeComponent();
        }

        SGEEntities db = new SGEEntities();

        private void button1_Click(object sender, EventArgs e)
        {
           
            List<vw_candidato> candidato = db.vw_candidato.Where(a => a.nm_aluno.Contains(textBox1.Text)).ToList();
        }

        private void dgvCandidato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                vw_candidato alunos = dgvCandidato.Rows[e.RowIndex].DataBoundItem as vw_candidato;


                //Alteração.frmAlunoAlterar tela = new Alteração.frmAlunoAlterar();
                //tela.LoadScreen(alunos);
                //tela.ShowDialog();
                //this.Hide();

            }

            if (e.ColumnIndex == 5)
            {
                vw_candidato alunoss = dgvCandidato.CurrentRow.DataBoundItem as vw_candidato;

                DialogResult r = MessageBox.Show("Deseja excluir o aluno ?", "Instituto Nossa Senhora de Fatima",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    db.vw_candidato.Remove(alunoss);
                    db.SaveChanges();
                }
            }
        }
    }
}
