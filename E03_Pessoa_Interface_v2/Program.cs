using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoa_Interface_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classes estanciadas
            Funcionario funcionario01 = new Funcionario();
            Estagiario estagiario01 = new Estagiario();
            Cliente cliente01 = new Cliente();
            FuncionarioNormal funcionarioNormal01 = new FuncionarioNormal();
            #endregion  

            #region Funcionario
            Console.WriteLine(" ----------- Classe Funcionário ----------- \n");
            Console.WriteLine(funcionario01.Listar("Maria Helena", 32));
            Console.WriteLine(funcionario01.Listar(87952, "Maria Helena", "Porto", 32));
            Console.WriteLine(funcionario01.DepartamentoFunc("Financeiro"));
            Console.WriteLine(funcionario01.DataInicioFunc(DateTime.Now));
            Console.WriteLine(funcionario01.InserirDados("Módulo Inserir está em construção...."));
            Console.WriteLine(funcionario01.EditarDados("Módulo Editar está em construção...."));
            Console.WriteLine(funcionario01.ApagarDados("Módulo Apagar está em construção...."));
            #endregion
            Console.ReadKey();
            Console.Clear();

            #region Funcionario Normal
            Console.WriteLine(" ----------- Classe FuncionárioNormal ----------- \n");
            Console.WriteLine(funcionarioNormal01.Listar("João Gonçalves", 32));
            Console.WriteLine(funcionarioNormal01.Listar(87956, "João Gonçalves", "Porto", 32));
            Console.WriteLine(Convert.ToString(funcionarioNormal01.ListaPontos("Pontos:8945")));
            Console.WriteLine(funcionarioNormal01.DepartamentoFunc("IT"));
            Console.WriteLine(funcionarioNormal01.DataInicioFunc(DateTime.Today));
            Console.WriteLine(funcionarioNormal01.InserirDados("Módulo Inserir está em construção...."));
            Console.WriteLine(funcionarioNormal01.EditarDados("Módulo Editar está em construção...."));
            Console.WriteLine(funcionarioNormal01.ApagarDados("Módulo Apagar está em construção...."));
            #endregion
            Console.ReadKey();
            Console.Clear();

            #region Estagiario
            Console.WriteLine(" ----------- Classe Estagiário ----------- \n");
            Console.WriteLine(estagiario01.Listar("Fábio - Estagiário", 28));
            Console.WriteLine(estagiario01.Listar(87952, "Fábio", "IT - Data science", 28 ));
            Console.WriteLine(estagiario01.CursoEstagiario("Curso: IT - Data science"));
            Console.WriteLine(estagiario01.InserirDados("Módulo Inserir está em construção...."));
            Console.WriteLine(estagiario01.EditarDados("Módulo Editar está em construção...."));
            Console.WriteLine(estagiario01.ApagarDados("Módulo Apagar está em construção...."));

            #endregion
            Console.ReadKey();
            Console.Clear();

            #region Cliente
            Console.WriteLine(" ----------- Classe Cliente ----------- \n");
            Console.WriteLine(cliente01.Listar("Nome: XPTO", 35));
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
