using HighScoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HighScoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserScoresController : ControllerBase
    {
        private readonly UserScoreContext _userScoreContext;

        public UserScoresController(UserScoreContext userScoreContext)
        {
            _userScoreContext = userScoreContext;
        }

        #region GET methods
        /// <summary>
        /// Basic retrieval of all scores
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserScore>>> GetUserScores()
        {
            // TODO: Fine for now just doing a select all type statement but future refinement should include a more sophisticated get
            if (_userScoreContext.UserScores == null)
            {
                return NotFound();
            }

            return await _userScoreContext.UserScores.ToListAsync();
        }

        /// <summary>
        /// Retrieves all scores for a certain user
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns>List of items satisfying the query parameters</returns>
        [HttpGet("{UserId}")]
        public async Task<ActionResult<IEnumerable<UserScore>>> GetUserScoresByUserId(int UserId)
        {
            if (_userScoreContext.UserScores == null)
            {
                return NotFound();
            }

            var userScores = await _userScoreContext.UserScores
                            .Where( userScore => userScore.UserId == UserId).ToListAsync();

            if (userScores == null) 
            {
                return NotFound();
            }

            return userScores;
        }

        #endregion

        #region POST methods

        [HttpPost]
        public async Task<ActionResult<UserScore>> PostUserScore(UserScore userScore)
        {
            _userScoreContext.Add(userScore);
            await _userScoreContext.SaveChangesAsync();

            return CreatedAtAction(nameof(PostUserScore), new { userId = userScore.UserId }, userScore);
        }

        #endregion


    }
}
