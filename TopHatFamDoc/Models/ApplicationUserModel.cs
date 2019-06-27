using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopHatFamDoc.Models
{
    public class ApplicationUserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime ZiuaNastere { get; set; }
        public DateTime DataInregistrare { get; set; }
        public string Notes { get; set; }

    }
}
