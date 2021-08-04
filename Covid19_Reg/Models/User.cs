using System;
using System.Collections.Generic;

#nullable disable

namespace Covid19_Reg.Models
{
    public partial class User
    {
        public string UserName { get; set; }
        public string UserPasswd { get; set; }
        public string UserEmail { get; set; }
        public string UserDept { get; set; }
    }
}
