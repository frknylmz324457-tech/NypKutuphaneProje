using System;

namespace KutuphaneYonetimSistemi1.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Publisher { get; set; } = string.Empty;
        public int PageCount { get; set; }     
        public bool IsAvailable { get; set; } = true;
        public int Year { get; set; }
        public int Stock { get; set; }
    }
}