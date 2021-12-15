using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameSureWebApp.Models
{
    public class PaymentMethod
    {
        [Key]
        public int PayId { get; set; }
        public string PaymentType { get; set; }

    }
}