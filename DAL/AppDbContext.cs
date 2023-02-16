using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base (options)
        {

        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Movement> Movements { get; set; }
        public DbSet<Instagram > Instagrams { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Ceramic> Ceramics { get; set; }
        public DbSet<Crafted> Crafteds { get; set; }
        public DbSet<ShippingMethod> ShippingMethods { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Support> Supports { get; set; }
        public DbSet<Featured> Featureds { get; set; }
        public DbSet<NeedSupport> NeedSupports { get; set; }
        public DbSet<WarrantyandService> WarrantyandServices { get; set; }
        public DbSet<TermandCondition> TermandConditions { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BCategory> BCategories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Contact> Contacts { get; set; }













    }

}
