using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TopHatFamDoc.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Column(TypeName = "nvarchar(150)")]
        public string Nume { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string Prenume { get; set; }

        [Column(TypeName = "date")]
        public DateTime ZiuaNastere { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataInregistrare { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string Notes { get; set; }

       
    }
}
