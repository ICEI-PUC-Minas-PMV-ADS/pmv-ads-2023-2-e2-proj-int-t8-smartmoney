using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace smartmoney.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}