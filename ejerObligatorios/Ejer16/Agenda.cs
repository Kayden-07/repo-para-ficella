using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer16
{
    internal class Agenda
    {
        private List<Contacto> contactos;
        private int capacidad;
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        public Agenda ()
        {
            this.capacidad = 10;
            contactos = new List<Contacto>();   
        }
        public Agenda (int capacidad)
        {
            this.capacidad = capacidad;
            contactos = new List<Contacto>();
        }
        public void AniadirContacto(Contacto c)
        {
            if (AgendaLlena())
            {
                Console.WriteLine("La agenda esta llena");
                return;
            }
            if (ExisteContacto(c))
            {
                Console.WriteLine("El contacto ya existe");
                return;
            }
            contactos.Add(c);
            Console.WriteLine("Contacto añadido");
        }
        private bool ExisteContacto(Contacto c)
        {
            foreach (Contacto contacto in contactos) 
            { 
                if(contacto.Nombre == c.Nombre)
                {
                    return true;
                }
            }
            return false;
        }
        public bool AgendaLlena()
        {
            if (contactos.Count >= capacidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ListarContactos()
        {
            if (contactos.Count == 0)
            {
                Console.WriteLine("La agenda esta vacia");
            }
            else
            {
                Console.WriteLine("Contactos en la agenda:");
                foreach (var contacto in contactos)
                {
                    Console.WriteLine(contacto);
                }
            }
        }
        public void BuscaContacto(string nombre)
        {
            foreach (var contacto in contactos)
            {
                if (contacto.Nombre == nombre)
                {
                    Console.WriteLine($"Contacto encontrado: {contacto}");
                    return;
                }
            }
            Console.WriteLine("El contacto no esta");
        }
        public void EliminarContacto(Contacto c)
        {
            for (var i = contactos.Count - 1; i >= 0; i--)
            {
                if (contactos[i].Nombre == c.Nombre)
                {
                    contactos.RemoveAt(i);
                    Console.WriteLine("Contacto eliminado");
                    return;
                }
            }
            Console.WriteLine("El contacto no se encontro");
        }
        public int HuecosLibres()
        {
            return capacidad - contactos.Count;
        }
    }
}
