using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_Interfaces
{
    class User : IAuthentication
    {
        #region Variables
        string message;

        #endregion

        #region Constructors
        public User()
        {
            UserName = string.Empty;
            UserPassword = string.Empty;
        }

        public User(string userName, string userPassword)
        {
            UserName = userName ;
            UserPassword = userPassword ;
        }

        #endregion

        #region Properties
        public string UserName { get; set; }

        public string UserPassword { get; set; }

        #endregion

        #region Methods

        public void Exit()
        {
            message = "A sair.";
            Message("A sair...", "\n\n");
        }

        public void Message(string message, string startLine = "", string endline = "")
        {
            Console.Write($"{startLine}{message}{endline}");
        }

        public bool Validate(string userName, string userPassword)
        {

            if (userName == "fabio" && userPassword == "123")
            {
                message = "OK";
                Message(message, "", "\n");
                return true;
            }
            else
            {
                message = "Dados incorretos";
                Message(message, "\n\n");
                return false;

            }

        }
        #endregion
        
    }
}
