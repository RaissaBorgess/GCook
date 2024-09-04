using System.ComponentModel.DataAnnotations;

namespace GCook.ViewModels;

    public class LoginVM
    {
        [Display(Name = "Email ou Nome de Usuário", Prompt = "Email ou Nome de Usuário")]
        [Required(ErrorMessage = "Por Favor, informe seu email ou nome de Usuário")]
        public string Email { get; set; }   

        [DataType(DataType.Password)]
        [Display(Name = "Email ou Nome de Usuário", Prompt = "Email ou Nome de Usuário")]
        [Required(ErrorMessage = "Por Favor, informe seu email ou nome de Usuário")]
        public string Senha { get; set; }   
        
        [Display(Name = "Manter Conectado?")]
        public bool Lembrar { get; set; } = false;
        public string UrlRetorno { get; set; }
    }
