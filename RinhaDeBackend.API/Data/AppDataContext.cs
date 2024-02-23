using Microsoft.EntityFrameworkCore;
using RinhaDeBackend.API.Models;
using System.Transactions;

namespace RinhaDeBackend.API.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }
        public DbSet<Transaction> transactions { get; set; }
        public DbSet<Client> clients { get; set; }
    }
}
