using BlazorApp3.Data;

namespace BlazorApp3.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService (ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
