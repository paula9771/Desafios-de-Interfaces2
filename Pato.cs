using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces2
{
    public class Pato : Volador
    {
        public string Mensaje = "Estoy volando como un pato... ¡¡Cuak!!";
        public int Energia = 5;

        public void Volar()
        {
            Energia--;
            Console.WriteLine(Mensaje);
            Console.WriteLine("Mi energia es: " + Energia);
        }
    }
}
