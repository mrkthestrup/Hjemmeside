using System;
using System.ComponentModel.DataAnnotations;

namespace hjemmeside2.Models.Entities
{

    public class Booking
    {
        public int ID { get; set; }

        [Display(Name = "Navn: ")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Du skal starte med stort")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Efternavn: ")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email: ")]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Telefonnummer skal indeholde 8 tal")]      
        [Display(Name = "Mobil nummer: ")]
        [Required]
        public int PhoneNumber { get; set; }

        [Display(Name = "Dato: ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeny { get; set; }
        
        [Display(Name = "Tidspunkt: ")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Tidspunkt {get; set;}

    
        [Display(Name = "Kommentar: ")]
        public string Comments { get; set; }
        
    }
}