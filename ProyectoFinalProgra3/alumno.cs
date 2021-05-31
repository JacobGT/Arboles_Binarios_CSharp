using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgra3
{
    class alumno
    {
        private int idAlumno, idArbol, idCarrera;
        private string nombre, apellido, carnet;

        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        public int IdArbol { get => idArbol; set => idArbol = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Carnet { get => carnet; set => carnet = value; }

        public string IterarInformacion()
        {
            string info = "";

            info = ("ID Alumno: " + idAlumno + "\r\nNombre: " + nombre + "\r\nApellido: " + apellido + "\r\n# Carnet: " + carnet + 
                "\r\nID Arbol: " + idArbol + "\r\nID Carrera: " + idCarrera);

            return info;
        }

    }
}
