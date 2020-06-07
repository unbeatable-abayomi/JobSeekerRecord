using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace JobSeekerRecord.Models
{
    public class JobSeekerModel
    {
        [Key]
        public long ID { get; set; }

        [Required]
        [Display (Name = "First Name")]

        [StringLength (20,MinimumLength =3, ErrorMessage = "Please Note: Characters Inputted Must Not be below 3 character and above 20 Characters: Please Try Again")]
        public string FirstName { get; set; }

        [Required]
        [Display (Name = "Last Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please Note: Characters Inputted Must Not be below 3 character and above 20 Characters: Please Try Again")]
        public string LastName { get; set; }

        [Required]
        [Display (Name = "Email Address")]
        [RegularExpression(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}", ErrorMessage = "Please Enter a Vailid email address example@yahoo.com")]
        [DataType(DataType.EmailAddress)]
         public string Email { get; set; }
        [Required]
        [Display (Name = "Phone Number")]

        [DataType(DataType.PhoneNumber)]
        
        [RegularExpression(@"\d{3}-\d{4}-\d{4}", ErrorMessage = "Please Kindly Enter a Phone Number with this format 080-0903-9090")]
        public string PhoneNumber { get; set; }

        [Required]
        public string Gender { get; set; }
        [Required]
        [DataType (DataType.Date)]
        public string DOB { get; set; }
        [Required]
        
        public int GraduationYear { get; set; }

        [Required]

        public string CourseStudied { get; set; }

        [Required]
        [Display (Name ="Graduated With")]
        public string GraduatedWith { get; set; }

        [Required]
        [Display (Name = "Area of Speclization")]
        public string Speclization { get; set; }

        [Required]
        [Display(Name = "Hobbies")]
        public string Hobbies { get; set; }

    }
}
