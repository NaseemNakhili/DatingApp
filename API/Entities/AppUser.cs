

using Microsoft.AspNetCore.Authentication;

namespace API.Entities
{
    public class AppUser
    {

        public int Id { get; set; }
        public string userName { get; set; }
        public byte[] passwordHash { get; set; }
        public byte[] PasswordSalt { get; set; }


    }
}