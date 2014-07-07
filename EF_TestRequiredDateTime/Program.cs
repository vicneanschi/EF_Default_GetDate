using System;
using System.Data.Entity;
using System.Linq;
using EF_TestRequiredDateTime.Migrations;

namespace EF_TestRequiredDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyContext, Configuration>()); 


            using (var db = new MyContext())
            {
                db.Users.Add(new User());
                var user = db.Users.First(u => u.Id == 1);
                user.CreatedAt = new DateTime(2000, 1, 1);
                db.SaveChanges();
            }
        }
    }
}
