using System;

namespace ArbolBinario 
{
    public class ArbolBinario<T> 
    {

        /*Atributte*/
        private T dato;
        private ArbolBinario<T> hijoIzq;
        private ArbolBinario<T> hijoDer;

        /*Builder*/
        public ArbolBinario(T valor) 
        {
            this.dato = valor;
        }

        /*Methods*/
        public T getValorNodo() 
        {
            return this.dato;
        }

        public void setValorNodo(T valor)
        {
            this.dato = valor;
        }

        public ArbolBinario<T> getHijoIzq()
        {
            return this.hijoIzq;
        }

        public ArbolBinario<T> getHijoDer() 
        { 
            return this.hijoDer;
        }

        public void agregarHijoIzq(ArbolBinario<T> arbolHijo)
        {
            this.hijoIzq= arbolHijo;
        }

        public void agregarHijoDer(ArbolBinario<T> arbolHijo)
        {
            this.hijoDer= arbolHijo;
        }

        public void eliminarHijoIzq()
        {
            this.hijoIzq = null;
        }

        public void eliminarHijoDer()
        {
            this.hijoDer = null;
        }

        public bool esHoja()
        {
            return this.hijoDer == null && this.hijoIzq == null; 
        }

        public void preorden()
        {

        }

    }
}