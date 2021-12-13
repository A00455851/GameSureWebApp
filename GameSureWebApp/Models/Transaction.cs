using GameSureWebApp.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameSureWebApp.Models
{
    public class Transaction
    {
        [Key]
        public int TxnId { get; set; }
        public DateTime TxnDate { get; set; }
        public string TxnStatus { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public GameSureWebAppUser GameSureWebAppUser { get; set; }
    }
}
