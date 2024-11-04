using System.ComponentModel.DataAnnotations;

namespace PetApi.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("cadastro")]
    public class Pet
    {
        [Key]
        public int Id { get; set; }
        public string NomePet { get; set; }
        public string NomeResp { get; set; }
        public string Telefone { get; set; }
    }
}
