using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Helpers;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvShowReviewsController : ControllerBase
    {
        private readonly AppDbContext _db;
        private readonly JwtService _jwtService;

        public TvShowReviewsController(AppDbContext context, JwtService jwtService)
        {
            _db = context;
            _jwtService = jwtService;
        }

        // GET: api/TvShowReviews
        [HttpGet]
        public ActionResult<IEnumerable<TvShowReview>> GetTvShowReview()
        {
            return BadRequest();
        }

        // GET: api/TvShowReviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TvShowReview>> GetTvShowReview(int id)
        {
            var tvShowReview = await _db.TvShowReview.FindAsync(id);

            if (tvShowReview == null)
            {
                return NotFound();
            }

            return tvShowReview;
        }

        // PUT: api/TvShowReviews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTvShowReview(int id, TvShowReview tvShowReview)
        {
            if (id != tvShowReview.Id)
            {
                return BadRequest();
            }

            _db.Entry(tvShowReview).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TvShowReviewExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TvShowReviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TvShowReview>> PostTvShowReview(TvShowReview tvShowReview)
        {
            try
            {
                var jwt = Request.Cookies["jwt"];

                var token = _jwtService.Verify(jwt);

                int userId = int.Parse(token.Issuer);


                var profile = await _db.Profiles.FirstOrDefaultAsync(p => p.UserId == userId);

                if (profile == null)
                {
                    return Unauthorized();
                }
                var tvShowsInDatabase = await _db.TvShows.SingleOrDefaultAsync(m => m.Id == tvShowReview.TvShowId);
                if (tvShowsInDatabase == null)
                {
                    return BadRequest(new
                    {
                        message = "The TV Show does not Exist in Database"
                    });
                }
                tvShowReview.ProfileId = profile.Id;
                
                _db.TvShowReview.Add(tvShowReview);
                await _db.SaveChangesAsync();

                return CreatedAtAction("GetTvShowReview", new { id = tvShowReview.Id }, tvShowReview);
            }
            catch (Exception e)
            {
                return Unauthorized();
            }
        }

        // DELETE: api/TvShowReviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTvShowReview(int id)
        {
            var tvShowReview = await _db.TvShowReview.FindAsync(id);
            if (tvShowReview == null)
            {
                return NotFound();
            }

            _db.TvShowReview.Remove(tvShowReview);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool TvShowReviewExists(int id)
        {
            return _db.TvShowReview.Any(e => e.Id == id);
        }
    }
}
