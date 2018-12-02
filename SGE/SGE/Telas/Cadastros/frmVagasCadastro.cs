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
    public partial class frmVagasCadastro : UserControl
    {
        SGEEntities db = new SGEEntities();
        public frmVagasCadastro()
        {
            InitializeComponent();
            CarregarCombos();
        }
        void CarregarCombos()
        {
            List<tb_empresas> lista = db.tb_empresas.ToList();

            cboEmpresa.DisplayMember = nameof(tb_empresas.nm_fantasia);
            cboEmpresa.ValueMember = nameof(tb_empresas.id_empresa);
            cboEmpresa.DataSource = lista;
        }


        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
 
            tb_vagas vagas = new tb_vagas();

            tb_empresas dto2 = cboEmpresa.SelectedItem as tb_empresas;
            vagas.id_empresa = dto2.id_empresa;

            vagas.dt_inicioEstagio = dtInicioEstagio.Value;
            vagas.ds_horarioEntrada = Convert.ToDateTime(mtkInicio.Text);
            vagas.ds_horarioSaida = Convert.ToDateTime(mtkFim.Text);
            vagas.ds_intervalo = Convert.ToDateTime(mtkIntervalo.Text);
            vagas.op_infoAutoCAD = chkAutoCad.Checked;
            vagas.op_infoPhotoShop = chkPhotoshop.Checked;
            vagas.op_infoProgramacao = chkProgramacao.Checked;
            vagas.op_infoOffice = chkPacoteOffice.Checked;
            vagas.op_infoCorel = chkCorelDraw.Checked;
            vagas.ds_outros = Convert.ToString(chkOutros.Checked);
            vagas.op_auxTransporte = chkAuxilioTrasporte.Checked;
            vagas.op_recRemunerado = chkRecessoRemuneracao.Checked;
            vagas.op_valeRefeicao = chkValeRef.Checked;
            vagas.op_seguroDeVida = chkSeguroVida.Checked;
            vagas.op_cestaBasica = chkCestaBasica.Checked;
            vagas.op_refLocal = chkRefeitorioLocal.Checked;
            vagas.nm_vaga = txtNome.Text;
            vagas.qtd_vaga = Convert.ToInt32(nudQtd.Value);
            vagas.ds_sexo = cboSexo.Text;
            vagas.nm_area = txtArea.Text;
            vagas.ds_tarefas = txtCompetecias.Text;
            vagas.ds_observacao = txtObs.Text;
            vagas.ds_compPessoal = txtTarefa.Text;

            db.tb_vagas.Add(db);
            db.SaveChanges();

        }
    }
}
