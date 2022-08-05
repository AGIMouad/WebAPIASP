using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfieAWookie.Core.Selfies.Domain
{
    public class Selfie
    {
        #region properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string imgPath { get; set; }

        public int WookieId { get; set; }  
        public Wookie Wookie { get; set; }
        #endregion
    }
}
