using capadatos;
using System;
using System.Data;

namespace capanegocios
{
    public class NDatos
    {
        public static string insertardatochofer(string nombre, string apellido, DateTime fechanacimiento,
            string cedula
            )
        {
            Datos objeto = new Datos();
            objeto.Nombre = nombre;
            objeto.Apellido = apellido;
            objeto.Fecha_nacimiento = fechanacimiento;
            objeto.Cedula = cedula;

            return objeto.insertardatochofer(objeto);
        }

        public static string insertardatoautobus(string marca, string modelo, string placa, string color, string ano)
        {
            Datos objeto = new Datos();
            objeto.Marca = marca;
            objeto.Modelo = modelo;
            objeto.Placa = placa;
            objeto.Color = color;
            objeto.Ano = ano;

            return objeto.insertardatoautobus(objeto);
        }

        public static string insertadatoruta(string ruta)
        {
            Datos objeto = new Datos();
            objeto.Ruta = ruta;

            return objeto.insertardatorutas(objeto);
        }

        public static DataTable mostrardato()
        {
            Datos objeto = new Datos();
            return objeto.mostrardato();
        }

        public static DataTable mostrardatocombochofer()
        {
            Datos objeto = new Datos();
            return objeto.mostrardatocombochofer();
        }

        public static DataTable mostrardatocomboruta()
        {
            Datos objeto = new Datos();
            return objeto.mostrardatocomboruta();
        }

        public static DataTable mostrardatocomboauto()
        {
            Datos objeto = new Datos();
            return objeto.mostrardatocomboauto();
        }

        public static string asignacion(string nombreR, string rutaR
          )
        {
            Datos objeto = new Datos();
            objeto.NombreR = nombreR;
            objeto.RutaR = rutaR;
           

            return objeto.asignacion(objeto);
        }

        public static string asignacionauto(string nombreA, string autobus
          )
        {
            Datos objeto = new Datos();
            objeto.NombreA = nombreA;
            objeto.Autobus = autobus;


            return objeto.asignacionauto(objeto);
        }

    }
}
