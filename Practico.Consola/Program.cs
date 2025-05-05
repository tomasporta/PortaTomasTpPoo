using Practico.Entidades;
using Practico.Utilidades;
using System.ComponentModel.DataAnnotations;

namespace Practico.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PiramideCuadrada> piramides = new List<PiramideCuadrada>();

            do
            {
                int ladoBase = ExtensionesConsola.LeerEntero("Ingrese el lado de la base");
                int altura = ExtensionesConsola.LeerEntero("Ingrese la altura");

                PiramideCuadrada piramide = new PiramideCuadrada(ladoBase, altura);

                var resultadosValidacion = new List<ValidationResult>();
                var contexto = new ValidationContext(piramide);
                if (!Validator.TryValidateObject(piramide, contexto, resultadosValidacion, true))
                {
                    Console.WriteLine("Errores en la validación:");
                    foreach (var error in resultadosValidacion)
                        Console.WriteLine($"- {error.ErrorMessage}");
                }
                else
                {
                    piramides.Add(piramide);
                    Console.WriteLine("Datos de la pirámide:");
                    Console.WriteLine(piramide.InformarDatos());
                }

                Console.Write("¿Desea ingresar otra pirámide? (s/n): ");
            } while (Console.ReadLine()?.ToLower() == "s");

            Console.WriteLine($"Cantidad total de pirámides ingresadas: {piramides.Count}");
        }
    }
    
}
