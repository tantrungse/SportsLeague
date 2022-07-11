using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using League.Data;

namespace League.Pages
{
  public class IndexModel : PageModel
  {
    private readonly LeagueContext _context;

    public IndexModel(LeagueContext context)
    {
      _context = context;
    }

    public League.Models.League League { get; set; }

    public async Task OnGetAsync()
    {
      League = await _context.Leagues.FirstOrDefaultAsync();
    }
  }
}
