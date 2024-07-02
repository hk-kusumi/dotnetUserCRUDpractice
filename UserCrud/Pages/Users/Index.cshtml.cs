using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UserCrud.Data;
using UserCrud.Model;

namespace UserCrud.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly UserCrud.Data.UserCrudContext _context;

        public IndexModel(UserCrud.Data.UserCrudContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
