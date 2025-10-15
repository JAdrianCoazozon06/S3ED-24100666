using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5PalindromoCode
{
    internal class Pila
    {
        object[] Pilaa;
        object unValor = 0;
        int TopePila = -1;

        private int _intTamañoPila;//prueba coaz2


        public int TamañoPila
        {
            get { return _intTamañoPila; }
            set
            {

                _intTamañoPila = value;
            }

        }

        public Pila(int TamañoPila)
        {
            Pilaa = new object[TamañoPila];
        }
        public void Agregar(object Valor)
        {
            TopePila++;
            Pilaa[TopePila] = Valor;
        }
        private void Eliminar(object Valor)
        {
            if (TopePila == -1)
            {
                MessageBox.Show("No hay nada que eliminar porque la pila esta completamente vacia");
            }
            else
            {

                TopePila--;
                //Aqui la pila se elimina de manera virtual
            }

        }
        private object Sacar(object Valor)
        {
            if (TopePila == -1)
            {
                MessageBox.Show("No hay nada que sacar pq la pila esta vacia");
                return ("");

            }
            else
            {

                unValor = Pilaa[TopePila];
                Eliminar(Valor);
                return (unValor);
            }


        }

    }
}
