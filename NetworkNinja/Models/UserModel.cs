using System;

namespace NetworkNinja.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Rank { get; set; }
        public DateTime Joined { get; set; }
        public string WorkSection { get; set; }
        public bool IsAdmin { get; set; }

    }
}
