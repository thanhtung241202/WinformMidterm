using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Phan2.Models
{
    public class Transactions
    {
        public Guid Trans_id { get; set; } = Guid.NewGuid();
        public BigInteger Account_id { get; set; }

        public DateTime Happened_time { get; set; } = DateTime.UtcNow;
        public string Action_desc { get; set; }
        public string Note { get; set; } = null!;

        public ICollection<Bank_account> Bank_accounts = [];
    }
}
