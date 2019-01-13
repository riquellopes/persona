using System;

namespace persona {
    class People{
        private string name;

        private string lastName;

        private int age;

        public string Name { get => name; set => name = value;}
        public string LastName {get => name; set => lastName = value;}
        public int Age {get => age; set => age = value;}

        public string GetFullName(){
            return $"{name} {lastName}";
        }
        
    }
}