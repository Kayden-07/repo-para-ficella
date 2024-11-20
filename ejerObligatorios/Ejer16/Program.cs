using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda Agenda = new Agenda(); 

            Agenda.AniadirContacto(new Contacto("Juan", "123456789"));
            Agenda.AniadirContacto(new Contacto("Maria", "987654321"));

            Agenda.AniadirContacto(new Contacto("Juan", "111111111"));

            Agenda.ListarContactos();

            Agenda.BuscaContacto("Maria");

            Agenda.EliminarContacto(new Contacto("Maria", "987654321"));

            Agenda.ListarContactos();

            Console.WriteLine($"¿La agenda esta llena? {Agenda.AgendaLlena()}");

            Console.WriteLine($"Espacios libres en la agenda: {Agenda.HuecosLibres()}");

            Console.ReadKey();
        }
    }
}
