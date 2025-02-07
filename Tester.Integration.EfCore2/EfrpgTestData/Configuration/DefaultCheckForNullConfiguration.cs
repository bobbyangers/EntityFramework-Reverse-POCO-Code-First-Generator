// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // DefaultCheckForNull
    public class DefaultCheckForNullConfiguration : IEntityTypeConfiguration<DefaultCheckForNull>
    {
        public void Configure(EntityTypeBuilder<DefaultCheckForNull> builder)
        {
            builder.ToTable("DefaultCheckForNull", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_DefaultCheckForNull").ForSqlServerIsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseSqlServerIdentityColumn();
            builder.Property(x => x.DescUppercase).HasColumnName(@"DescUppercase").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.DescLowercase).HasColumnName(@"DescLowercase").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.DescMixedCase).HasColumnName(@"DescMixedCase").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.DescBrackets).HasColumnName(@"DescBrackets").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.X1).HasColumnName(@"X1").HasColumnType("varchar(255)").IsRequired(false).IsUnicode(false).HasMaxLength(255);
        }
    }

}
// </auto-generated>
