using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Phan2.Models
{
    public enum Type
    {
        Saving = 0,
        Checking = 1

    }

    public class Bank_account
    {
        public BigInteger Account_id { get; set; }
        public string Owner_name { get; set; }
        public string Owner_phone { get; set; }
        public double Balance { get; set; } = 0;
        public Type Account_type { get; set; } = 0;
        public string Password { get; set; } 

        public Bank_account() { }
        

    }
}
