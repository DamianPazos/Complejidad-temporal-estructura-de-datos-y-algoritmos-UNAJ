/* Tabla de dispersion programada para la actividad entregable de la materia */
/* Los empleados de una cierta compañía se representan en la base de datos de la compañía por su nombre,número de empleado y DNI. Implemente todos los objentos necesarios que permita tener una tablas de hash con estrategia de resolución de colisiones de dispersión abierta que permita guardar y acceder a los registros de los empleado por DNI. */
using System;

namespace HashTable
{
    public class HashTable<T> 
    {
        /* Attributes */
        private int size;
        private List<T>[] table;

        /* Builder */
        public HashTable(int size)
        {
            this.size = size;
            this.table = new List<T>[size];
        }

        /* Methods */
        private int hashFunction(int dni)
        {
            return dni % this.size;
        }

        public void hashInsert(T employee)
        {
            int index = this.hashFunction(employee.getDni());
            if (table[index] == null) {
                table[index] = new List<T>();
            }
            table[index].Add(employee);
        }

        public T hashSearch(T employee)
        {
            
        }



    }
}