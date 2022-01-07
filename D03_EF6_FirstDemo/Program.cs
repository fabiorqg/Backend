using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_EF6_FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usar a connectionString
            using (var db = new GestaoFormacaoDBEntities()) // Classe que herda o DbContext
            {
                //1. instanciamos a classe
                //2. preenchemos as propriedades
                //3. adicionamos o objeto ao dbset (que representa a tabela da bd em memória)
                //4. gravar as alterações

                #region AreaCurso

                AreaCurso _areaCurso = new AreaCurso();

            //AreaCurso areaCurso02 = new AreaCurso(); Não precisamos de instanciar vários.
            // areaCurso01.AreaCursoID = 3; // É identity, logo não se pode inserir ou manipular
                _areaCurso.Area = "Soft skills";
                db.AreaCurso.Add(_areaCurso);
                db.SaveChanges();
                _areaCurso.Area = "Artes";
                db.AreaCurso.Add(_areaCurso);
                db.SaveChanges();

                #endregion

                #region Subarea

                #endregion

                #region Curso

                #endregion

                Console.ReadKey();

            }
        }
    }
}
