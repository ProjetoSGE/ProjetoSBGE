using SGE.Telas;
using SGE.Telas.Cadastros;
using SGE.Telas.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE.TelasDF
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        public void tela(UserControl control)
        {
            if (pnlcentru.Controls.Count == 1)
                pnlcentru.Controls.RemoveAt(0);

            pnlcentru.Controls.Add(control);

        }
        

        private void empreSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresaConsulta frm = new frmEmpresaConsulta();
            tela(frm);
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlunoCadastro frm = new frmAlunoCadastro();
            tela(frm);            
        }

        private void candidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCandidatoCadastro frm = new frmCandidatoCadastro();
            tela(frm);
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresasCadastro frm = new frmEmpresasCadastro();
            tela(frm);
        }

        private void vagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVagasCadastro frm = new frmVagasCadastro();
            tela(frm);
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAlunoConsulta frm = new frmAlunoConsulta();
            tela(frm);
        }

        private void candidatoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCandidatoConsulta frm = new frmCandidatoConsulta();
            tela(frm);
        }

        private void vagasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVagasConsulta frm = new frmVagasConsulta();
            tela(frm);
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            tela(frm);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
