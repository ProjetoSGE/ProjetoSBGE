using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SGEEntities db = new SGEEntities();

            tb_empresas tb = new tb_empresas();
            tb.nm_empresa = txtnomefan.Text;
            tb.nm_razaoSocial = txtrazao.Text;
            tb.ds_cnpj = txtcnpj.Text;
            tb.ds_bairro = txtBairro.Text;
            tb.ds_cep = mktCep.Text;
            tb.ds_codigoEstadual = null;
            tb.ds_email = txtEmail.Text;
            tb.ds_endereco = txtEndereco.Text;
            tb.ds_pontoReferencial = txtPontoRef.Text;
            tb.nr_telefone = null;
            tb.tb_vagas = null;
           

            db.tb_empresas.Add(tb);
            db.SaveChanges();


        }
    }
}
