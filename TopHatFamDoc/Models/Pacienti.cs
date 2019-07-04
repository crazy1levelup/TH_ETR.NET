using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TopHatFamDoc.Models
{
    public class Pacienti
    {

        [Key]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string Nume { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string Prenume { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime ZiuaNastere { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataInregistrare { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(1000)")]
        public string Notes { get; set; }

    }

}
