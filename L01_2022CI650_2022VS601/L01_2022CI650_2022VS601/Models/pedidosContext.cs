using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace L01_2022CI650_2022VS601.Models

{
    public class pedidosContext : DbContext
    {
        public pedidosContext(DbContextOptions<pedidosContext> options) : base(options) { }

        public DbSet<clientes> clientes { get; set; }
        public DbSet<pedidos> pedidos { get; set; }
        public DbSet<platos> platos { get; set; }
        public DbSet<motoristas> motoristas { get; set; }
    }
}
