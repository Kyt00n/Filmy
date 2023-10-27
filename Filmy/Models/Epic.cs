using Filmy.Enums;

namespace Filmy.Models
{
    public class Epic
    {
        public int Id { get; set; }
        public string Tytul { get; set; }
        public string Opis { get; set; }
        public Status Status { get; set; }
        public string Zadania { get; set; }
        
    }
}
