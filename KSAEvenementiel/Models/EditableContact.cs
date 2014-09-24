using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KSAEvenementiel.Models
{
    public class EditableContact
    {
        [Display(Name = "Nom complet")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Objet")]
        public string ObjecT { get; set; }
        
        [Display(Name = "Message")]
        public string Message { get; set; }

        public EditableContact()
        {
        }
    }
}