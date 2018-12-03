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
    public partial class frmVagasConsulta : UserControl
    {
        SGEEntities db = new SGEEntities();
        public frmVagasConsulta()
        {
            InitializeComponent();
        }

        private void frmVagasConsulta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<vw_vagas> candidato = db.vw_vagas.Where(a => a.nm_fantasia.Contains(textBox1.Text)).ToList();
        }

        private void dgvVaga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                vw_vagas vagas = dgvVaga.Rows[e.RowIndex].DataBoundItem as vw_vagas;


                Alteração.frmAlunoAlterar tela = new Alteração.frmAlunoAlterar();
               // tela.LoadScreen(vagas);
                tela.ShowDialog();
                this.Hide();

            }

            if (e.ColumnIndex == 5)
            {
                vw_vagas vagas = dgvVaga.CurrentRow.DataBoundItem as vw_vagas;

                DialogResult r = MessageBox.Show("Deseja excluir a vaga?", "Instituto Nossa Senhora de Fatima",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    db.vw_vagas.Remove(vagas);
                    db.SaveChanges();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
