using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using League.Data;
using League.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace League.Pages.Teams
{
    public class TeamModel : PageModel
    {
        // Injecting the EF context
        private readonly LeagueContext _context;

        public TeamModel(LeagueContext context)
        {
            _context = context;
        }

        // Load in a single team and include all the players and divisions
        public Team Team { get; set; }

        public async Task OnGetAsync(string Id)
        {
            Team = await _context.Teams
                .Include(t => t.Players)
                .Include(t => t.Division)
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.TeamId == Id);
        }
    }
}
