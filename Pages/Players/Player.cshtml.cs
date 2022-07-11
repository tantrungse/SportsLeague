using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using League.Data;
using League.Models;
using System.Threading.Tasks;

namespace League.Pages.Players
{
    public class PlayerModel : PageModel
    {
        // Inject the Entity Framework context
        private readonly LeagueContext _context;

        public PlayerModel(LeagueContext context)
        {
            _context = context;
        }

        // load a single player based on Id
        public Player Player { get; set; }

        public async Task OnGetAsync(string Id)
        {
            Player = await _context.Players.FindAsync(Id);
        }
    }
}
