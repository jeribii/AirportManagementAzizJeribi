using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Passenger
    {
        [Display(Name ="Date of Birth")]
        [DataType(DataType.DateTime)]
        public DateTime birthDate { get; set; }
        
        [EmailAddress]
        public string? emailAddress { get; set; }
        [RegularExpression(@"^[0-9]{8}$")]
        public string?  phoneNumber { get; set; }

        
        public string? firstname { get; set; }

        [MinLength(3,ErrorMessage ="Veuillez saisir correctement le nom")]
        [MaxLength(25,ErrorMessage ="Veuillez respecter les regles de saisie")]
        public string? lastname { get; set; }

        [Key]
        public int passportName { get; set; }

        //public int id { get; set; }

        public ICollection<Flight> flights { get; set; }

        public override string ToString()
        {
            return "First name ° " +this.firstname+" lastname "+this.lastname+" id "+this.passportName;
        }

        public bool checkProfile(string lastname,string first)
        {
            return this.firstname == first && this.lastname == lastname;
        }

        public bool checkProfile(string lastname,string first,string? mail)
        {
            if (mail != null)
            {
                return this.firstname == first && this.lastname == lastname &&
                    this.emailAddress == mail;
            }
            else
            {
                return this.firstname == first && this.lastname == lastname;

            }
        }

        public virtual void PassengerType()
        {
            Console.WriteLine("I m a passenger");
        }

    }
}
