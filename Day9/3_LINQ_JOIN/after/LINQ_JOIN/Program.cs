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

            // 有 FK 的寫法
            using (DBContext db = new DBContext())
            {
                db.Database.Log = s =>
                {
                    Console.WriteLine(s);
                };

                var role = db.Role.Include(x => x.Account).ToList();
                //var role = db.Role.Include("Account").ToList();

            }

            /* ------------------------------------------------------------------ */

            // 沒有 FK 的寫法
            using (DBContext db = new DBContext())
            {
                db.Database.Log = s =>
                {
                    Console.WriteLine(s);
                };

                #region INNER JOIN

                // INNER JOIN
                var data = db.Role
                    .Join(
                        db.Account,
                        role => role.Id,
                        acct => acct.RoleId,
                        (role, acct) => new
                        {
                            RoleName = role.Name,
                            AcctName = acct.Name
                        }).ToList();

                foreach (var item in data)
                {
                    Console.WriteLine(item.RoleName + ":" + item.AcctName);
                }

                // Query Syntax
                var innerJoin = from r in db.Role
                                join a in db.Account
                                on r.Id equals a.RoleId
                                select new
                                {
                                    RoleName = r.Name,
                                    AcctName = a.Name
                                };

                var innerResult = innerJoin.ToList();

                foreach (var item in innerResult)
                {
                    Console.WriteLine(item.RoleName + ":" + item.AcctName);
                }

                #endregion INNER JOIN

                #region LEFT JOIN

                // Method syntax
                var data2 = db.Role
                        .GroupJoin(
                            db.Account,
                            role => role.Id,
                            acct => acct.RoleId,
                            (role, acct) => new
                            {
                                RoleName = role.Name,
                                acct = acct
                            })
                            .SelectMany(
                            x => x.acct.DefaultIfEmpty(),
                            (role, acct) => new
                            {
                                RoleName = role.RoleName,
                                AcctName = acct.Name
                            })
                            .ToList();

                foreach (var item in data2)
                {
                    Console.WriteLine(item.RoleName + ":" + item.AcctName);
                }

                // Query Syntax
                var groupJoin = from r in db.Role
                                join a in db.Account
                                on r.Id equals a.RoleId
                                into ac
                                select new
                                {
                                    RoleName = r.Name,
                                    Acct = ac
                                };

                var groupJoinResult = groupJoin.ToList();

                foreach (var item in groupJoinResult)
                {
                    Console.WriteLine(item.RoleName);
                    foreach (var acct in item.Acct)
                    {
                        Console.WriteLine(acct.Name);
                    }
                }

                #endregion LEFT JOIN
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