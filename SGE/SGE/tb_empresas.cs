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
    
    public partial class tb_empresas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_empresas()
        {
            this.tb_vagas = new HashSet<tb_vagas>();
        }
    
        public int id_empresa { get; set; }
        public string nm_fantasia { get; set; }
        public string nm_razaoSocial { get; set; }
        public string ds_cnpj { get; set; }
        public Nullable<int> nr_codEstadual { get; set; }
        public string nr_telefone { get; set; }
        public string ds_email { get; set; }
        public string ds_cep { get; set; }
        public string ds_bairro { get; set; }
        public string ds_endereco { get; set; }
        public string ds_pontoReferencia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_vagas> tb_vagas { get; set; }
    }
}
