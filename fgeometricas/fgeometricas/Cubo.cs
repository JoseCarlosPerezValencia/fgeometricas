using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fgeometricas
{
    class Cubo: Figuras
    {
        /*para la parte del cubo se hizo un reciclado de codigo ya que el cuadrado consta de 
         * lados iguales, al igual que el cuadrado. Unicamente el cambio que habra sera en las 
         * operaciones del area y perimetro*/
        public Cubo(float lado1) 
        {
            this.Lado1 = lado1;
        }
        public override float area() //el procedimiento del area solamente es multiplicar el lado * lado
        {/*lo que hice para el area del cubo fue hacer una multiplicacion de lado por lado
          * y despues multiplicarlo por 6 (el numero de lados de un cubo) ya que el signo "^" no se puede 
          * usar con el float ni con el if :((*/
            return 6 * Lado1 * Lado1;
        }
        public override float perimetro() //para el perimentro se multiplicara el lado1 * 4
        {
            return Lado1 * 12;
        }
        public override float volumen()
        {
         return Lado1 * Lado1 * Lado1;
         //el volumen del cubo lo pongo como comentario porque no me acuerdo si era tambien de tarea :c
        }
    }
}
