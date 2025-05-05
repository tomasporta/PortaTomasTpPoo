using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico.Entidades
{
    public class PiramideCuadrada: IValidatableObject
    {
        public int LadoBase { get; }
        public int Altura { get; }
        public double Apotema { get; set; }

        public PiramideCuadrada(int ladoBase, int altura)
        {
            LadoBase = ladoBase;
            Altura = altura;
            
        }


        private double GetApotema()
        {
           return  Apotema = Math.Sqrt(Math.Pow(LadoBase / 2.0, 2) + Math.Pow(Altura, 2));
        }

        public double GetArea()
        {
            double areaBase = Math.Pow(LadoBase, 2);
            double areaLateral = 2 * LadoBase * Apotema;
            return areaBase + areaLateral;
        }

        public double GetVolumen()
        {
            return (Math.Pow(LadoBase, 2) * Altura) / 3.0;
        }
       
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"lado base: {LadoBase}");
            sb.AppendLine($"y Altura.............:{Altura}");
            sb.AppendLine($"Area............:{GetArea():F2}");
            sb.AppendLine($"Volumen.............:{GetVolumen():F2}");
            sb.AppendLine($"Apotema..............:{GetApotema():F2}");
            return sb.ToString();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (LadoBase <= 0)
                yield return new ValidationResult("El lado de la base debe ser mayor a 0.");
            if (Altura <= 0)
                yield return new ValidationResult("La altura debe ser mayor a 0.");
        }
        public string MostrarInfo()
        {
            return $"Piramide Cuadrada=> Lado : {LadoBase} y  Altura :{Altura}";
        }
    }
}
