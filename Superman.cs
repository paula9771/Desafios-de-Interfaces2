using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces2
{
    public class Superman : Volador
    {
        public string Mensaje = "¡¡Estoy volando como un campeón!!";
        public float Experiencia = 0;

        public void Volar()
        {
            Experiencia += 3;
            Console.WriteLine(Mensaje);
            Console.WriteLine("Mi expericencia es " + Experiencia);
        }
    }
}
