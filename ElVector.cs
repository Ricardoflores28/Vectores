using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    class ElVector
    {


        private int[] vector;

        public ElVector(int tamaño)
        {
            vector = new int[tamaño];

        }
        public void GirarArriba()
        {
            int temporal;
            temporal = vector[vector.Length - 1];

            for (int i = vector.Length - 1; i >= 1; i--)
                vector[i] = vector[i - 1];
            vector[0] = temporal;


        }
        public void GirarAbajo()
        {
            int temporal;
            temporal = vector[0];

            for (int i = 0; i<vector.Length - 1; i++)
                vector[i] = vector[i + 1];
            vector[vector.Length - 1] = temporal;
        }
        public void Invertir()
        {
            int temporal, medio;
            medio = vector.Length / 2;
            for (int i = 0; i < medio; i++)
            {
                temporal = vector[i];
                vector[i] = vector[vector.Length - 1 - i];
                vector[vector.Length - 1 - i] = temporal;
            }

        }


    
        
                public void llenar(int numero)

        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = numero;
                numero++;
            }


        }



        public string Mostrar()
        {
            string guardar = " ";
            for (int i = 0; i < vector.Length; i++)
            {
                guardar += "[" + i + "]=" + vector[i] + Environment.NewLine;
            }
            return guardar;


        }
    }
}

