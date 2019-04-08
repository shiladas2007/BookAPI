using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Models
{
    public class User
    {
        public int UserId { get; set; }//
        public string UserName { get; set; }//
        public string FirstName { get; set; } //
        public string MiddleName { get; set; }//
        public string LastName { get; set; }//
        public int UserType { get; set; }// Student or graduated or external
        public string Address { get; set; }//
        public string Number { get; set; }//
        public string AddressComplement { get; set; }//
        public int Age { get; set; }//
        [EmailAddress]
        public string Email { get; set; }//
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }//
        [Required]
        public double Creditcard { get; set; }//
        public string CreditcardName { get; set; }//
        public bool isBlocked { get; set; }

        /*********************************
        // Relational Properties
        **********************************/
        public int LocalizationId { get; set; }
        public virtual Localization Localization { get; set; }
        public int InstitutionBranchId { get; set; }
        public virtual InstitutionBranch InstitutionBranch { get; set; }


        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Claim> Claims { get; set; }
        public virtual ICollection<Alert> Alerts { get; set; }
    }
}
