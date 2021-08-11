using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Models
{
    public class Kurslar
    {
        public int  id { get; set; }

        public string fotograf { get; set; }

        public string kursadi { get; set; }

        public bool published { get; set; }

        public string Eğitmen { get; set; }

        public decimal egitimucreti { get; set; }
    }
}
