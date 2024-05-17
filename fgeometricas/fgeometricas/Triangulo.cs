using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fgeometricas
{
    class Triangulo: Figuras
    {
        //esta clase requiere dos lados, una base y una altura para funcionar 
        //creamos el lado2
        private float lado2;
        private float altura;
        private float raiz;
        //crea un constructor para triangulo
        public float Lado2
        {
            set
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    lado2 = 0; //manda el valor a 0
                } //NO EXISTEN LADOS NEGATIVOS
                else
                {
                    lado2 = value;
                }
            }
            get //obtener el valor
            {
                return lado2; //regresa o cacha el valor de la variable lado2
            }
        }
        public float Altura 
            /*practicamente para poder calcular el area se necesita una altura para la formula general
             * que es b*a/2 y pues hice una simple reinterpretacion de codigo y en vez de crear "lado",
             * cree "altura" y esta la multiplicare por la base*/
        {
            set
            {
                if (value < 0)
                {
                    altura = 0;
                }
                else
                {
                    altura = value;
                }
            }
            get
            {
                return altura;
            }
        }
        public float Raiz
        /*para la base no pude poner la palabra "base" ya que por si sola, la palabra base es una 
         * funcion de visual y pues simplemete le hice un sinonimo y este es "raiz"*/
        {
            set
            {
                if (value < 0)
                {
                    raiz = 0;
                }
                else
                {
                    raiz = value;
                }
            }
            get
            {
                return raiz;
            }
        }
        //usamos el constructor de la clase padre
        public Triangulo(float lado1, float lado2, float altura, float raiz)
        { //lado se va a leer de la caja de texto con
            //usando el boton guardar
            this.Lado1 = lado1; // hace que unicamente el valor la
                                //cantidad del lado sea disponible
                                //para la clase rectangulo, cuando no se use recatangulo
                                //la variable sera=0
            this.Lado2 = lado2;
            this.Altura = altura;
            this.Raiz = raiz;
        }

        //vamos a usar los metodos de la clase padre
        //vamos a sobreescribir el comportamiento de estos
        public override float area()
        {
            return Raiz * Altura / 2; //aqui coloque "/2" ya que es la formula general del area del triangulo
        }
        public override float perimetro()
        {
            return Lado1 + Lado2 + Raiz;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}

