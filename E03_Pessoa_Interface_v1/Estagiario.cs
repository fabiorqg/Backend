using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoa_Interface_v1
{
    class Estagiario : IPessoa
    {
        #region Properties
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public int Idade { get; set; }
        public string Dados { get; set; }
        public string Email { get; set; }
        public string Curso { get; set; }
        public string Inserir { get; set; }
        public string Editar { get; set; }
        public string Apagar { get; set; }
        #endregion

        #region Methods

        public string Listar(string _dado1, int _dado2)
        {
            Dados = $"Nome:{ _dado1} Idade:{ _dado2} ";
            Nome = _dado1;
            Idade = _dado2;
            return Dados;

        } // Lista 2 dados

        public string Listar(int _dado1, string _dado2, string _dado3, int _dado4, string _dado5)
        {
            Dados = $"Id:{ _dado1} Nome:{ _dado2} Morada:{ _dado3} Idade:{ _dado4} Curso:{ _dado5} ";
            ID = _dado1;
            Nome = _dado2;
            Morada = _dado3;
            Idade = _dado4;
            Curso = _dado5;
            return Dados;

        } // Lista dados gerais

        public string InserirDados(string _Inserir)
        {
            Inserir = _Inserir;
            return Inserir;
        }

        public string EditarDados(string _Editar)
        {
            Editar = _Editar;
            return Editar;
        }

        public string ApagarDados(string _Apagar)
        {
            Apagar = _Apagar;
            return Apagar;
        }

        public string CursoEstagiario(string _Curso)
        {
            return _Curso;
        }
        #endregion
    }
}
