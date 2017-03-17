using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OKInvestir.Model
{
    public class Simulation
    {
        public int Id { get; set; }
        [Required]
        public Client Client { get; set; }
        [Required]
        public Product Product { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Required]
        public decimal InterestRate { get; set; }
        [Required]
        public decimal SettlementPrice { get; set; }
    }
}
