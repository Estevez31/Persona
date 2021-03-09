using System;
using System.Collections.Generic;
using System.Linq;

namespace Persona
{
    class Persona
    {
        //Campos
        private string _nombre;
        private string _apellido;
        public string correo { get; set; }
            

        //Propiedades
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        /*public string getNombre()
         {
             return _nombre;
         }
        */

        //public string Nombre => _nombre;
        /*public void setNombre(string n)
        {
            _nombre = n;
        }
        */

        public string getApellido()
        {
            return _apellido;
        }
        public void setApellido(string m)
        {
            _apellido = m;
        }

        //public string Apellido { get => _apellido; set => _apellido = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona ana = new Persona();
            //ana.setNombre ("Ana");
            ana.Nombre = "Ana";
            ana.setApellido("Lee");
            Console.WriteLine($"Nombre: {ana.Nombre}");
            Console.WriteLine($"Apellido: {ana.getApellido()}");
            Console.ReadKey();
        }
    }
}
