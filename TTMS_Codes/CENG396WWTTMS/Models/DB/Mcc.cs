using System;
using System.Collections.Generic;

namespace CENG396WWTTMS.Models.DB
{
    public partial class Mcc
    {
        public int MccId { get; set; }
        public string MccName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
