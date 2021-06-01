using System;

namespace Test
{
    class Persona
    {
        private String name="";
        private String surname="";
        public Persona()
        {

        }
        public Persona(String name, String surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
        public void setSurname(String surname)
        {
            this.surname = surname;
        }
        public String getSurname()
        {
            return surname;
        }
        public void output()
        {
            Console.WriteLine(this.name + " " + this.surname);
        }
    }
}
