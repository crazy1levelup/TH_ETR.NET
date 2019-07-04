using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopHatFamDoc.Models
{
    public class FilterPacienti
    {

        private AuthenticationContext _context;
        public FilterPacienti(AuthenticationContext context)
        {
            _context = context;
        }
        public IQueryable<Pacienti> GetProducts(FilterPacientiModel searchModel)
        {
            var result = _context.Pacienti.AsQueryable();
            if (searchModel != null)
            {
                
                if (!string.IsNullOrEmpty(searchModel.Nume))
                    result = result.Where(x => x.Nume.Contains(searchModel.Nume));

                if (!string.IsNullOrEmpty(searchModel.Prenume))
                    result = result.Where(x => x.Prenume.Contains(searchModel.Prenume));

            }
            return result;
        }
    }
}
