using System;

namespace E03_Pessoa_Interface_v2
{
    class Funcionario : IPessoa
    {
        #region Properties
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Departamento { get; set; }
        public DateTime DataEntrada { get; set; }
        public string Dados { get; set; }
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

        public string Listar(int _dado1, string _dado2, string _dado3, int _dado4)
        {
            Dados = $"Id:{ _dado1} Nome:{ _dado2} Morada:{ _dado3} Idade:{ _dado4} ";
            ID = _dado1;
            Nome = _dado2;
            Morada = _dado3;
            Idade = _dado4;
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

        public string DepartamentoFunc(string _Dep)
        {
            Departamento = $"Departamento: {_Dep}";
            return Departamento;
        }

        public string DataInicioFunc( DateTime _Data)
        {
            Dados = $"Ano de entrada: {_Data.Year}";
            return Dados;
        }
        #endregion

    }
}
