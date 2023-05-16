using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortFolioSewar.Models
{
    public class Contact
    {
      
        public int ContactId { get; set; }
  
        [Required(ErrorMessage = "Enter your Name")]
        public string CName { get; set; }


        [Required (ErrorMessage ="Enter your Email" )]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
     
        [Required(ErrorMessage = "Enter The Subject")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Enter Your Message")]
        public string Message { get; set; }
       
    }
}
