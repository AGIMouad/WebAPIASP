using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfieAWookie.Core.Selfies.Domain
{
    public  class Wookie
    {
        public int id { get; set; }
        public List<Selfie> Selfies { get; set; }
    }
}
