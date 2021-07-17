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
    public class MovieReviewsController : ControllerBase
    {
        private readonly AppDbContext _db;
        private readonly JwtService _jwtService;

        public MovieReviewsController(AppDbContext context, JwtService jwtService)
        {
            _db = context;
            _jwtService = jwtService;
        }

        // GET: api/MovieReviews
        [HttpGet]
        public ActionResult<IEnumerable<MovieReview>> GetMovieReview()
        {
            return BadRequest();
        }

        // GET: api/MovieReviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieReview>> GetMovieReview(int id)
        {
            var movieReview = await _db.MovieReview.FindAsync(id);

            if (movieReview == null)
            {
                return NotFound();
            }

            return movieReview;
        }

        // PUT: api/MovieReviews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovieReview(int id, MovieReview movieReview)
        {
            if (id != movieReview.Id)
            {
                return BadRequest();
            }

            _db.Entry(movieReview).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieReviewExists(id))
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

        // POST: api/MovieReviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MovieReview>> PostMovieReview(MovieReview movieReview)
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

                var movieInDatabase = await _db.Movies.SingleOrDefaultAsync(m => m.Id == movieReview.MovieId);
                if (movieInDatabase == null)
                {
                    return BadRequest(new
                    {
                        message = "The Movie does not Exist in Database"
                    });
                }
            
                movieReview.ProfileId = profile.Id;
                // movieReview.ProfileId = profile.Id;
                
                _db.MovieReview.Add(movieReview);
                await _db.SaveChangesAsync();

                return CreatedAtAction("GetMovieReview", new { id = movieReview.Id }, movieReview);
            }
            catch (Exception e)
            {
                return Unauthorized();
            }
        }

        // DELETE: api/MovieReviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovieReview(int id)
        {
            var movieReview = await _db.MovieReview.FindAsync(id);
            if (movieReview == null)
            {
                return NotFound();
            }

            _db.MovieReview.Remove(movieReview);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieReviewExists(int id)
        {
            return _db.MovieReview.Any(e => e.Id == id);
        }
    }
}
