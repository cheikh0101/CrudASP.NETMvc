using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtelierGlMvc.Models
{
    public class Classe
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required(ErrorMessage = "*"), Display(Name ="Libelle"), MaxLength(25, ErrorMessage ="Taille maximale 25")]
        public string Libelle { get; set; }
    }
}