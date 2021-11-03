using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces2
{
    public class TorreDeControl
    {
        public List<Volador> Voladores = new List<Volador>();

        public void AgregarVolador(Volador param)
        {
            Voladores.Add(param);
        }

        public void VuelenTodos()
        {
            foreach (Volador element in Voladores)
            {
                element.Volar();
            }
        }
    }
}
