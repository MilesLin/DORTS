using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity2.Models
{
    public class DBContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<DBContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }
        
        public DBContext() : base("DBContextString")
        {
            
        } //配置使用的连接名
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Account> Account { get; set; }
    }
}
