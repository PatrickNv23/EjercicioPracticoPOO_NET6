// See https://aka.ms/new-console-template for more information
namespace EjercicioPractico_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el nombre: ");
            String nombre = Console.ReadLine();
            Console.WriteLine("Introduzca la edad: ");
            int edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el género: ");
            char genero = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Introduzca el peso en kg: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca la altura en cm: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Persona persona1 = new Persona(nombre, edad, genero, peso, altura);
            Persona persona2 = new Persona(nombre, edad, genero);
            Persona persona3 = new Persona();
            persona3.setNombre("Enrique Segoviano");
            persona3.setEdad(25);
            persona3.setGenero('H');
            persona3.setPeso(80.5);
            persona3.setAltura(170);

            validarIMC(persona1.getNombre(), persona1.calcularIMC());
            validarIMC(persona2.getNombre(),persona2.calcularIMC());
            validarIMC(persona3.getNombre(), persona3.calcularIMC());

            persona1.esMayorDeEdad();
            persona2.esMayorDeEdad();
            persona3.esMayorDeEdad();

            Console.WriteLine(persona1);
            Console.WriteLine(persona2);
            Console.WriteLine(persona3);
        }

        static void validarIMC(String nombre, int valor)
        {
            if(valor == -1)
            {
                Console.WriteLine(nombre+ " está bajo de peso");
            }else if(valor == 0)
            {
                Console.WriteLine(nombre+ " está en tu peso ideal");
            }else if(valor == 1)
            {
                Console.WriteLine(nombre+ " está con sobrepeso");
            }
        }
    }
}

