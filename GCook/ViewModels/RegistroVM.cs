using System.ComponentModel.DataAnnotations;

namespace GCook.ViewModels;

    public class RegistroVM
    {
        [Display(Name = "Nome Completo", Prompt ="Informe seu Nome Completo")]
        [Required(ErrorMessage = "Por favor, informe seu Nome")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Data de Nascimento", Prompt ="Informe sua Data de Nascimento")]
        [Required(ErrorMessage = "Por favor, informe sua Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime? DataNascimento { get; set; } = null;

        [Display(Prompt = "informe seu email")]
        [Required(ErrorMessage = "Por favor, informe seu email")]
        [EmailAddress(ErrorMessage = "Por favor, informe um email válido")]
        [StringLength(100, ErrorMessage = "O email deve possuir no máximo 100 caracteres")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Senha de acesso", Prompt ="Informe uma senha para acesso")]
        [Required(ErrorMessage = "Por favor, informe sua senha de acesso")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "A senha deve possuir no minimo 6 e no maximo 20 caracteres")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha de acesso", Prompt ="Confirme sua senha de acesso")]
        [Compare("Senha", ErrorMessage = "As senhas não conferem")]
        public string ConfirmacaoSenha { get; set; }

        public IFormFile Foto { get; set; }

        public bool Termos { get; set; } = false;

        public bool Enviado { get; set; } = false;
    }
