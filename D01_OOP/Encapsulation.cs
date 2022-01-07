using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{

    // Access modifiers: public, private
    // Por defeito as classes são publicas --> Podem ser usadas noutras classes

    // Encapsulation
    //              Propriedades + métodos: public
    //              Variáveis + fields: private

    
    
    class Encapsulation
    {

        #region Encapsulation
        // Encapsulation
        // propriedades e métodos : public
        // variáveis e fields: privat

        #endregion

        #region Variáveis (públicas à classe, privadas fora da classe)
        int value01 = 0;
        #endregion

        #region Fields (variável privada de suporte à propriedade)
        private string name;
        #endregion

        #region Properties
        // Surname = "texto";              // set é para escrever o valor da propriedade
        // Console.WriteLine(Surname);     // get é para ler o valor da propriedade
        // classic requer um fiel privado de suporte
        public string Name
        {
            get
            {
                return name;
            }

            set 
            { 
                name = value;
            }
        }

        // Auto-implemented
        public string Surname { get; set; }

        // Bodied-expression (lambda operator =>)
        #endregion

        #region Methods
        public void List01()
        {
            Console.WriteLine($"{Name} {Surname}");
        }

        //Por omissão do access modifier, o metodo é private
        // " void List02(){}
        #endregion



    }
}
