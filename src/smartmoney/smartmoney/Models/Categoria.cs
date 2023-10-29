using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace smartmoney.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o título da categoria.")]
        [Display(Name = "Título da Categoria")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o tipo.")]
        [Display(Name = "Tipo de Categoria")]
        public TipoCategoria Tipo { get; set; }

        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Usuário")]
        public Usuario? Usuario { get; set; }
    }
    public enum TipoCategoria
    {
        Receita,
        Despesa
    }
}
