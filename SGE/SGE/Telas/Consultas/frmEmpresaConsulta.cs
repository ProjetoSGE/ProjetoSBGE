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
    public partial class frmEmpresaConsulta : UserControl
    {
        public frmEmpresaConsulta()
        {
            InitializeComponent();
        }
        SGEEntities db = new SGEEntities();
        private void button1_Click(object sender, EventArgs e)
        {

           
            List<tb_empresas> empresas = db.tb_empresas.Where(a => a.nm_fantasia.Contains(textBox1.Text)).ToList();
            dgvEmpresa.AutoGenerateColumns = false;
            dgvEmpresa.DataSource = empresas;


        }

        private void dgvEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                tb_empresas funcionarios = dgvEmpresa.Rows[e.RowIndex].DataBoundItem as tb_empresas;


                //frmEmpresaAlterar tela = new frmEmpresaAlterar();
                //tela.LoadScreen(funcionarios);
                //tela.ShowDialog();
                //this.Hide();

            }

            if (e.ColumnIndex == 5)
            {
                tb_empresas empresas = dgvEmpresa.CurrentRow.DataBoundItem as tb_empresas;

                DialogResult r = MessageBox.Show("Deseja excluir a empresa ?", "Instituto Nossa Senhora de Fatima",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    db.tb_empresas.Remove(empresas);
                    db.SaveChanges();
                }
            }
        }
    }
}
