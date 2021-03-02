using PP.Attractions;
using PP.RideRestrictions;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace PP.EntityFrameworkCore
{
    public static class PPDbContextModelCreatingExtensions
    {
        public static void ConfigurePP(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Attraction>(b =>
            {
                b.ToTable(PPConsts.DbTablePrefix + "Attractions", PPConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
                b.HasMany(p => p.RideRestrictions).WithMany(p => p.Attractions);
            });

            builder.Entity<RideRestriction>(b =>
            {
                b.ToTable(PPConsts.DbTablePrefix + "RideRestrictions",
                    PPConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
                b.HasMany(p => p.Attractions).WithMany(p => p.RideRestrictions);
            });
        }
    }
}