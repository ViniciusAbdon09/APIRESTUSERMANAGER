using Microsoft.EntityFrameworkCore;
using Manager.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Manager.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {   
            //forma como vai ser configurado no banco da entidade no domain para a table no banco
            builder.ToTable("User");

            builder.HasKey(x => x.Id); 

            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .HasColumnType("BIGINT");
                
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("name")
                .HasColumnType("VARCHAR(80)");

             builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(180)
                .HasColumnName("email")
                .HasColumnType("VARCHAR(180)");

             builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("password")
                .HasColumnType("VARCHAR(30)");
        }
    } 
}