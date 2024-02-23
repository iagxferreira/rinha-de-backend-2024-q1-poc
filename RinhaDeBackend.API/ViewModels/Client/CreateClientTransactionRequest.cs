namespace RinhaDeBackend.API.ViewModels.Client

{
    public class CreateClientTransactionRequest
    {
        public decimal Valor { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
    }
}
