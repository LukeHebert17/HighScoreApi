using System.ComponentModel.DataAnnotations;

namespace HighScoreApi.Models
{
    /// <summary>
    /// Model for user (player) information
    /// </summary>
    public class UserInfo
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; } = string.Empty;

        // TODO: Not a major priority, but adding a profile picture or something here would be a nice touch
    }
}
