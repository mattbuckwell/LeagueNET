using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using League.Data;
using League.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace League.Pages.Players
{
    public class IndexModel : PageModel
    {
        // Injecting the EF context
        private readonly LeagueContext _context;

        public IndexModel (LeagueContext context)
        {
            _context = context;
        }
        
        // Property to hold a list of players
        public List<Player> Players { get; set; }

        // Properties for the filter and search form
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Teams { get; set; }
        public SelectList Positions { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SelectedTeam { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SelectedPosition { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortField { get; set; } = "Name";

        // Property to read in the favourite team from cookie
        public string FavouriteTeam { get; set; }

        // OnGetAsyc method
        public async Task OnGetAsync()
        {
            // Base query to retieve all players
            var players = from p in _context.Players
                          select p;

            // Alter the query if the user is searching for a player
            if(!string.IsNullOrEmpty(SearchString))
            {
                players = players.Where(p => p.Name.Contains(SearchString));
            }

            // Alter the query if the user is filtering players by a particular team
            if(!string.IsNullOrEmpty(SelectedTeam))
            {
                players = players.Where(p => p.TeamId == SelectedTeam);
            }

            // Alter the query if the user is filtering players by position
            if(!string.IsNullOrEmpty(SelectedPosition))
            {
                players = players.Where(p => p.Position == SelectedPosition);
            }

            // Alter the query if the user it sorting the players
            switch (SortField)
            {
                case "Number":
                    players = players.OrderBy(p => p.Number).ThenBy(p => p.TeamId);
                    break;
                case "Name":
                    players = players.OrderBy(p => p.Name).ThenBy(p => p.TeamId);
                    break;
                case "Position":
                    players = players.OrderBy(p => p.Position).ThenBy(p => p.TeamId);
                    break;
            }

            // Create two lists for the filter drop down
            IQueryable<string> teamQuery = from t in _context.Teams
                                           orderby t.TeamId
                                           select t.TeamId;

            Teams = new SelectList(await teamQuery.ToListAsync());

            IQueryable<string> positionQuery = from p in _context.Players
                                               orderby p.Position
                                               select p.Position;

            Positions = new SelectList(await positionQuery.Distinct().ToListAsync());

            // Store the favourite team from the cookie
            FavouriteTeam = HttpContext.Session.GetString("_Favourite");

            // Retrieve any players from the search, sort or filter options
            Players = await players.ToListAsync();
        }

        // Return a string for the <a> class, Bold if the player is a starter and/or Gold background if the player is in the users favourite team.
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
