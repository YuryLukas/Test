using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Persona
    {
        private String name;
        private String surname;


        void setName(String name)
        {
            this.name = name;
        }

        String getName()
        {
            return this.name;
        }

        void setSurname(String surname)
        {
            this.surname = surname;
        }

        String getSurname()
        {
            return surname;
        }
    }
}
