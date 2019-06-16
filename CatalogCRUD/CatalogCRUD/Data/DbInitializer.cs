using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogCRUD.Models;

namespace CatalogCRUD.Data
{
    public class DbInitializer
    {
        public static void Initialize(CrudContext context)
        {
            context.Database.EnsureCreated();
            //if table exists
            if (context.Books.Any())
            {
                return;
            }
            /**
             * 
            public int ID { get; set; }
            public String Name { get; set; }
            public String Author { get; set; }
            public String Description { get; set; }
            public DateTime CreationDate { get; set; }
            public double Price { get; set; }
            public Category CategoryName { get; set; }
            public int PagesNumber { get; set; }
            */

            var books = new Book[]
            {
                new Book
                {
                    Name = "Some name",
                    Author = "Jordj Martin",
                    Description = "lorem impsum ......",
                    CreationDate = DateTime.Now,
                    Price = 5.0,
                    //CategoryName
                    PagesNumber = 150
                },
                new Book
                {
                    Name = "Some name1",
                    Author = "Jordj Martin",
                    Description = "lorem impsum ......",
                    CreationDate = DateTime.Now,
                    Price = 5.0,
                    //CategoryName
                    PagesNumber = 150
                },
                new Book
                {
                    Name = "Some name2",
                    Author = "Jordj Martin",
                    Description = "lorem impsum ......",
                    CreationDate = DateTime.Now,
                    Price = 5.0,
                    //CategoryName
                    PagesNumber = 150
                }
            };


            foreach (Book b in books)
            {
                context.Books.Add(b);
            }

            context.SaveChanges();
        }
    }
}
