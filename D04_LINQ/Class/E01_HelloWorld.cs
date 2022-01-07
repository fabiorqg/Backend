using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_LINQ
{
    /*
     Escrever o famoso Hello World em LINQ, usando 2 métodos (query e method syntax)
     */

    class HelloWorld
    {

        #region Method Syntax
        public void HelloWorldMethodSyntax()
        {
            // 1. Array de strings
            string[] words =
            {
                "method",
                "hello",
                "wonderful",
                "linq",
                "beautiful",
                "world"
            };

            // 2. Filtrar: Palavras de compimento igual a 5
            var shortWords = words.Where(word => word.Length == 5);
            //var shortWords = words.Where(word => word.Length == 5).OrderByDescending(word => word);

            /// 3. Listar o array filtrado
            foreach (var item in shortWords)
            {
                Console.WriteLine(item.ToUpper());
            }

            //Console.ReadKey();
        }
        #endregion

        #region Syntax

        public void HelloWorldQuerySyntax()
        {
            // 1. Array de strings
            string[] words =
            {
                "method",
                "hello",
                "wonderful",
                "linq",
                "beautiful",
                "world"
            };

            // 2. Filtrar: Palavras de compimento igual a 5
            var shortWords =
                from word in words
                where word.Length == 5
                orderby word descending
                select word;

            /// 3. Listar o array filtrado
            foreach (var item in shortWords)
            {
                Console.WriteLine(item.ToUpper());
            }

            Console.ReadKey();
        }


        #endregion
    }
}
