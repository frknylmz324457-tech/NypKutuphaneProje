using System;

namespace KutuphaneYonetimSistemi1.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty; 
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty; 
        public DateTime RegisterDate { get; set; } = DateTime.Now;
    }
}