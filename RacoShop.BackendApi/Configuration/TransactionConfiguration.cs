using Microsoft.EntityFrameworkCore;
using RacoShop.BackendApi.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RacoShop.BackendApi.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.AppUser)
                   .WithMany(x => x.Transactions)
                   .HasForeignKey(x => x.UserId);
            builder.Property(x => x.Amount).IsRequired().HasColumnType("decimal(18,4)");
            builder.Property(x => x.Fee).IsRequired().HasColumnType("decimal(18,2)");
        }

    }
}
