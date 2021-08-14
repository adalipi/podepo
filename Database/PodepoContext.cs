using System;
using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Database
{
    public partial class PodepoContext : DbContext
    {
        public PodepoContext(DbContextOptions<PodepoContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Amount> Amounts { get; set; }
        public DbSet<ArticleAmount> ArticleAmounts { get; set; }
        public DbSet<Table> Tables { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ArticleAmount>().HasKey(a => new { a.Article_Id, a.Amount_Id });

            builder.Entity<Amount>().HasIndex(u => u.OrderValue).IsUnique();
            builder.Entity<Amount>().HasMany(a => a.Articles).WithOne(o => o.Amount).HasForeignKey(f => f.Amount_Id);
            
            builder.Entity<Article>().HasMany(a => a.Amounts).WithOne(o => o.Article).HasForeignKey(f => f.Article_Id);
        }

    }
}
