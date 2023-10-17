using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smartmoney.Models
{
    [Table("Transacoes")]
    public class Transacao
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data.")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a descrição.")]
        public string Descricao { get; set; }

        [Display(Name = "Tipo de Transacao")]
        public TipoTransacao Tipo { get; set; }
        
        public int CarteiraId { get; set; }

        [ForeignKey("CarteiraId")]
        public Carteira Carteira { get; set; }

        public int? CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }
    }

    public enum TipoTransacao
    {
        Receita,
        Despesa
    }

}
