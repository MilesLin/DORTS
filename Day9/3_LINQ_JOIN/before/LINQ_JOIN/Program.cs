using LINQ_JOIN.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace LINQ_JOIN
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 初始化 DB，如果初始化過了，則不會有任何效果
            InitDatabase();

            using (DBContext db = new DBContext())
            {
                db.Database.Log = s =>
                {
                    Console.WriteLine(s);
                };
                
                // 請練習 JOIN 的寫法

            }
        }

        private static void InitDatabase()
        {
            using (DBContext db = new DBContext())
            {
                if (!db.Role.Any())
                {
                    db.Role.Add(new Role { Name = "Manager" });
                    db.Role.Add(new Role { Name = "IT" });
                    db.Role.Add(new Role { Name = "Market" });
                    db.Role.Add(new Role { Name = "Sales" });

                    db.SaveChanges();

                    var role1 = db.Role.OrderBy(x => x.Id).FirstOrDefault();
                    var role2 = db.Role.OrderBy(x => x.Id).Skip(1).FirstOrDefault();
                    var role3 = db.Role.OrderBy(x => x.Id).Skip(2).FirstOrDefault();
                    var role4 = db.Role.OrderBy(x => x.Id).Skip(3).FirstOrDefault();
                    Enumerable.Range(1, 30).ToList().ForEach(x =>
                     {
                         int skip = x % 4;
                         var role = db.Role.OrderBy(y => y.Id).Skip(skip).FirstOrDefault();
                         db.Account.Add(new Account
                         {
                             Name = $"Test {x}",
                             Role = role
                         });

                         db.SaveChanges();
                     });
                }
            }
        }
    }
}