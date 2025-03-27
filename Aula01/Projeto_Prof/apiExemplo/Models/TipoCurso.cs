using System.ComponentModel.DataAnnotations;

public class TipoCurso
{
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo nome é obrigatório")]
    [MinLength(3, ErrorMessage = "O nome deve ter, ao mínimo, 3 letras")]
    [MaxLength(100)]
    public string Nome { get; set; }

    [Required]
    [MinLength(5)]
    [MaxLength(100, ErrorMessage = "Utilize no máximo 100 letras")]
    public string Descricao { get; set; }
}