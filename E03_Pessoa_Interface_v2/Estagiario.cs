using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoa_Interface_v2
{
    class Estagiario : Funcionario
    {
        #region Properties
        
        public string Curso { get; set; }

        #endregion

        #region Methods

        public string ListarEstagiario(int _dado1, string _dado2, string _dado3, int _dado4)
        {
            Dados = $"Id:{ _dado1} Nome:{ _dado2} Curso:{ _dado3} Idade:{ _dado4} ";
            ID = _dado1;
            Nome = _dado2;
            Morada = _dado3;
            Idade = _dado4;
            return Dados;

        }

        public string CursoEstagiario(string _Curso)
        {
            return _Curso;
        }
        #endregion
    }
}
