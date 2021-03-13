using Microsoft.EntityFrameworkCore;
using Manager.Infra.Mappings;
using Manager.Domain.Entities;

namespace Manager.Infra.Context
{
    public class ManagerContext : DbContext
    {
        public ManagerContext(){}

        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options){}

        public virtual DbSet<User> Users { get; set; } //tabela no banco

        protected override void OnModelCreating(ModelBuilder builder){
            builder.ApplyConfiguration(new UserMap()); //classe modelada para o banco de usuario
        }
    }
}