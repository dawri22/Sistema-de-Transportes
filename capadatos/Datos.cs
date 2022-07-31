using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capadatos
{
    public class Datos
    {
        Conexion cn = new Conexion();

        private int _id;
        private string _nombre;
        private string _apellido;
        private DateTime _fecha_nacimiento;
        private string _cedula;


        private int _idautobuses;
        private string _marca;
        private string _modelo;
        private string _placa;
        private string _color;
        private string _ano;

        private int _idruta;
        private string _ruta;

        private string _rutaR;
        private string _nombreR;

        private string _nombreA;
        private string _autobus;

        public string NombreA { get => _nombreA; set => _nombreA = value; }
        public string Autobus { get => _autobus; set => _autobus = value; }

        public string RutaR { get => _rutaR; set => _rutaR = value; }
        public string NombreR { get => _nombreR; set => _nombreR = value; }
        

        public int Idruta { get => _idruta; set =>_idruta = value; }
        public string Ruta { get => _ruta; set => _ruta = value; }

        public int Idautobuses { get => _idautobuses; set => _idautobuses = value; }
        public string Marca { get => _marca; set => _marca = value; }

        public string Modelo { get => _modelo; set => _modelo = value; }
        public string Placa { get => _placa; set => _placa = value; }
        public string Color { get => _color; set => _color = value; }
        public string Ano { get => _ano; set => _ano = value; }



        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime Fecha_nacimiento { get => _fecha_nacimiento; set => _fecha_nacimiento = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }



        public Datos(int id, string nombre, string apellido, DateTime fecha_nacimiento, string cedula, int idautobuses, string marca, string modelo, string placa, string color, string ano, int idruta, string ruta, string rutaR, string nombreR, string nombreA, string autobus)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Fecha_nacimiento = fecha_nacimiento;
            Cedula = cedula;

            Idautobuses = idautobuses;
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Color = color;
            Ano = ano;

            Idruta = idruta;
            Ruta = ruta;

            RutaR = rutaR;
            NombreR = nombreR;

            NombreA = nombreA;
            Autobus = autobus;

        }

        public Datos()
        {
        }

        public string insertardatochofer(Datos dato)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_dato_choferes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = dato.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = dato.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParFechaNacimiento = new SqlParameter();
                ParFechaNacimiento.ParameterName = "@fecha_nacimiento";
                ParFechaNacimiento.SqlDbType = SqlDbType.DateTime;
                ParFechaNacimiento.Value = dato.Fecha_nacimiento;
                SqlCmd.Parameters.Add(ParFechaNacimiento);

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Size = 50;
                ParCedula.Value = dato.Cedula;
                SqlCmd.Parameters.Add(ParCedula);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se ingreso el registro";

                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;

        }

        public string insertardatoautobus(Datos dato)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_dato_autobuses";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idautobuses";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@Marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 50;
                ParMarca.Value = dato.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@Modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 50;
                ParModelo.Value = dato.Modelo;
                SqlCmd.Parameters.Add(ParModelo);

                SqlParameter ParPlaca = new SqlParameter();
                ParPlaca.ParameterName = "@Placa";
                ParPlaca.SqlDbType = SqlDbType.VarChar;
                ParPlaca.Size = 50;
                ParPlaca.Value = dato.Placa;
                SqlCmd.Parameters.Add(ParPlaca);

                SqlParameter ParColor = new SqlParameter();
                ParColor.ParameterName = "@Color";
                ParColor.SqlDbType = SqlDbType.VarChar;
                ParColor.Size = 50;
                ParColor.Value = dato.Color;
                SqlCmd.Parameters.Add(ParColor);

                SqlParameter ParAno = new SqlParameter();
                ParAno.ParameterName = "@Ano";
                ParAno.SqlDbType = SqlDbType.VarChar;
                ParAno.Size = 50;
                ParAno.Value = dato.Ano;
                SqlCmd.Parameters.Add(ParAno);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se ingreso el registro";

                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;

        }

        public string insertardatorutas(Datos dato)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_dato_rutas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdruta = new SqlParameter();
                ParIdruta.ParameterName = "@idruta";
                ParIdruta.SqlDbType = SqlDbType.Int;
                ParIdruta.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdruta);

                SqlParameter ParRuta = new SqlParameter();
                ParRuta.ParameterName = "@Ruta";
                ParRuta.SqlDbType = SqlDbType.VarChar;
                ParRuta.Size = 80;
                ParRuta.Value = dato.Ruta;
                SqlCmd.Parameters.Add(ParRuta);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se ingreso el registro";

                return rpta;

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;

        }

        public DataTable mostrardato()
        {
            DataTable dtresultado = new DataTable("dato");

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_dato";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);



            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return dtresultado;

        }

        public DataTable mostrardatocombochofer()
        {
            DataTable dtresultado = new DataTable("dato");

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_cargarcombobox";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);



            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return dtresultado;

        }

        public DataTable mostrardatocomboruta()
        {
            DataTable dtresultado = new DataTable("dato");

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_cargarcomboboxruta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);



            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return dtresultado;

        }

        public DataTable mostrardatocomboauto()
        {
            DataTable dtresultado = new DataTable("dato");

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spcargarauto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);



            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return dtresultado;

        }

        public string asignacion(Datos dato)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_dato";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombreR";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = dato.NombreR;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter Parruta = new SqlParameter();
                Parruta.ParameterName = "@rutaR";
                Parruta.SqlDbType = SqlDbType.VarChar;
                Parruta.Size = 50;
                Parruta.Value = dato.RutaR;
                SqlCmd.Parameters.Add(Parruta);



                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Tiene ruta";

                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }

        public string asignacionauto(Datos dato)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_auto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombreA";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = dato.NombreA;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter Parruta = new SqlParameter();
                Parruta.ParameterName = "@autobus";
                Parruta.SqlDbType = SqlDbType.VarChar;
                Parruta.Size = 50;
                Parruta.Value = dato.Autobus;
                SqlCmd.Parameters.Add(Parruta);



                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Tiene ruta";

                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }

    }

}
