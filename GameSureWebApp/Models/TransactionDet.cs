using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameSureWebApp.Models
{
    public class TransactionDet
    {
        [Key]
        public int TxnDetId { get; set; }
        public string EquipmentDet { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalPrice { get; set; }


    }
}