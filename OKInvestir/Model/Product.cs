using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OKInvestir.Model
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Product name cannot be longer than 50 characters.")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int ProductStatus { get; set; }

        public virtual List<TimeInterest> TimeInterests { get; set; }
        public virtual List<SillInterest> SillInterests { get; set; }
    }
}
