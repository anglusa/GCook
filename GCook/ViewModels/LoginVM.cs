using System.ComponentModel.DataAnnotations;

namespace GCook.ViewModels;

public class LoginVM
{
    [Display(Name = "Email ou nome de usuário", Prompt = "Email ou nome de usuário")]
    [Required(ErrorMessage = "Por favor, informe seu email ou nome de usuário")]
    public string Email { get; set; }
    
    [Display(Name = "senha de acesso", Prompt = "********")]
    [Required(ErrorMessage = "Por favor, informe sua senha")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    [Display(Name = "Manter conectado?")]          
    public bool Lembrar { get; set; } = false;
    public string UrlRetorno { get; set; }
    
}
