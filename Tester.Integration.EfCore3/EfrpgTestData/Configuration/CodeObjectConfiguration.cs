// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore3
{
    // CodeObject
    public class CodeObjectConfiguration : IEntityTypeConfiguration<CodeObject>
    {
        public void Configure(EntityTypeBuilder<CodeObject> builder)
        {
            builder.ToTable("CodeObject", "dbo");
            builder.HasKey(x => x.CodeObjectNo).HasName("aaaaaObject_PK");

            builder.Property(x => x.CodeObjectNo).HasColumnName(@"codeObjectNo").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ApplicationNo).HasColumnName(@"applicationNo").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Type).HasColumnName(@"type").HasColumnType("int").IsRequired();
            builder.Property(x => x.EName).HasColumnName(@"eName").HasColumnType("nvarchar(250)").IsRequired().HasMaxLength(250);
            builder.Property(x => x.AName).HasColumnName(@"aName").HasColumnType("nvarchar(250)").IsRequired(false).HasMaxLength(250);
            builder.Property(x => x.Description).HasColumnName(@"description").HasColumnType("nvarchar(250)").IsRequired(false).HasMaxLength(250);
            builder.Property(x => x.CodeName).HasColumnName(@"codeName").HasColumnType("nvarchar(250)").IsRequired(false).HasMaxLength(250);
            builder.Property(x => x.Note).HasColumnName(@"note").HasColumnType("nvarchar(250)").IsRequired(false).HasMaxLength(250);
            builder.Property(x => x.IsObject).HasColumnName(@"isObject").HasColumnType("bit").IsRequired();
            builder.Property(x => x.VersionNumber).HasColumnName(@"versionNumber").HasColumnType("timestamp(8)").IsRequired(false).IsFixedLength().HasMaxLength(8).IsRowVersion().IsConcurrencyToken();
        }
    }

}
// </auto-generated>
