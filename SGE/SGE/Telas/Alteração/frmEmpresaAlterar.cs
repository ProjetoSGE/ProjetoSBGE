using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE.Telas.Alteração
{
    public partial class frmEmpresaAlterar : Form
    {
        public frmEmpresaAlterar()
        {
            InitializeComponent();
        }
        public tb_empresas empresa;

        public void LoadScreen(tb_empresas emp)
        {
            this.empresa = emp;

            mktCNPJ.Text = emp.ds_cnpj;
            txtNomeFantasi.Text = emp.nm_fantasia;
            txtRazaoSocial.Text = emp.nm_razaoSocial;
            txt
            

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
