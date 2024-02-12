using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRoles.Data
{
    public class UserDbContextInitializer : SqliteDropCreateDatabaseAlways<UsersDbContext>
    {
        public UserDbContextInitializer(DbModelBuilder modelBuilder)
        : base(modelBuilder) { }

        protected override void Seed(UsersDbContext context)
        {
        }
    }
}
