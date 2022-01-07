using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance

            #region Create Objects

            /*
            Person person01 = new Person();                          // 1º construtor: Vazio
            Person person02 = new Person("Fabio", "Gonçalves");
            Student student01 = new Student();                       //-> não herdou os construtores de person
                                                                     // tivemos de ir criar construtores para student
            Student student02 = new Student("Ana", "Maria");
            Student student03 = new Student("Fabio", "Goncalves", "Back-end", "Porto");
            #endregion

            #region Call methods
            person02.ListFullName();
            student03.ListAll();
            student03.ListAll();*/
            #endregion
            #endregion

            #region Encapsulation
           /* Encapsulation encapsulation01 = new Encapsulation();
            encapsulation01.Name = "fabio";
            encapsulation01.Surname = "Gon";*/

            #endregion

            #region Polimophism
            Polimorphism baseClass = new Polimorphism();
            PolimorphismChild derivedClass01 = new PolimorphismChild();

            baseClass.ListFullName();
            baseClass.ListFullName("fabio", "goncalves");
            baseClass.ListFullNameUS("Gonçalves", "fabio");

            baseClass.ListAll("fabio", "goncalves", "Porto");
            
            derivedClass01.ListAll("fabio", "gonçalv", "Porto");

            #endregion

            #region Abstraction
            VertebrateAnimal vertebrateAnimal = new VertebrateAnimal();
            InvertebrateAnimal invertebrateAnimal = new InvertebrateAnimal();

            vertebrateAnimal.Register();
            vertebrateAnimal.List("gato");

            invertebrateAnimal.Register();
            invertebrateAnimal.List("polvo");
            #endregion

            Console.ReadKey();
        }
   
    }


}
