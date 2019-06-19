using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogCRUD.Models
{
    public class Book
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Author { get; set; }
        public String Description { get; set; }
        public DateTime CreationDate { get; set; }
        public double Price { get; set; }
        public int PagesNumber { get; set; }

        public int CategoryId { get; set; }
        public virtual Category CategoryName { get; set; }

    }
}
