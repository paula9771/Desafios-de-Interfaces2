using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces2
{
    public class Boeing747 : Volador
    {
        public string Mensaje = "¡Estoy volando como un avión!";
        public float Horas = 0;

        public void Volar()
        {
            Horas += 13;
            Console.WriteLine(Mensaje);
            Console.WriteLine("Horas de vuelo: " + Horas);
        }
    }
}
