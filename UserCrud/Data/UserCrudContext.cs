using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserCrud.Model;

namespace UserCrud.Data
{
    public class UserCrudContext : DbContext
    {
        public UserCrudContext (DbContextOptions<UserCrudContext> options)
            : base(options)
        {
        }

        public DbSet<UserCrud.Model.User> User { get; set; } = default!;
    }
}
