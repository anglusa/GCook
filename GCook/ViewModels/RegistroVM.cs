using System.ComponentModel.DataAnnotations;

namespace GCook.ViewModels;

    public class RegistroVM
    {
        [Display(Name = "Nome Completo", Prompt ="Informe seu Nome Completo")]
        [Required(ErrorMessage = "Por favor, informe seu Nome")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Data de Nascimento", Prompt ="Informe seu Data de Nascimento")]
        [Required(ErrorMessage = "Por favor, informe sua Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime? DataNascimento { get; set; } = null;

        [Display(Name = "Nome Completo", Prompt ="Informe seu Nome Completo")]
        [Required(ErrorMessage = "Por favor, informe seu Nome")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Nome Completo", Prompt ="Informe seu Nome Completo")]
        [Required(ErrorMessage = "Por favor, informe seu Nome")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Nome Completo", Prompt ="Informe seu Nome Completo")]
        [Required(ErrorMessage = "Por favor, informe seu Nome")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
        public string Nome { get; set; }

        public IFormFile Foto { get; set; }

        public bool Termos { get; set; } = false;

        public bool Enviado { get; set; } = false;
    }
