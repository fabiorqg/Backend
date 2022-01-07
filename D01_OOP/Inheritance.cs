using System;

namespace D01_OOP
{

    class Inheritance
    {

        #region Properties
        public string Name { get; set; }
        #endregion

        #region Methods
        public void ListName()
        {
            Console.WriteLine($"Name: {Name}");
        }
        #endregion
    }


    class InheritanceChild : Inheritance
    {
        #region Properties
        public string Surname { get; set; }
        #endregion

        #region Methods
        public void ListSurname()
        {
            Console.WriteLine($"Surname: {Surname}");
        }
        #endregion

    }

    // properties: name, surname, fullname
    // constructors: vazio, passar todos os valores
    // Methods: ListFullName


    class Person
    {
        #region Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname { get; set; }
        #endregion

        #region Constructors
        public Person()
        {
            Name = string.Empty;
            Surname = string.Empty;
            Fullname = string.Empty;
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Fullname = $"{Name} {Surname}";
        }
        #endregion

        #region Methods
        public void ListFullName()
        {
            Fullname = $"{Name} {Surname}";
            Console.WriteLine($"The full name is: {Fullname}");
        }
        #endregion
    }

    class Student : Person
    {
        #region Properties
        public string Course { get; set; }
        public string Location { get; set; }
        #endregion

        #region Constructors
        // Mapear este constutor para o 1º da base classe
        public Student() : base()
        {
        }

        // Mapear
        public Student(string name, string surname) : base(name, surname)
        {
        }

        // Este é o constutor da própria classe
        public Student(string name, string surname, string course, string location)
        {
            Name = name;
            Surname = surname;
            Fullname = $"{Name} {Surname}";
            Course = course;
            Location = location;
        }
        #endregion

        #region Methods
        public void ListAll()
        {

            // Console.WriteLine($"O formando: {Fullname} vive em {Location} está inscrito: {Course}");
            Console.WriteLine($"\n\nO formando: {Name} {Surname}, vive em {Location} está inscrito: {Course}");
        }
        #endregion

    }

}
