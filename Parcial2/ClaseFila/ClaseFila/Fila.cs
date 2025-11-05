using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFila
{
    internal class Fila
    {
        object[] Filaa;
        object unValor = 0;
        int TopeFila = -1;

        private int _intTamañoFila;


        public int TamañoFila
        {
            get { return _intTamañoFila; }
            set
            {

                _intTamañoFila = value;
            }

        }

        public Fila(int TamañoPila)
        {
            Filaa = new object[TamañoFila];
        }
        public void Agregar(object Valor)
        {
            TopeFila++;
            Filaa[TopeFila] = Valor;
        }
        private void Eliminar(object Valor)
        {
            if (TopeFila == -1)
            {
                MessageBox.Show("No hay nada que eliminar porque la pila esta completamente vacia");
            }
            else
            {
                for(int i = 0; i < TopeFila; i++)
                {
                    Filaa[i] = Filaa[i + 1];
                }
                TopeFila--;
                //Aqui la Fila elimina el ultimo elemento de la cola ya que se recorrio
            }

        }
        private object Sacar(object Valor)
        {
            if (TopeFila == -1)
            {
                MessageBox.Show("No hay nada que sacar pq la pila esta vacia");
                return ("");

            }
            else
            {

                unValor = Filaa[0];
                Eliminar(Valor);
                return (unValor);
            }


        }
    }
}
