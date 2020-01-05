using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartWatchShopFP.Models;

namespace SmartWatchShopFP.DAL
{
    public class WatchContext : IdentityDbContext<WatchUser>
    {
        public WatchContext(DbContextOptions<WatchContext> options) : base(options)
        {

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images{ get; set; }
        public DbSet<SmartFuture> SmartFutures { get; set; }
        public DbSet<BrandNewApp> BrandNewApps { get; set; }
        public DbSet<SomeFeature> SomeFeatures { get; set; }
        public DbSet<GloballyConnected> GloballyConnecteds { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Footer> Footers { get; set; }



    }
}
