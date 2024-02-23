namespace RinhaDeBackend.API.ViewModels.Client
{
    public class ClientReportResponse
    {
        public ReportTransactionAmount Saldo { get; set; }
        public List<TransactionReport> UltimasTransacoes { get; set; }
    }

    public class TransactionReport
    {
        public decimal Valor { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime RealizadaEm { get; set; }
    }

    public class ReportTransactionAmount
    {
        public decimal Total { get; set; }
        public DateTime DataExtrato { get; set; }
        public decimal Limite { get; set; }
    }
}
