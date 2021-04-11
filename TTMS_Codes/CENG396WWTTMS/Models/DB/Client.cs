using System;
using System.Collections.Generic;

namespace CENG396WWTTMS.Models.DB
{
    public partial class Client
    {
        public Client()
        {
            Trouble = new HashSet<Trouble>();
        }

        public int AbonNum { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Trouble> Trouble { get; set; }
    }
}
