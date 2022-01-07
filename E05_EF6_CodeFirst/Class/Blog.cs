using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_EF6_CodeFirst
{
    class Blog
    {
        #region Properties
        // Scalar properties
        public int BlogID { get; set; } // PK + identity // Coloca como chave primária porque está logo no início e porque o nome é ID fica identity 

        [Required]
        [StringLength(100)] // Neste caso dá para usar [StringLength(100)] ou [MaxLength(100)]
        public string Name { get; set; }

        //Navigation property

        public virtual List<Post> Posts { get; set; }
        #endregion

        #region Methods

        public static void InsertBlog()
        {
            using (var db = new BlogContext())
            {

                string newBlog;
                Blog blog = new Blog();

                Console.WriteLine("Nome do novo blog:");
                newBlog = Console.ReadLine();

                blog.Name = newBlog;
                db.Blog.Add(blog);
                db.SaveChanges();
            }
        }

        public static void ListBlog()
        {
            using (var db = new BlogContext())
            {
                var query = db.Blog.Select(r => r).OrderBy(r => r.BlogID);
                Console.WriteLine("\n\n-----------------\n Blogs já registados\n-----------------");
                foreach (var item in query)
                {
                    Console.WriteLine($"{item.BlogID} : {item.Name}");
                }

                Console.WriteLine("\n\n");
            }
        }

        #endregion

    }
}
