using System;
using BlogApp.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}

