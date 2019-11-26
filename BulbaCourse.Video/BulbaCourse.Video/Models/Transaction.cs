using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BulbaCourse.Video.Models
{
    public class Transaction
    {
        public string TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public double TransactionAmount { get; set; }
    }
}