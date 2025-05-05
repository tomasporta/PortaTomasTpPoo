
using Practico01.Entidades;
using Practico01.Utilidades;
using System.ComponentModel.DataAnnotations;

namespace Practico.Entidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadPiramides = 0; // Contador de pirámides ingresadas
            do
            {


                var lado = ExtensionesConsola.PedirEntero("Ingrese el valor del lado de la piramide:");
                var altura = ExtensionesConsola.PedirEntero("Ingrese el valor de la altura de la piramide:");
                PiramideCuadrada r = new PiramideCuadrada(lado, altura);

                var context = new ValidationContext(r);
                var errors = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(r, context, errors, true);
                if (isValid)
                {
                    Console.WriteLine(r);
                    cantidadPiramides++; // Incrementar el contador
                }
                else
                {
                    foreach (var error in errors)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                }

                Console.Write("¿Desea ingresar otra pirámide? (s/n): ");
            } while (Console.ReadLine()?.ToLower() == "s");

            // Mostrar la cantidad de pirámides ingresadas al finalizar
            Console.WriteLine($"Cantidad total de pirámides ingresadas: {cantidadPiramides}");
        }
    }
    
}

    

