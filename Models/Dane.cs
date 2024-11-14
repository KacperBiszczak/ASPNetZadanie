using System.ComponentModel.DataAnnotations;

namespace ASPNetZadanie.Models
{
    public class Dane
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Prosze podaj Imie")]
        [MinLength(2), MaxLength(50)]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        [MinLength(2), MaxLength(50)]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prosze podaj Haslo")]
        [MinLength(8, ErrorMessage = "Haslo musi miec co najmniej 8 znakow.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).+$",
            ErrorMessage = "Haslo musi zawierac co najmniej jedna wielka litere, jedna mała litere i jedna cyfre.")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Potwierdz haslo")]
        [Compare("Haslo", ErrorMessage = "Hasla musza byc takie same")]
        public string PotwierdzenieHasla { get; set; }

        [Phone(ErrorMessage = "Wprowadz poprawny numer telefonu.")]
        public string NrTelefonu { get; set; }

        [Range(10, 80, ErrorMessage = "Wiek musi byc miedzy 10 a 80 lat.")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Miasto jest wymagane.")]
        public string Miasto { get; set; }
        
        public enum Miasta { Szczecin = 1, Krakow = 2, Wroclaw = 3, Warszawa = 4, Kielce = 5 }
    }
}
