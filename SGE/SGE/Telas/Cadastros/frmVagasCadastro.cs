﻿using System;
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
            chkOutros.Visible = false;
            txtoutros.Visible = true;
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            var time = TimeSpan.Parse(mtkInicio.Text);
            var time1 = TimeSpan.Parse(mtkInicio.Text);
            var time2 = TimeSpan.Parse(mtkInicio.Text);
            tb_vagas vagas = new tb_vagas();

            tb_empresas dto2 = cboEmpresa.SelectedItem as tb_empresas;
            vagas.id_empresa = dto2.id_empresa;

            vagas.dt_inicioEstagio = dtInicioEstagio.Value;
            vagas.ds_horarioEntrada = time;
            vagas.ds_horarioSaida = time1;
            vagas.ds_intervalo = time2;
            vagas.op_infoAutoCAD = chkAutoCad.Checked;
            vagas.op_infoPhotoShop = chkPhotoshop.Checked;
            vagas.op_infoProgramacao = chkProgramacao.Checked;
            vagas.op_infoOffice = chkPacoteOffice.Checked;
            vagas.op_infoCorel = chkCorelDraw.Checked;
            vagas.ds_outros = txtoutros.Text;
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
            vagas.nvl_ingles = textBox1.Text;

            db.tb_vagas.Add(vagas);
            db.SaveChanges();

        }

        private void frmVagasCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
