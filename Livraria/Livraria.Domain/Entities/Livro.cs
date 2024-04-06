using Livraria.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Domain.Entities;

public sealed class Livro
{

    public int LivroId { get; set; }

    [Required(ErrorMessage ="Informe o título do livro")]
    [StringLength(150)]
    public string? Titulo { get; set; }

    [Required(ErrorMessage = "Informe o autor")]
    [StringLength(200)]
    public string? Autor { get; set; }

    [Required(ErrorMessage = "Informe a data de lançamento")]
    public DateTime Lancamento { get; set; }

    [Required(ErrorMessage = "Informe a imagem da capa")]
    [StringLength(200)]
    public string? Capa { get; set; }

    [Required]
    [EnumDataType(typeof(Editora), ErrorMessage = "Selecione a Editora")]
    public Editora Editora { get; set; }

    [Required]
    [EnumDataType(typeof(Categoria), ErrorMessage = "Selecione a Categoria")]
    public Categoria Categoria { get; set; }

    public Livro(int livroId, string? titulo, string? autor, DateTime lancamento, string? capa, Editora editora, Categoria categoria)
    {
        LivroId = livroId;
        Titulo = titulo;
        Autor = autor;
        Lancamento = lancamento;
        Capa = capa;
        Editora = editora;
        Categoria = categoria;
    }
}
