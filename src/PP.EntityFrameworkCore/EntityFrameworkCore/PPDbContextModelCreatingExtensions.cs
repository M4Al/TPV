using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace PP.EntityFrameworkCore
{
    public static class PPDbContextModelCreatingExtensions
    {
        public static void ConfigurePP(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(PPConsts.DbTablePrefix + "YourEntities", PPConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}