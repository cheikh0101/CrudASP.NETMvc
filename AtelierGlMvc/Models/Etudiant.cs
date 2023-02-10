using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AtelierGlMvc.Models
{
    public class Etudiant
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="*"), Display(Name ="Nom"), MaxLength(80, ErrorMessage = "Taille maximale 80")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "*"), Display(Name = "Prenom"), MaxLength(80, ErrorMessage = "Taille maximale 80")]
        public string Prenom { get; set; }
        [Required(ErrorMessage = "*"), Display(Name = "Adresse"), MaxLength(80, ErrorMessage = "Taille maximale 80")]
        public string Adresse { get; set;}
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "*"), Display(Name = "Email"), MaxLength(80, ErrorMessage = "Taille maximale 80")]
        public string Email { get; set;}
        [Required(ErrorMessage = "*"), Display(Name = "Tel"), MaxLength(80, ErrorMessage = "Taille maximale 80")]
        public string Tel { get; set;}
    }
}