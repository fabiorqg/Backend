using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_EF6_CodeFirst
{
    // Tabela n
    class Post
    {
        #region Properties

        // Scalar properties
        public int PostID { get; set; } // PK + identity
        public int BlogID { get; set; } // FK
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(200)]
        public string Content { get; set; }
        public string Title { get; set; }
        //public DateTime PostDate { get; set; }


        // Navigation property
        // 1 post pode ter somente 1 blog
        public virtual Blog Blog { get; set; }

        #endregion

        #region Methods

        public static void InsertPost()
        {
            using (var db = new BlogContext())
            {

                string newPost, newContent;
                Post post = new Post();

                

                // 1. Listar os blogs
                Console.WriteLine("Lista de blogs na base de dados:");
                Blog.ListBlog();

                // 2. Pedir ao user para escolher da lista, usando o BlogID
                Console.WriteLine("Em que blog quer escrever o post?");
                newPost = Console.ReadLine();
                // 3. Verificar se esse nº de blog existe
                // obrigar o user a escolher 1 nº de blog existente com While
                // se falhar pedir para repetir, se estiver bem "sair".
                // se existir, pedir dados do post e gravar.


                Console.WriteLine("Novo Post:");
                newPost = Console.ReadLine();

                Console.WriteLine("Texto:");
                newContent = Console.ReadLine();

                post.BlogID = 1; // Implementar a verificação 
                post.Name = newPost;
                post.Content = newContent;
                db.Post.Add(post);
                db.SaveChanges();
            }


        }

        public static void ListPost()
        {
            using (var db = new BlogContext())
            {
                var query = db.Post.Select(r => r).OrderBy(r => r.PostID);
                Console.WriteLine("\n\n-----------------\n Lista de todos os blogs\n-----------------");
                foreach (var item in query)
                {
                    Console.WriteLine($"{item.PostID} - {item.Name} : {item.Content}");
                }

                Console.WriteLine("\n\n");
            }

        }

        #endregion

    }
}
