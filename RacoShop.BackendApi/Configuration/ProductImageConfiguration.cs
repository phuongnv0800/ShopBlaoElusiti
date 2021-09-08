using Microsoft.EntityFrameworkCore;
using RacoShop.BackendApi.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RacoShop.BackendApi.Configuration
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImages");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x=> x.Product).WithMany(g=> g.ProductImages).HasForeignKey(x=>x.ProductId);
        }

    }
}
