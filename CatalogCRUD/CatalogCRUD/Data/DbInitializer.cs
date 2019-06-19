using CatalogCRUD.Data;
using CatalogCRUD.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogCrud.Data
{
    public class DbInitializer
    {
        public static void Initialize(IApplicationBuilder applicationBuilder)
        {
            CrudContext context =
                applicationBuilder.ApplicationServices.GetRequiredService<CrudContext>();
            context.Database.EnsureCreated();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            // if (!context.Books.Any()) {
            if (context.Books.Any())
            {
                return;
            }


            var books = new Book[]
                {
                     new Book
                    {
                        Name = "Some name",
                        Author = "Jordj Martin",
                        Description = "lorem impsum ......",
                        CreationDate = DateTime.Now,
                        Price = 5.0,
                        CategoryName = Categories["Computers & Technology"],
                        PagesNumber = 150
                    },
                    new Book
                    {
                        Name = "Some name1",
                        Author = "Jordj Martin",
                        Description = "lorem impsum ......",
                        CreationDate = DateTime.Now,
                        Price = 5.0,
                        CategoryName = Categories["Computers & Technology"],
                        PagesNumber = 150
                    },
                    new Book
                    {
                        Name = "Some name2",
                        Author = "Jordj Martin",
                        Description = "lorem impsum ......",
                        CreationDate = DateTime.Now,
                        Price = 5.0,
                        CategoryName = Categories["Computers & Technology"],
                        PagesNumber = 150
                    }
                };

            /*context.AddRange
            (
             );*/
            // }


            foreach (Book p in books)
            {
                context.Books.Add(p);
            }
            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var typeList = new Category[]
                    {
                        new Category{Name = "Computers & Technology",Description = "Books related to the Computers & Technology" },
                        new Category{Name = "History",Description = "Books related to the History" },
                        new Category{Name = "Science & Math",Description = "Books related to the Science & Math" },
                        new Category{Name = "Cookbooks, Food & Wine ",Description = "Books related to the cooking" },
                        new Category{Name = "Medical Books",Description = "Books related to the medicine" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category type in typeList)
                    {
                        categories.Add(type.Name, type);
                    }
                }

                return categories;
            }
        }
    }
}
