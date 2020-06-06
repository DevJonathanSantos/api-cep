using System.ComponentModel.DataAnnotations;

namespace Teste.WebApi.ViewModels
{
    public class CepViewModel
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(8, ErrorMessage = "Este campo deve conter 8 caracteres")]
        [MinLength(8, ErrorMessage = "Este campo deve conter 8 caracteres")]
        public string Cep { get; set; }
    }
}
