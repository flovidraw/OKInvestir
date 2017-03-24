using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OKInvestir.Model
{
    public class Simulation
    {
        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
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

        [NotMapped]
        public string LbInformation
        {
            get
            {
                return this.Product.Name + " - " + SettlementPrice/(1+InterestRate/100) + " - "+ ((int)(this.EndDate - this.StartDate).TotalDays / 30 )+" "+"months";
            }
            private set { }
        }


    }
}
