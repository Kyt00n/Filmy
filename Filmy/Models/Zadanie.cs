using Filmy.Enums;

namespace Filmy.Models
{
    public class Zadanie
    {
        public int Id { get; set; }
        public string Tytul { get; set; }
        public string Opis { get; set; }
        public string Przypisani { get; set; }
        public StoryPoints Punkty { get; set; }
    }
}
