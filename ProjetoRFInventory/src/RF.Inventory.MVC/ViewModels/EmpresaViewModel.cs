using System;
using System.ComponentModel.DataAnnotations;

namespace RF.Inventory.MVC.ViewModels
{
    public class EmpresaViewModel
    {
        [Key]
        public long EmpresaId { get; set; }

        [Required(ErrorMessage = "Preencha o Nome.")]
        [MinLength(2, ErrorMessage = "Mínimo de caracteres {0}")]
        [MaxLength(200, ErrorMessage = "Permitido apenas {0} caracteres.")]
        public string Nome { get; set; }

        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool UtilizarDIEF { get; set; }
    }
}