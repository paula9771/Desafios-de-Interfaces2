using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato pato = new Pato();
            Boeing747 boeing747 = new Boeing747();
            Superman superman = new Superman();
            TorreDeControl torreDeControl = new TorreDeControl();

            pato.Volar();
            boeing747.Volar();
            boeing747.Volar();
            superman.Volar();

            torreDeControl.AgregarVolador(pato);
            torreDeControl.AgregarVolador(boeing747);
            torreDeControl.AgregarVolador(superman);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("*******Torre de Control: ¡VUELEN TODOS!*******");
            Console.WriteLine("----------------------------------------------");
            torreDeControl.VuelenTodos();
        }
    }
}
