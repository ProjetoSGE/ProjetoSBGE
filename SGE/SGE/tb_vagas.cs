//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGE
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_vagas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_vagas()
        {
            this.tb_candidato = new HashSet<tb_candidato>();
        }
    
        public int id_vaga { get; set; }
        public string nm_vaga { get; set; }
        public string nm_area { get; set; }
        public int qtd_vaga { get; set; }
        public System.DateTime dt_inicioEstagio { get; set; }
        public string ds_sexo { get; set; }
        public int id_empresa { get; set; }
        public System.TimeSpan ds_horario { get; set; }
        public System.TimeSpan ds_intervalo { get; set; }
        public bool op_seguroDeVida { get; set; }
        public bool op_auxTransporte { get; set; }
        public bool op_recRemunerado { get; set; }
        public bool op_valeRefeicao { get; set; }
        public bool op_cestaBasica { get; set; }
        public bool op_refLocal { get; set; }
        public bool op_assisMedica { get; set; }
        public string nvl_ingles { get; set; }
        public bool op_infoOffice { get; set; }
        public bool op_infoAutoCAD { get; set; }
        public bool op_infoCorel { get; set; }
        public bool op_infoPhotoShop { get; set; }
        public bool op_infoProgramacao { get; set; }
        public string op_outros { get; set; }
        public string ds_observacao { get; set; }
        public string ds_compPessoal { get; set; }
        public string ds_tarefas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_candidato> tb_candidato { get; set; }
        public virtual tb_empresas tb_empresas { get; set; }
    }
}
