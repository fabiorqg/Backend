using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoa_Interface_v2
{
    class FuncionarioNormal :Funcionario
    {
        #region Properties
        public Int16 Pontos { get; set; }
        public Int16 PontosFuncionário { get; set; }
        #endregion

        #region Methods


        public string ListaPontos(string _Pontos)
        {
            //Pontos = _Pontos;
            return _Pontos;
        }

        public new string DataInicioFunc(DateTime _Data)
        {
            Dados = $"Ano de entrada: {_Data.Year}";
            return Dados;
        }
        #endregion
    }
}
