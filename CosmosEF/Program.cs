using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosEF
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Getting started with Cosmos:");
            Console.WriteLine();

            #region HelloCosmos
            /*using (var context = new BlogContext())
            {
                await context.Database.EnsureCreatedAsync();
                context.Add(new Blog
                {
                    id = "1",
                    test = "first"
                });
                await context.SaveChangesAsync();
            }*/
            #endregion

            #region read data
            /*using (var context = new BlogContext())
            {
                var blog = await context.Blogs.FirstAsync();
                blog.owner = "steve";
                context.Update(blog);
                await context.SaveChangesAsync();
            }*/
            #endregion

            #region read data
            using (var context = new BlogContext())
            {
                var blog = await context.Blogs.FirstAsync();
                Console.WriteLine($"First order will ship to: {blog.id}, {blog.test},{blog.owner}");
                Console.WriteLine();
            }
            #endregion
        }
    }
}
