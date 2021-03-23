using System;
using System.Collections.Generic;
using System.Text;

namespace POO_parctica_2
{
    class Contacto
    {
        private string Nombre, Direccion, Apellido;
        public long Numero_de_telefono = 8493404441;

        public void setNombre(string n)
        {
            Nombre = n;

        }
        public string getNombre()
        {
            return Nombre;
        }
        public void setDireccion(string D)
        {
            this.Direccion = D;
        }
        public string getDireccion()
        {
            return Direccion;
        }
        public void setApellido(string A)
        {
            this.Apellido = A;
        }
        public string getApellido()
        {
            return Apellido;
        }
        public void Saludar()
        {
            Console.WriteLine(" Hola soy: " + Nombre +
                "\n mi apellido es: " + Apellido +
                "\n mi direccion es: " + Direccion +
                "\n mi numero de telefono es: " + Numero_de_telefono);
            Console.WriteLine(" Gracias por agregarme");
        }
    }
}