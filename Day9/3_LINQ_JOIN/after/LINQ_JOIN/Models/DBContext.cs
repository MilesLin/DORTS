using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_JOIN.Models
{
    public class DBContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<DBContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }
        public DBContext() : base("DBContext") { } //配置使用的连接名
        public DbSet<Account> Account { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}
