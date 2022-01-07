using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoa_Interface_v1
{
    interface IPessoa
    {
        #region Properties
        int ID { get; }
        string Nome { get; }
        string Morada { get; }
        int Idade { get; }
        string Email { get; }
        
        #endregion

        #region Methods  

        string Listar(string _dado1, int _dado2);
        string InserirDados(string _Inserir);
        string EditarDados(string _Editar);
        string ApagarDados(string _Apagar);

        #endregion

    }
}
