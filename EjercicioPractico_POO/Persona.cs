using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractico_POO
{
    internal class Persona
    {
        private const char generoDefecto = 'H';

        private String nombre = "";
        private int edad = 0;
        private String dni;
        private char genero = generoDefecto;
        private double peso = 0;
        private double altura = 0;

        public Persona()
        {

        }

        public Persona(String nombre, int edad, char genero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
        }

        public Persona(string nombre, int edad, string dni, char genero, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.genero = genero;
            this.peso = peso;
            this.altura = altura;
        }

        public Persona(string nombre, int edad, char genero, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
            this.peso = peso;
            this.altura = altura;
        }

        public int calcularIMC()
        {
            int valorPesoIdeal = 0;
            double pesoIdeal = (this.peso / (Math.Pow(this.altura / 100, 2)));
            if(pesoIdeal < 20)
            {
                valorPesoIdeal =  -1;
            }else if(pesoIdeal >= 20 && pesoIdeal < 25)
            {
                valorPesoIdeal = 0;
            }else if(pesoIdeal > 25)
            {
                valorPesoIdeal = 1;
            }
            return valorPesoIdeal;
        }

        public void esMayorDeEdad()
        {
            if(this.edad >= 18)
            {
                Console.WriteLine(this.nombre + " es mayor de edad");
            }
            else
            {
                Console.WriteLine(this.nombre + " es menor de edad");
            }
        }

        public void comprobarGenero(char genero)
        {
            if(genero == 'H' || genero == 'M')
            {
                Console.WriteLine("Genero de " + this.nombre + " es: " + genero);
            }
            else
            {
                genero = this.genero;
                Console.WriteLine("Genero por defecto de " + this.nombre + " es: " + this.genero);
            }
        }

        public override string ToString()
        {
            return "Nombre -> " + this.nombre + 
                " - Edad -> " + this.edad + 
                " - Dni -> " + this.dni + 
                " - Genero -> " + this.genero + 
                " - Peso -> " + this.peso + " kg"+ 
                " - Altura -> " + this.altura+ " cm";
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;   
        }

        public void setEdad(int edad)
        {
            this.edad  = edad;
        }

        public void setGenero(char genero)
        {
            this.genero = genero;
        }

        public void setPeso(double peso)
        {
            this.peso = peso;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public String getNombre()
        {
            return this.nombre;
        }

    }
}
