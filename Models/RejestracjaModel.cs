using System.ComponentModel.DataAnnotations;

namespace Rejestracja.Models
{
    public class RejestracjaModel
    {
        [Required(ErrorMessage = "Imię jest wymagane.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki.")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki.")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Adres e-mail jest wymagany.")]
        [EmailAddress(ErrorMessage = "Niepoprawny format adresu e-mail.")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Niepoprawny format adresu e-mail.")]
        public string Email { get; set; }


        [Display(Name = "Hasło")]
        [Required(ErrorMessage = "Hasło jest wymagane.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków.")]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).*$", ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną dużą i jedną małą literę.")]
        public string Haslo { get; set; }

        [Display(Name = "Potwierdzenie Hasła")]
        [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane.")]
        [Compare("Haslo", ErrorMessage = "Hasła muszą się zgadzać.")]
        public string PotwierdzenieHasla { get; set; }

        [Display(Name = "Numer telefonu")]
        [Required(ErrorMessage = "Numer telefonu jest wymagany.")]
        [Phone(ErrorMessage = "Niepoprawny numer telefonu.")]
        [RegularExpression(@"^(\+48)?[0-9]{9}$", ErrorMessage = "Numer telefonu musi być w formacie: 123456789 lub +48 123 456 789.")]
        public string NrTelefonu { get; set; }

        [Required(ErrorMessage = "Wiek jest wymagany.")]
        [Range(11, 80, ErrorMessage = "Wiek musi być w zakresie 11-80 lat.")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Wybierz miasto.")]
        public Kategorie Miasto { get; set; }

        public enum Kategorie { Warszawa, Kraków, Wrocław, Gdańsk, Poznań }
    }
}