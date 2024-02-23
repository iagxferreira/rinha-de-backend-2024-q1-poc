using System.ComponentModel.DataAnnotations;

namespace RinhaDeBackend.API.Models
{
    enum ETransactionType
    {

    }
    public class HandledTransaction
    {
        public decimal Valor { get; set; }
        public ETransactionType Tipo { get; set; }
        [StringLength(10, ErrorMessage = "Descrição nao deve ter mais que 10 caracteres")]
        public string Descricao { get; set; }

        public DateTime RealizadaEm { get; set; }
        
        public Client Client { get; set; }
    }
}
