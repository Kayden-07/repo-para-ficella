using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ejer2.Program;

namespace ejer2
{
    internal class Program
    {

        public class Persona
        {
            private const char sexoEstablecido = 'H';
            private string nombre, dni;
            private char sexo;
            private int edad;
            private double peso, altura;
            public string Nombre { get { return nombre; } set { nombre = value; } }
            public string DNI { get { return dni; } }
            public char Sexo { get { return sexo; } set { sexo = value; } }
            public int Edad { get { return edad; } set { edad = value; } }
            public double Peso { get { return peso; } set { peso = value; } }
            public double Altura { get { return altura; } set { altura = value; } }

            public Persona ()
            {
                nombre = "";
                edad = 0;
                dni = GenerarDNI();
                sexo = sexoEstablecido;
                peso = 0;
                altura = 0;
            }
            public Persona (string nombre, int edad, char sexo) : this() //this() llama al constructor por defecto
            {
                this.nombre = nombre;
                this.edad = edad;
                this.sexo = ComprobarSexo(sexo);
            }
            public Persona(string nombre, int edad, char sexo, double peso, double altura, string dni)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.sexo = ComprobarSexo(sexo);
                this.peso = peso;
                this.altura = altura;
                this.dni = dni;
            }

            public void MostrarInfo()
            {
                Console.WriteLine("Nombre: "+ nombre);
                Console.WriteLine("Edad: " + edad);
                Console.WriteLine("DNI: " + dni);
                Console.WriteLine("Sexo: " + sexo);
                Console.WriteLine("Peso: " + peso);
                Console.WriteLine("Altura: " + altura);
            }

            public double CalcularIMC()
            {
                double pesoIdeal = 0;
                pesoIdeal = peso / (altura * altura);

                if (pesoIdeal < 20)
                {
                    return -1;
                } 
                else if (pesoIdeal >= 20 && pesoIdeal <= 25)
                {
                    return 0;
                } 
                else
                {
                    return 1;
                }
            }
            public bool EsMayor()
            {
                bool mayorEdad = false;
                if (edad >= 18)
                {
                    mayorEdad = true;
                }
                return mayorEdad;
            }
            public char ComprobarSexo(char sexo)
            {
                if (sexo != 'H' && sexo != 'M')
                {
                    return 'H';
                }
                return sexo;
            }
            private string GenerarDNI()
            {
                Random random = new Random();
                int numeroDNI = random.Next(10000000, 99999999);
                char letraDNI = GenerarLetra(numeroDNI);
                return numeroDNI.ToString() + letraDNI;
            }

            private char GenerarLetra(int numeroDNI)
            {
                string letrasDNI = "TRWAGMYFPDXBNJZSQVHLCKE";
                int indice = numeroDNI % 23;
                return letrasDNI[indice];
            }
        }

        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            Console.Write("Nombre de la persona1: ");
            persona1.Nombre = Console.ReadLine();
            Console.Write("Cual es la edad de " + persona1.Nombre + "?: ");
            persona1.Edad = int.Parse(Console.ReadLine());
            Console.Write("Cual su sexo(H/M)?: ");
            persona1.Sexo = char.Parse(Console.ReadLine());
            Console.Write("Cual es su peso en Kg?: ");
            persona1.Peso = double.Parse(Console.ReadLine());
            Console.Write("Cual es su altura en metros?: ");
            persona1.Altura = double.Parse(Console.ReadLine());

            Persona persona2 = new Persona(persona1.Nombre, persona1.Edad, persona1.Sexo);

            Persona persona3 = new Persona();

            List<Persona> personas = new List<Persona>();
            personas.Add(persona1);
            personas.Add(persona2);
            personas.Add(persona3);

            foreach (Persona persona in personas)
            {
                persona.MostrarInfo();

                double imc = persona.CalcularIMC();

                if (imc < 0)
                {
                    Console.WriteLine("Está por debajo de su peso ideal.");
                }
                else if (imc == 0)
                {
                    Console.WriteLine("Está en su peso ideal.");
                }
                else
                {
                    Console.WriteLine("Tiene sobrepeso.");
                }

                if (persona.EsMayor())
                {
                    Console.WriteLine("Es mayor de edad.");
                }
                else
                {
                    Console.WriteLine("No es mayor de edad.");
                }
            }
            Console.ReadKey();
        }
    }
}
