using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{

    abstract class AbstractAnimal
    {
        #region properties
        public abstract string Name { get; set; }
        public string Color { get; set; }
        public abstract Boolean Pet { get; set; }
        #endregion

        #region Methods
        // Umm método abstract não pode ser implementado na classe abstrata
        // Tem de ser implemetado na classe derivada com override e com a mesma assinatura

        public void Register()
        {
            Console.WriteLine($"\nA registar animal.\n");
        }

        public abstract void List(string name); // pode ou não ter assinatura

        public abstract void Domesticate();

        #endregion
    }

    class VertebrateAnimal : AbstractAnimal
    {
        #region Constants
        public const string TYPE = "Vertebrate";

        #endregion

        #region Properties
        public override string Name { get; set; }

        public override bool Pet { get; set; }
        #endregion

        #region Methods
        public override void Domesticate()
        {
            Pet = true;
        }

        public override void List(string name)
        {
            Name = name;
            Console.WriteLine($"Animal: { name} ({ TYPE})");
        }

        #endregion



    }

    class InvertebrateAnimal : AbstractAnimal
    {
        #region Constants
        public const string TYPE = "Invertebrate";

        #endregion

        #region Properties
        public override string Name { get; set; }

        public override bool Pet { get; set; }
        #endregion

        #region Methods
        public override void Domesticate()
        {
            Pet = true;
        }

        public override void List(string name)
        {
            Name = name;
            Console.WriteLine($"Animal: { name} ({ TYPE})");
        }

        #endregion



    }

}
