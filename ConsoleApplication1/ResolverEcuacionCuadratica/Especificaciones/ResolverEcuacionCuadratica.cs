using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
    class ResolverEcuacionCuadratica
    {
        public void ResolverLaEcuacionCuadratica(double primerNumero, double segundoNumero, double tercerNumero, ref double primeraRaiz, ref double segundaRaiz)
        {

            //calcular el discriminante
            CalcularDiscriminante accionCalcularDiscriminante = new CalcularDiscriminante();//clase de la instancia de ese metodo
            double discriminante = accionCalcularDiscriminante.CalcularElDiscriminante(primerNumero, segundoNumero, tercerNumero);

            //validar el discriminante
            ValidarDiscriminante validardiscriminante = new ValidarDiscriminante();
            if (validardiscriminante.ValidarDiscriminanteMayorQuecero(discriminante))
            {

                //Calcular raices
                CalcularRaices calcularRaices = new CalcularRaices();
                calcularRaices.CalcularLasRaices(discriminante, primerNumero, segundoNumero, tercerNumero, ref primeraRaiz, ref segundaRaiz);
            }
            else
            {
                //levante una excepción
                Exception ex = new Exception(String.Format("ocurrió un error al calcular las raices," + "ya que [{1}] es mayor que el discriminante [{0}] es menor que cero.", discriminante.ToString()), "0.0");
                throw ex;//aborta este metodo y le pasa la excepcion a quien haya embocado la especificacion
            }
        }
    }
}
