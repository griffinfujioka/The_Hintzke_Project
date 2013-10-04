using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using The_Hintzke_Project.Models; 

namespace The_Hintzke_Project.Controllers
{
    public class StrainsController : ApiController
    {

        Strain[] strains = new Strain[]
            {
                new Strain { ID = 1, Name = "God's Bud", PercentIndica = 40, PercentSativa = 60, PricePerGram = 8}, 
                new Strain { ID = 2, Name = "Purple Kush", PercentIndica = 30, PercentSativa = 70, PricePerGram = 10}

            };

        public IEnumerable<Strain> GetAllStrains()
        {
            return strains; 
        }

        public Strain GetStrainByName(int id)
        {
            var strain = strains.FirstOrDefault(s => s.ID == id);

            if (strain == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return strain;
        }
    }
}
