using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220235
{
    public class PredmetIB220235
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int SemestarId { get; set; }
        public SemestarIB220235 Semestar { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
