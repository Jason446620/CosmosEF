using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosEF
{
    class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseCosmos(
                    "https://stevesqlapi.documents.azure.com:443/",
                    "ITRIaAzzXsSamTvbgZLbEhrkDf8VIpuef4X7HlI83wkFaBTcJTRJ6C1sWhUiMfA==",
                    databaseName: "Blog");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Container
            modelBuilder.Entity<Blog>()
                .ToContainer("Blogs");
            #endregion

            #region PartitionKey
            modelBuilder.Entity<Blog>()
                .HasPartitionKey(o => o.test);
            #endregion
        }
    }
}
