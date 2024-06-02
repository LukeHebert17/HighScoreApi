using Microsoft.EntityFrameworkCore;

namespace HighScoreApi.Models
{
    public class UserScoreContext : DbContext
    {
        public UserScoreContext(DbContextOptions<UserScoreContext> options)
            : base(options)
        {
            
        }

        public DbSet<UserScore> UserScores { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
    }
}
