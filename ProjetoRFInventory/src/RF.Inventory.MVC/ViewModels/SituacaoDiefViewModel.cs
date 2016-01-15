using System.ComponentModel.DataAnnotations;

namespace RF.Inventory.MVC.ViewModels
{
    public class SituacaoDiefViewModel
    {
        [Key]
        public long SituacaoDiefId { get; set; }

        [Required(ErrorMessage = "Preencha o Nome")]
        [MinLength(2, ErrorMessage = "Mínimo de caracteres {0}")]
        [MaxLength(200, ErrorMessage = "Permitido apenas {0} caracteres.")]
        public string Nome { get; set; }
    }
}