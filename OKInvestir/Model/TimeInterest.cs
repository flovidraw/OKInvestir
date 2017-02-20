using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OKInvestir.Model
{
    public class TimeInterest
    {
        public int Id { get; set; }
        [Required]
        public Product Product { get; set; }
        [Required]
        public float Time { get; set; }
        [Required]
        public float Interest { get; set; }
    }
}
