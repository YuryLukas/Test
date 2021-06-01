using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            String surname;

            
            const int PARAM_NAME = 0;
            const int PARAM_SURNAME = 1;
            
            try
            {
                name = args[PARAM_NAME];
                surname = args[PARAM_SURNAME];
                Persona user = new Persona(name, surname);
                user.output();
                Console.WriteLine("------------------------------------------------");
            }
            catch
            {
                Console.WriteLine("Ошибка параметров. Правильный синтаксис: test Имя Фамилия");
                Console.WriteLine("------------------------------------------------");
            }
                        
        }
    }
}
