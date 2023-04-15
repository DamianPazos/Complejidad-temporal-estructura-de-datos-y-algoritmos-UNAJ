using System;
using System.Collections.Generic;

namespace ArbolGeneral 
{

    public class ArbolGeneral<T> 
    {

        /* Attribute */
        private T dato;
        private List<ArbolGeneral<T>> hijos = new List<ArbolGeneral<T>>();

        /* Builder */
        public ArbolGeneral (T dato) 
        {
            this.dato = dato;
        }

        /* Methods */
        public T getDatoNodo()
        {
            return this.dato;
        }

        public List<ArbolGeneral<T>> getHijos() 
        {
            return this.hijos;
        }

        public void addHijo(ArbolGeneral<T> hijo)
        {
            this.getHijos().Add(hijo);
        }

        public void deleteHijo(ArbolGeneral<T> hijo) 
        {
            this.getHijos().Remove(hijo);
        }

        public bool isHoja() 
        {
            return this.getHijos().Count() == 0;
        }

        public int height() 
        {
            if (this.isHoja()) 
            {
                return 0;
            }
            else 
            {
                int maxHeight = 0;
                foreach (ArbolGeneral<T> hijo in this.getHijos()) 
                {
                    int height = hijo.height();
                    if (height > maxHeight) 
                    {
                        maxHeight = height;
                    }
                }
                return maxHeight + 1;
            }
        }

    }

}

