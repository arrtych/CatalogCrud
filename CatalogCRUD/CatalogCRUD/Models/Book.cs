using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogCRUD.Models
{
    public class Book
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public String Name { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public String Author { get; set; }

        public String Description { get; set; }

        [Display(Name = "Creation data")]       
        public DateTime CreationDate { get; set; }

        [Range(1, 1000)]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        public double Price { get; set; }

        [Range(1, 1000)]
        public int PagesNumber { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [Required]
        public virtual Category CategoryName { get; set; } 

    }
}
