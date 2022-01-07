using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoa_Interface_v1
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Classes estanciadas
            Funcionario funcionario01 = new Funcionario();
            Estagiario estagiario01 = new Estagiario();
            Cliente cliente01 = new Cliente();
            #endregion  

            #region Funcionario
            Console.WriteLine(funcionario01.Listar("Maria", 32 ));
            Console.WriteLine(funcionario01.Listar(87952, "Maria", "Porto", 32));
            Console.WriteLine(funcionario01.DepartamentoFunc("Financeiro"));
            Console.WriteLine(funcionario01.DataInicioFunc(DateTime.Now));
            Console.WriteLine(funcionario01.InserirDados("Módulo Inserir está em construção...."));
            Console.WriteLine(funcionario01.EditarDados("Módulo Editar está em construção...."));
            Console.WriteLine(funcionario01.ApagarDados("Módulo Apagar está em construção...."));
            #endregion
            Console.ReadKey();
            Console.Clear();

            #region Estagiario
            Console.WriteLine(estagiario01.Listar("João", 28));
            Console.WriteLine(estagiario01.Listar(87952, "João", "Porto", 28, "IT - data science"));
            Console.WriteLine(estagiario01.CursoEstagiario("Curso: IT - data science"));
            Console.WriteLine(estagiario01.InserirDados("Módulo Inserir está em construção...."));
            Console.WriteLine(estagiario01.EditarDados("Módulo Editar está em construção...."));
            Console.WriteLine(estagiario01.ApagarDados("Módulo Apagar está em construção...."));
            
            #endregion
            Console.ReadKey();
            Console.Clear();

            #region Cliente
            Console.WriteLine(cliente01.Listar("XPTO", 35));
            Console.WriteLine(cliente01.ClienteTipo("Serviços de Marketing"));
            Console.WriteLine(cliente01.InserirDados("Módulo Inserir está em construção...."));
            Console.WriteLine(cliente01.EditarDados("Módulo Editar está em construção...."));
            Console.WriteLine(cliente01.ApagarDados("Módulo Apagar está em construção...."));
            
            #endregion  
            Console.WriteLine("\n\n");
            Console.ReadKey();


        }
    }
}
