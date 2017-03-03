using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OKInvestir.Model
{
    public class Account
    {
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string Number { get; set; }
        [Required]
        public decimal Balance { get; set; }
        [Required]
        public int status { get; set; }
        [Required]
        public int ClientId { get; set; }
        [Required]
        public virtual Client Client { get; set; }
    }
}
