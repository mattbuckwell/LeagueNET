using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using League.Data;
using League.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace League.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly LeagueContext _context;

        public IndexModel (LeagueContext context)
        {
            _context = context;
        }

        public List<Player> Players { get; set; }

        public string FavouriteTeam { get; set; }
        public async Task OnGetAsync()
        {
            var players = from p in _context.Players
                          select p;

            // Store the favourite team from the cookie
            FavouriteTeam = HttpContext.Session.GetString("_Favourite");
            // Retrieve any players from the search, sort or filter options
            Players = await players.ToListAsync();
        }

        public string PlayerClass(Player Player)
        {
            string Class = "d-flex";
            if(Player.Depth == 1)
                Class += " starter";
            if (Player.TeamId == FavouriteTeam)
                Class += " favourite";
            return Class;
        }
    }
}
