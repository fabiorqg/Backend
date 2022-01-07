using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_EF6_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                // Chamar métodos estanciando
                //Blog blog01 = new Blog();
                //blog01.InsertBlog();
                //blog01.ListBlog();

                // chamar método com static
                
                Blog.InsertBlog();
                Blog.ListBlog();

                Post.InsertPost();
                Post.ListPost();

                // ToDo: implementar inserir e listar posts
            }
            catch (Exception)
            {

                Console.WriteLine("Atenção, ocorreu erro");
                //throw;
            }
                Console.ReadKey();
        }

   
    }
}
