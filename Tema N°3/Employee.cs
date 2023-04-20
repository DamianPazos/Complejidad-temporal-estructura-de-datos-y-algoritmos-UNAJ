/* Clase programada para la actividad entregable de la materia */
/* Los empleados de una cierta compañía se representan en la base de datos de la compañía por su nombre,número de empleado y DNI. Implemente todos los objentos necesarios que permita tener una tablas de hash con estrategia de resolución de colisiones de dispersión abierta que permita guardar y acceder a los registros de los empleado por DNI. */
using System;

namespace HashTable 
{
    public class Employee 
    {
        /* Attributes */
        private string name;
        private int employeeNumber;
        private int dni;

        /* Builder */

        public Employee (string name, int employeeNumber, int dni)
        {
            this.name = name;
            this.employeeNumber = employeeNumber;
            this.dni = dni;
        }

        /* Methods */
        public string getName() 
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getEmployeeNumber() 
        {
            return this.employeeNumber;
        }

        public void setEmployeeNumber(int employeeNumber)
        {
            this.employeeNumber = employeeNumber;
        }

        public int getDni() 
        {
            return this.dni;
        }

        public void setDni(int dni)
        {
            this.dni = dni;
        }
    }
}