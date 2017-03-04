using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OKInvestir.Model
{
    public class BoughtProduct
    {
        public int Id { get; set; }
        [Required]
        public decimal FinalInterest { get; set; }
        [Required]
        public int BoughtStatus { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Required]
        public DateTime BuyingDate { get; set; }

        [Required]
        public Client Client { get; set; }
        [Required]
        public int ClientId { get; set; }

        [Required]
        public Product Product { get; set; }
        [Required]
        public int ProductId { get; set; }
        

        [NotMapped]
        public string Name
        {
            get
            {
                return Product.Name;
            }
            private set { }
        }
    }
}
