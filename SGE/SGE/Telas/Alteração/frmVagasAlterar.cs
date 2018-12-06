using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE.Telas.Alteração
{
    public partial class frmVagasAlterar : UserControl
    {
        public frmVagasAlterar()
        {
            InitializeComponent();
        }

        public tb_vagas vaga;

        public void LoadScreen(tb_vagas vaga)
        {
             this.vaga = vaga;

            dtInicioEstagio.Text = vaga.dt_inicioEstagio.ToString();
            mtkInicio.Text = vaga.ds_horarioEntrada.ToString();
            mtkFim.Text = vaga.ds_horarioSaida.ToString();
            chkAutoCad.Checked = vaga.op_infoAutoCAD;
            chkPhotoshop.Checked = vaga.op_infoPhotoShop;
            chkProgramacao.Checked = vaga.op_infoProgramacao;
            chkPacoteOffice.Checked = vaga.op_infoOffice;
            chkCorelDraw.Checked = vaga.op_infoCorel;
            chkOutros.Checked = vaga.ds_outros;
            chkAuxilioTrasporte.Checked = vaga.op_auxTransporte;
            chkRecessoRemuneracao.Checked = vaga.op_recRemunerado;
            chkValeRef.Checked = vaga.op_valeRefeicao;
            chkSeguroVida.Checked = vaga.op_seguroDeVida;
            chkCestaBasica.Checked = vaga.op_cestaBasica;
            chkRefeitorioLocal.Checked = vaga.op_refLocal;
            txtNome.Text = vaga.nm_vaga;
            cboEmpresa.Text = vaga.id_empresa.ToString();
            nudQtd.Value = vaga.qtd_vaga;
            cboSexo.Text = vaga.ds_sexo;
            txtArea.Text = vaga.nm_area;
            txtTarefa.Text = vaga.ds_tarefas;
            txtObs.Text = vaga.ds_observacao;
            txtCompetecias.Text = vaga.ds_compPessoal;
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            vaga.dt_inicioEstagio = Convert.ToDateTime(dtInicioEstagio.Text);
            //vaga.ds_horarioEntrada = Convert.To(mtkInicio.Text);
            //vaga.ds_horarioSaida =Convert.ToDateTime(mtkFim.Text);
            //vaga.ds_intervalo = Convert.ToDateTime(mtkIntervalo.Text);

        }
    }
}
