using System;
using System.Collections.Generic;

namespace CENG396WWTTMS.Models.DB
{
    public partial class CrewMember
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public int CrewId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual Crew Crew { get; set; }

        //public virtual Client Client { get; set; }
    }
}
