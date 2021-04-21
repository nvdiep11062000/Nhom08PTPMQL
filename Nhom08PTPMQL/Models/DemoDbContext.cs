using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Nhom08PTPMQL.Models
{
    public partial class DemoDbContext : DbContext
    {
        public DemoDbContext()
            : base("name=DemoDbContext")
        {
        }

        public virtual DbSet<Describe> Describes { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Encrytion> Encrytions { get; set; }
        public virtual DbSet<Human> Humans { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
