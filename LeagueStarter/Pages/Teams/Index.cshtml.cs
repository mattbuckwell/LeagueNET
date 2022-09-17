using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using League.Data;
using League.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace League.Pages.Teams
{
    public class IndexModel : PageModel
    {
        // Injecting the EF context
        private readonly LeagueContext _context;

        public IndexModel(LeagueContext context)
        {
            _context = context;
        }

        // Load all teams, conferences and divisions
        public List<Conference> Conferences { get; set; }
        public List<Division> Divisions { get; set; }
        public List<Team> Teams { get; set; }

        // Allows storage of a favourite team
        [BindProperty(SupportsGet = true)]
        public string FavouriteTeam { get; set; }

        public SelectList AllTeams { get; set; }

        public async Task OnGetAsync()
        {
            // Load data from all 3 tables
            Conferences = await _context.Conferences.ToListAsync();
            Divisions = await _context.Divisions.ToListAsync();
            Teams = await _context.Teams.ToListAsync();

            // Make a list of teams for the favourite select dropdown
            IQueryable<string> teamQuery = from t in _context.Teams
                                           orderby t.TeamId
                                           select t.TeamId;

            AllTeams = new SelectList(await teamQuery.ToListAsync());

            // Manages the cookie if a favourite team is selected
            if (FavouriteTeam != null)
            {
                HttpContext.Session.SetString("_Favourite", FavouriteTeam);
            }
            else
            {
                FavouriteTeam = HttpContext.Session.GetString("_Favourite");
            }
        }

        // Get all Divisions from a Conference and sort them by Name
        public List<Division> GetConferenceDivisions(string ConferenceId)
        {
            return Divisions.Where(d => d.ConferenceId.Equals(ConferenceId)).OrderBy(d => d.Name).ToList();
        }

        // Get all Teams from a Division and sort them by Win
        public List<Team> GetDivisonTeams(string DivisionId)
        {
            return Teams.Where(t => t.DivisionId.Equals(DivisionId)).OrderByDescending(t => t.Win).ToList();
        }
    }
}
