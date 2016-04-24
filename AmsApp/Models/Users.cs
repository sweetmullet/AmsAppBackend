using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AmsApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        // public DateTime CreationDate { get; set; }
        public int RoleId { get; set; }
        //public decimal Price { get; set; }
    }

    public class AmsAppDBContext : DbContext
    {
       

        public DbSet<User> Users { get; set; }
        public DbSet<UserViews> UserViews { get; set; }
        public DbSet<Views> Views { get; set; }
        public DbSet<Abstracts> Abstract { get; set; }
        public DbSet<Operation> Operation { get; set; }
        

        public DbSet<AbstractCategory> AbstractCategories { get; set; }

        public DbSet<AbstractKeywords> AbstractKeywords { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<AssociatedAuthors> AssociatedAuthors { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<EventCategories> EventCategories { get; set; }

        public DbSet<Events> Events { get; set; }

        public DbSet<Keyword> Keywords { get; set; }

        public DbSet<Reviews> Reviews { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<RoleOperation> RoleOperations { get; set; }

        public DbSet<SubmissionType> SubmissionTypes { get; set; }
        public AmsAppDBContext()
            : base("AmsAppConn")
        {
        }

        public DbSet<Abstract> Abstracts { get; set; }

        
    }
}