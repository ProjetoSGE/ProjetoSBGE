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
    public partial class frmEmpresasCadastro : UserControl
    {
        public frmEmpresasCadastro()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SGEEntities db = new SGEEntities();


            tb_empresas tb = new tb_empresas();
            tb.nm_empresa = txtNomeFantasi.Text;
            tb.nm_razaoSocial = txtRazaoSocial.Text;
            tb.ds_cnpj = mtkCNPJ.Text;
            tb.ds_bairro = txtBairro.Text;
            tb.ds_cep = mktCep.Text;
            tb.ds_codigoEstadual =Convert.ToInt32(mktRegistroEstadual.Text);
            tb.ds_email = txtEmail.Text;
            tb.ds_endereco = txtEndereco.Text;
            tb.ds_pontoReferencial = txtPontoRef.Text;
            tb.nr_telefone = mktTelefone.Text ;
          


            db.tb_empresas.Add(tb);
            db.SaveChanges();
        }
    }
}
