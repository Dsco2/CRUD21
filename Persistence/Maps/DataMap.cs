using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps
{
    public class DataMap: IEntityTypeConfiguration<Data>
    {
        public void Configure(EntityTypeBuilder<Data> builder)
        {
            builder.ToTable("Data");
            builder.HasKey(x => x.IdData);
        }
    }
}