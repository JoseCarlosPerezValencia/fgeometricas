using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fgeometricas
{
    class Esfera: Figuras
    {
        /*para la creacion de la esfera se hizo un reciclado del codigo del circulo pero evidentemente 
         * con bastentes cambios como en el perimetro y con el volumen y asi mismo con el area*/
        public Esfera(float radio)
        {
            Lado1 = radio;
        }
        public override float area()
        {
            return 4 * 3.1416F * Lado1 * Lado1; /* para el area se le agrego un "4" el cual se debe 
                                                 * a la formula general y este se multiplica por el pi 
                                                 * que es el 3.1416 y despues se multiplica por el radio
                                                 * al cuadrado pero debido a que no se puede elevar al
                                                 * cuadrado, simplemente se multiplica el Lado1 que es el
                                                 * radio por el mismo Lado1*/
        }
        public override float perimetro() /* como se le hizo a las demas figuaras geometricas con el 
                                           * volumen que era inexistente debido a que una figura plana
                                           * (2D) no cuenta con el volumen, para la esfera es lo mismo, 
                                           * solo que en esta ocasion el perimetro es el inexistente*/
        {
            throw new NotImplementedException();
        }
        public override float volumen()
        {
            return (4 / 3) * 3.1416F * Lado1 * Lado1 * Lado1;
            /*para el voluemen se coloco el 4/3 en parentecis para representar la fraccion de su formula
             * general y no colocar una division de 4/3. Con esto ya dicho, se debera de multiplicar por 
             * el pi y por el radio al cubo, el cual se consigue multiplicando 3 veces el radio por si mismo*/
        }
    }
}
