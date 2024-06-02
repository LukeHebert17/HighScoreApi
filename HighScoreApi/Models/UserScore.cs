using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HighScoreApi.Models
{
    /// <summary>
    /// Model for the standard score record
    /// </summary>
    public class UserScore
    {
        [Key]
        public int ScoreId { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public int Score { get; set; }

    }
}
