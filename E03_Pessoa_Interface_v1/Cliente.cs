using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoa_Interface_v1
{
    class Cliente : IPessoa
    {
        #region Properties

        
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Dados { get; set; }
        public string Categoria { get; set; } // Que tipo de serviços solicita
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

        }

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

        public string ClienteTipo(string _Categoria)
        {
            Categoria = $"Categoria:{ _Categoria}";
            return Categoria;
        }
        #endregion


    }
}
