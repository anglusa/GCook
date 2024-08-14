using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCook.Models;

[Table("Comentario")]
public class Comentario
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int ReceitaId { get; set; }

    [ForeignKey("ReceitaId")]
    public Receita Receita { get; set; }

    [Required]
    public string UsuarioId { get; set; }

    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    public DateTime DataComentario { get; set; }

    [StringLength(300)]
    public string TextoComentario { get; set; }

    
    
}
