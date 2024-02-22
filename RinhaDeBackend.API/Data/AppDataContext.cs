using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RinhaDeBackend.API.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }
    }
}
