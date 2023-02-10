using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace AtelierGlMvc.Models
{
    public class ISIEXAMContext:DbContext
    {
        public ISIEXAMContext() : base("connISIEXAM")
        {

        }

        public DbSet<Etudiant> Etudiant { get; set;}
    }
}