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

            if (context.Books.Any())
            {
                return;
            }


            var books = new Book[]
                {
                     new Book
                     {
                        Name = "Learning Python, 5th Edition",
                        Author = "Mark Lutz",
                        Description = "Get a comprehensive, in-depth introduction to the core Python language with this hands-on book. Based on author Mark Lutz’s popular training course, this updated fifth edition will help you quickly write efficient, high-quality code with Python. It’s an ideal way to begin, whether you’re new to programming or a professional developer versed in other languages.",
                        CreationDate = new DateTime(2011, 6, 10),
                        Price = 12.05,
                        CategoryName = Categories["Computers & Technology"],
                        PagesNumber = 1650
                     },
                     new Book
                     {
                        Name = "Alan Turing: The Enigma",
                        Author = "Andrew Hodges ",
                        Description = "Inspired the Academy Award-nominated film, The Imitation Game.It's only a slight exaggeration to say that the British mathematician Alan Turing (1912-1954) saved the Allies from the Nazis, invented the computer and artificial intelligence, and anticipated gay liberation by decades--all before his suicide at age forty-one." +
                        " This classic biography of the founder of computer science, reissued on the centenary of his birth with a substantial new preface by the author, is the definitive account of an extraordinary mind and life.",
                        CreationDate = new DateTime(2013, 5, 12),
                        Price = 15.35,
                        CategoryName = Categories["Computers & Technology"],
                        PagesNumber = 700
                     },
                     new Book
                     {
                        Name = "Cracking the Coding Interview: 189 Programming Questions and Solutions 6th Edition",
                        Author = "Gayle Laakmann McDowell",
                        Description = "These interview questions are real; they are not pulled out of computer science textbooks. They reflect what's truly being asked at the top companies, so that you can be as prepared as possible. WHAT'S INSIDE?"+
                        "189 programming interview questions, ranging from the basics to the trickiest algorithm problems."+
                        "A walk-through of how to derive each solution, so that you can learn how to get there yourself."+
                        "Hints on how to solve each of the 189 questions, just like what you would get in a real interview."+
                        "Five proven strategies to tackle algorithm questions, so that you can solve questions you haven't seen."+
                        "Extensive coverage of essential topics, such as big O time, data structures, and core algorithms."+
                        "A behind the scenes look at how top companies like Google and Facebook hire developers."+
                        "Techniques to prepare for and ace the soft side of the interview: behavioral questions."+
                        "For interviewers and companies: details on what makes a good interview question and hiring process.",
                        CreationDate = new DateTime(2015, 5, 5),
                        Price = 35.35,
                        CategoryName = Categories["Computers & Technology"],
                        PagesNumber = 687
                     },
                     new Book
                     {
                        Name = "The Man Who Knew Infinity: A Life of the Genius Ramanujan",
                        Author = "Robert Kanigel",
                        Description = "In 1913, a young unschooled Indian clerk wrote a letter to G H Hardy, begging the preeminent English mathematician's opinion on several ideas he had about numbers. Realizing the letter was the work of a genius, Hardy arranged for Srinivasa Ramanujan to come to England. Thus began one of the most improbable and productive collaborations ever chronicled. With a passion for rich and evocative detail, Robert Kanigel takes us from the temples and slums of Madras to the courts and chapels of Cambridge University, where the devout Hindu Ramanujan, \"the Prince of Intuition,\" tested his brilliant theories alongside the sophisticated and eccentric Hardy, \"the Apostle of Proof.\" In time, Ramanujan's creative intensity took its toll: he died at the age of thirty-two and left behind a magical and inspired legacy that is still being plumbed for its secrets today.",
                        CreationDate = new DateTime(2016, 3, 12),
                        Price = 25.99,
                        CategoryName = Categories["History"],
                        PagesNumber = 375
                     },
                     new Book
                     {
                        Name = "Einstein: His Life and Universe",
                        Author = "Walter Isaacson",
                        Description = "How did Einstein's mind work? What made him a genius? Isaacson's biography shows how his scientific imagination sprang from the rebellious nature of his personality. His fascinating story is a testament to the connection between creativity and freedom."+
                        "Based on the newly released personal letters of Albert Einstein, Walter Isaacson explores how an imaginative, impertinent patent clerk, a struggling father in a difficult marriage who couldn't get a teaching job or a doctorate, became the mind reader of the creator of the cosmos, the locksmith of the mysteries of the atom and the universe. His success came from questioning conventional wisdom and marveling at mysteries that struck others as mundane. This led him to embrace a morality and politics based on respect for free minds, free spirits, and free individuals."+
                        "These traits are just as vital for this new century of globalization, in which our success will depend on our creativity, as they were for the beginning of the last century, when Einstein helped usher in the modern age.",
                        CreationDate = new DateTime(2016, 8, 8),
                        Price = 18.55,
                        CategoryName = Categories["History"],
                        PagesNumber = 705
                     },
                     new Book
                     {
                        Name = "Steve Jobs (Chinese Edition)",
                        Author = "Walter Isaacson",
                        Description = "Based on more than forty interviews with Jobs conducted over two years—as well as interviews with more than a hundred family members, friends, adversaries, competitors, and colleagues—Walter Isaacson has written a riveting story of the roller-coaster life and searingly intense personality of a creative entrepreneur whose passion for perfection and ferocious drive revolutionized six industries: personal computers, animated movies, music, phones, tablet computing, and digital publishing. ",
                        CreationDate = new DateTime(2016, 8, 25),
                        Price = 18.55,
                        CategoryName = Categories["History"],
                        PagesNumber = 1000
                     },
                     new Book
                     {
                        Name = "Elon Musk: Tesla, SpaceX, and the Quest for a Fantastic Future ",
                        Author = "Ashlee Vance",
                        Description = "Based on more than forty interviews with Jobs conducted over two years—as well as interviews with more than a hundred family members, friends, adversaries, competitors, and colleagues—Walter Isaacson has written a riveting story of the roller-coaster life and searingly intense personality of a creative entrepreneur whose passion for perfection and ferocious drive revolutionized six industries: personal computers, animated movies, music, phones, tablet computing, and digital publishing. ",
                        CreationDate = new DateTime(2016, 8, 26),
                        Price = 13.55,
                        CategoryName = Categories["History"],
                        PagesNumber = 859
                     },
                     new Book
                     {
                        Name = "Ideas And Opinions Reprint Edition",
                        Author = "Albert Einstein",
                        Description = "A new edition of the most definitive collection of Albert Einstein's popular writings, gathered under the supervision of Einstein himself. The selections range from his earliest days as a theoretical physicist to his death in 1955; from such subjects as relativity, nuclear war or peace, and religion and science, to human rights, economics, and government.",
                        CreationDate = new DateTime(2016, 8, 27),
                        Price = 25.55,
                        CategoryName = Categories["Science & Math"],
                        PagesNumber = 385
                     },
                     new Book
                     {
                        Name = "Turing: Pioneer of the Information Age 1st Edition",
                        Author = "B. Jack Copeland",
                        Description = "Alan Turing is regarded as one of the greatest scientists of the 20th century. But who was Turing, and what did he achieve during his tragically short life of 41 years? Best known as the genius who broke Germany's most secret codes during the war of 1939-45, Turing was also the father of the modern computer. Today, all who 'click-to-open' are familiar with the impact of Turing's ideas.",
                        CreationDate = new DateTime(2017, 1, 1),
                        Price = 11.50,
                        CategoryName = Categories["Science & Math"],
                        PagesNumber = 400
                     },
                     new Book
                     {
                        Name = "Love Real Food: More Than 100 Feel-Good Vegetarian Favorites to Delight the Senses and Nourish the Body",
                        Author = "Kathryne Taylor",
                        Description = "The path to a healthy body and happy belly is paved with real food—fresh, wholesome, sustainable food—and it doesn’t need to be so difficult. No one knows this more than Kathryne Taylor of America’s most popular vegetarian food blog, Cookie + Kate. With Love Real Food, she offers more than 100 approachable and outrageously delicious meatless recipes complete with substitutions to make meals special diet–friendly (gluten-free, dairy-free, and egg-free) whenever possible. Her book is designed to show everyone—vegetarians, vegans, and meat-eaters alike—how to eat well and feel well. ",
                        CreationDate = new DateTime(2017, 2, 1),
                        Price = 16.75,
                        CategoryName = Categories["Cookbooks, Food & Wine"],
                        PagesNumber = 120
                     },
                     new Book
                     {
                        Name = "The Blood Sugar Solution 10-Day Detox Diet Cookbook: More than 150 Recipes to Help You Lose Weight and Stay Healthy for Life",
                        Author = "Mark Hyman M.D.",
                        Description = "Dr. Hyman's bestselling The Blood Sugar Solution 10-Day Detox Diet offered readers a step-by-step guide for losing weight and reversing disease. Now Dr. Hyman shares more than 150 delicious recipes that support the 10-Day Detox Diet, so you can continue on your path to good health. With easy-to-prepare, delicious recipes for every meal - including breakfast smoothies, lunches like Waldorf Salad with Smoked Paprika, and Grass-Fed Beef Bolognese for dinner -- you can achieve fast and sustained weight loss by activating your natural ability to burn fat, reducing insulin levels and inflammation, reprogramming your metabolism, shutting off your fat-storing genes, creating effortless appetite control, and soothing stress. Your health is a life-long journey. THE BLOOD SUGAR SOLUTION 10-DAY DETOX DIET COOKBOOK helps make that journey both do-able and delicious.",
                        CreationDate = new DateTime(2017, 2, 15),
                        Price = 18.35,
                        CategoryName = Categories["Cookbooks, Food & Wine"],
                        PagesNumber = 465
                     },
                     new Book
                     {
                        Name = "When the Air Hits Your Brain: Tales from Neurosurgery",
                        Author = "Frank T Vertosick Jr. MD",
                        Description = "With poignant insight and humor, Frank Vertosick, Jr., MD, describes some of the greatest challenges of his career, including a six-week-old infant with a tumor in her brain, a young man struck down in his prime by paraplegia, and a minister with a .22-caliber bullet lodged in his skull. Told through intimate portraits of Vertosick's patients and unsparing-yet-fascinatingly detailed descriptions of surgical procedures, When the Air Hits Your Brain - the culmination of decades spent struggling to learn an unforgiving craft - illuminates both the mysteries of the mind and the realities of the operating room.",
                        CreationDate = new DateTime(2017, 3, 25),
                        Price = 20.05,
                        CategoryName = Categories["Medical Books"],
                        PagesNumber = 1084
                     },
                     new Book
                     {
                        Name = "Why We Hurt: The Natural History of Pain",
                        Author = "Frank T Vertosick Jr. MD",
                        Description = "Using stories of patients in pain, a neursurgeon and author of When the Air Hits Your Brain explains how pain evolved and why it functions the way it does, providing a mixture of medicine, history, anthropology and inspiration.",
                        CreationDate = new DateTime(2017, 3, 30),
                        Price = 5.25,
                        CategoryName = Categories["Medical Books"],
                        PagesNumber = 250
                     },
                     new Book
                     {
                        Name = "How to Build a Car",
                        Author = "Adrian Newey",
                        Description = "The world's foremost designer in Formula One, Adrian Newey OBE is arguably one of Britain's greatest engineers and this is his fascinating, powerful memoir."+
                        "How to Build a Car explores the story of Adrian's unrivalled 35-year career in Formula One through the prism of the cars he has designed, the drivers he has worked alongside and the races in which he's been involved.",
                        CreationDate = new DateTime(2018, 5, 30),
                        Price = 11.99,
                        CategoryName = Categories["Engineering & Transportation"],
                        PagesNumber = 350
                     },
                     new Book
                     {
                        Name = "Ultimate Guide to Home Repair and Improvement",
                        Author = "Jada Correia",
                        Description = "The most complete home improvement manual on the market, this book offers more than 2,300 photos, 800 drawings, and understandable, practical text.Inside this book, you will find essential instruction on plumbing and electrical repairs, heating and cooling, roofing and siding, cabinets and countertops, and more."+
                        "Information is also provided on tools, materials, and basic skills, plus 325 step-by-step projects with how-to photo sequences.",
                        CreationDate = new DateTime(2018, 6, 01),
                        Price = 9.99,
                        CategoryName = Categories["Engineering & Transportation"],
                        PagesNumber = 365
                     },
                     new Book
                     {
                        Name = "The Total Money Makeover: A Proven Plan for Financial Fitness",
                        Author = "Dave Ramsey ",
                        Description = "Okay, folks, do you want to turn those fat and flabby expenses into a well-toned budget? Do you want to transform your sad and skinny little bank account into a bulked-up cash machine? Then get with the program, people. There's one sure way to whip your finances into shape, and that's with The Total Money Makeover. It's the simplest, most straight-forward game plan for completely making over your money habits. And it's based on results, not pie-in-the-sky fantasies."+
                        "Where Financial Peace gave you the solid saving and investing principles, this book puts those principles into practice. You'll be exercising your financial strength every day and quickly freeing yourself of worry, stress, and debt. And that's a beautiful feeling.",
                        CreationDate = new DateTime(2018, 6, 09),
                        Price = 16.99,
                        CategoryName = Categories["Education & Teaching"],
                        PagesNumber = 403
                     },
                     new Book
                     {
                        Name = "Teach Your Child to Read in 100 Easy Lessons",
                        Author = "Siegfried Engelmann",
                        Description = "Is your child halfway through first grade and still unable to read? Is your preschooler bored with coloring and ready for reading? Do you want to help your child read, but are afraid you'll do something wrong? RAs DISTARreg; is the most successful beginning reading program available to schools across the country. Research has proven that children taught by the DISTARreg; method outperform their peers who receive instruction from other programs",
                        CreationDate = new DateTime(2018, 6, 25),
                        Price = 14.99,
                        CategoryName = Categories["Education & Teaching"],
                        PagesNumber = 412
                     },
                };




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
                        new Category{Name = "Cookbooks, Food & Wine",Description = "Books related to the cooking" },
                        new Category{Name = "Medical Books",Description = "Books related to the medicine" },
                        new Category{Name = "Education & Teaching",Description = "Books related to the education " },
                        new Category{Name = "Engineering & Transportation",Description = "Books related to the engineering " },

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
