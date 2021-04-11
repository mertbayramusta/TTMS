using System;
using System.Collections.Generic;

namespace CENG396WWTTMS.Models.DB
{
    public partial class Crew
    {
        public Crew()
        {
            CrewMember = new HashSet<CrewMember>();
            Trouble = new HashSet<Trouble>();
        }

        public int CrewId { get; set; }
        public string CrewName { get; set; }

        public virtual ICollection<CrewMember> CrewMember { get; set; }
        public virtual ICollection<Trouble> Trouble { get; set; }
    }
}
