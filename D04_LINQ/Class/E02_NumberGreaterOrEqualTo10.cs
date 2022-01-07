using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_LINQ
{
    class NumberGreaterOrEqualTo10
    {
        #region Constructor

        public NumberGreaterOrEqualTo10()
        { 

        // Declarar uma lista genérica de inteiros
        List<int> ListIntRandom = new List<int>();

        // Chamar o método para a lista enviando a lista vazia
        CreateList(ListIntRandom);

        // Chamar o método para filtrar e listar , enviando a listar, enviando a lista já preenchida com os 10 números
        FilterAndShowListMethodSyntax(ListIntRandom);
        FilterAndShowListQuerySyntax(ListIntRandom);

        }
        #endregion


        #region Create random numeric List
        public void CreateList(List<int> randomList)
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)    // faz 10 vezes
            {
                int random = rnd.Next(1, 50); // aleatórios entre 1 e 50
                randomList.Add(random); // adicionar à lista o aleatório
            }
        }
        #endregion


        #region Filter and show the random list (method syntax)

        public void FilterAndShowListMethodSyntax(List<int> randomList)
        {
            //var numbers = randomList.Where(n => n >= 10);
            var numbers = randomList.Where(n => n >= 10).OrderBy(n => n);
            Console.WriteLine("NumberGreaterOrEqualTo10 - Method Syntax------\n");
            
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        #endregion


        #region Filter and show the random list (query syntax)

        public void FilterAndShowListQuerySyntax(List<int> randomList)
        {
            //var numbers = randomList.Where(n => n >= 10).OrderBy(n => n);

            var numbers =
                from number in randomList
                where number >= 10
                orderby number
                select number;

            Console.WriteLine("NumberGreaterOrEqualTo10 - Query Syntax------\n");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }


        #endregion

    }
}
