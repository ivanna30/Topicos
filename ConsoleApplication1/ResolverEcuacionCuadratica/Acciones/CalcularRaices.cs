using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica.Acciones
{
    class CalcularRaices
    {

        public void CalcularLasRaices(double discriminante, double primerNumero, double segundoNumero, ref double primeraRaiz, ref double segundaRaiz)
        {

            primeraRaiz = (-segundoNumero + Math.Sqrt(discriminante)) / (2 * primerNumero);
            segundaRaiz = (-segundoNumero + Math.Sqrt(discriminante)) / (2 * primerNumero);
        }
    }
}
