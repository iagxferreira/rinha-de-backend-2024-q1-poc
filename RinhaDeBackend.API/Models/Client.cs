using System.ComponentModel.DataAnnotations;

namespace RinhaDeBackend.API.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public decimal Limite { get; set; }
        public decimal SaldoInicial { get; set; }
    }
}
