using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OKInvestir.Model
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public virtual Order NewOrder { get; set; }
        [Required]
        public Client Client { get; set; }
        [Required]
        public BoughtProduct BoughtProduct { get; set; }
        [Required]
        public decimal FinalInterest { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
