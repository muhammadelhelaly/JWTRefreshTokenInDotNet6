using System.ComponentModel.DataAnnotations;

namespace JWTRefreshTokenInDotNet6.Models
{
    public class TokenRequestModel
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}