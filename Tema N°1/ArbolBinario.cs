using System;

namespace ArbolBinario 
{
    public class ArbolBinario<T> 
    {

        /*Attribute*/
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

        public void addHijoIzq(ArbolBinario<T> arbolHijo)
        {
            this.hijoIzq= arbolHijo;
        }

        public void addHijoDer(ArbolBinario<T> arbolHijo)
        {
            this.hijoDer= arbolHijo;
        }

        public void deleteHijoIzq()
        {
            this.hijoIzq = null;
        }

        public void deleteHijoDer()
        {
            this.hijoDer = null;
        }

        public bool isHoja()
        {
            return this.hijoDer == null && this.hijoIzq == null; 
        }

        public void preorden()
        {
            Console.WriteLine(this.dato);
            if (this.hijoIzq != null)
            {
                this.hijoIzq.preorden();
            }
            if (this.hijoDer != null)
            {
                this.hijoDer.preorden();
            }
        }

        public void inorden()
        {
            if (this.hijoIzq != null)
            {
                this.hijoIzq.inorden();
            }
            Console.WriteLine(this.dato);
            if (this.hijoDer != null)
            {
                this.hijoDer.inorden();
            }
        }

        public void postorden()
        {
            if (this.hijoIzq != null)
            {
                this.hijoIzq.postorden();
            }
            if (this.hijoDer != null)
            {
                this.hijoDer.postorden();
            }
            Console.WriteLine(this.dato);
        }

        /* Need other class "queue"*/
        public void porNiveles()
        {

        }

        /* Review exception */
        public int contarHojas()
        {
            if (this.dato == null)
            {
                return 0;
            }
            else if (this.isHoja())
            {
                return 1;
            }
            else 
            {
                return this.hijoIzq.contarHojas() + this.hijoDer.contarHojas();
            }
        }
    }
}