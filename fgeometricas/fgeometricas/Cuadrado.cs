using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fgeometricas
{
    class Cuadrado: Figuras
        /* como el cuadrado cuanta con 4 lados iguales, solamente usaremos el "lado1"
         * que nos proporciona la clase padre, ya que como previamente se menciono, 
         * sus lados son iguales*/
    {
        public Cuadrado(float lado1) /*aqui nos brincaremos la parte de crear un lado nuevo
                                      * ya que sus lados son iguales y solamente nos queda jalar 
                                      * la lectura de la caja de texto*/
        {
            this.Lado1 = lado1;
        }
        public override float area() //el procedimiento del area solamente es multiplicar el lado * lado
        {
            return Lado1 * Lado1;
        }
        public override float perimetro() //para el perimentro se multiplicara el lado1 * 4
        {
            return Lado1 * 4;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
