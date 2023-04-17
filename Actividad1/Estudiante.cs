using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Actividad1
{
    public class Estudiante
    {
        SqlConnection conn;
        string miConexion = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;

        public Estudiante()
        {

        }
        //metodo Aplicado en el form 1
        public string InsertaEstudiante(string NombreModulo,
                                             string Codigo,
                                          bool chbActivo)
        {
            string Mensaje;
            try
            {
                conn = new SqlConnection(miConexion);
                conn.Open(); //Aqui abro la conexion a la base de datos
                SqlCommand cmd = new SqlCommand("InsertaModulo", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NombreModulo", SqlDbType.VarChar, 255);
                cmd.Parameters["@NombreModulo"].Value = NombreModulo;

                cmd.Parameters.Add("@Codigo", SqlDbType.VarChar, 255);
                cmd.Parameters["@Codigo"].Value = Codigo;

                cmd.Parameters.Add("@Activo", SqlDbType.Bit);
                cmd.Parameters["@Activo"].Value = chbActivo;

                cmd.ExecuteNonQuery();
                Mensaje = "Datos Insertados Correctamente";
                conn.Close();
                return Mensaje;


            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable CargaComboModulo()//funciona
                                           //es para listar los modulos en el combobox
        {
            DataTable dt = new DataTable(); //esta variable almacenara lo que venga desde la b.d
            SqlDataReader dr = null;
            try
            {
                #region Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();//aqui abro la conexion a la bd
                #endregion
                #region Llamada al Procedimiento Almacenado
                SqlCommand cmd = new SqlCommand("ListaModulo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Ejecutar Procedimiento Almacenado
                dr = cmd.ExecuteReader();//lo hacemos de esta forma siempre que sea un select
                #endregion
                #region Cargar Variable DataTable
                dt.Load(dr);// le paso a la variable dt lo viene desde la base de datos.
                #endregion
                #region Cerrar Conexion y DataReader
                dr.Close();
                conn.Close();
                #endregion
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable CargaComboLaboratorio()//este  funcionaa
        {
            DataTable dt = new DataTable();
            SqlDataReader dr = null;
            try
            {
                #region Paso 1: Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();//aqui abro la conexion a la bd
                #endregion
                #region Paso 2: Llamar al Procedimiento Almacenado
                SqlCommand cmd = new SqlCommand("Listalaboratorio", conn);//aqui lo cambie por Listalaboratorio   ordiginal =ListaLaboratorioTodo
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                //En este caso no existen parametros
                #region Paso 3:  Ejecutar el procedimiento
                dr = cmd.ExecuteReader();
                #endregion
                #region Paso 4: Cargar el DataTable
                dt.Load(dr);
                #endregion
                #region Cerrar Conexion
                dr.Close();
                conn.Close();
                #endregion
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /*

       public DataTable CargaComboLaboratorios()
       {
           DataTable dt = new DataTable();
           SqlDataReader dr = null;
           try
           {
               #region Abrir la coneccion
               conn = new SqlConnection(miConexion);
               conn.Open();
               #endregion

               #region Llamada al procedimiento Almacenado
               SqlCommand cmd = new SqlCommand("ListaLaboratorioTodo", conn);
               cmd.CommandType = CommandType.StoredProcedure;
               #endregion

               //en este caso no hay parametros


               #region Ejecutar Procedimiento almacenado
               dr = cmd.ExecuteReader();
               #endregion region
               #region caragr data table

               dt.Load(dr);
               #endregion
               dr.Close();
               conn.Close();
               return dt;
           }
           catch (Exception)
           {

               throw;
           }
       }

       */


        public DataTable CargaFormularioLaboratorio(string LaboratorioID)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr = null;
            try
            {
                #region Paso 1: Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();//aqui abro la conexion a la bd
                #endregion
                #region Paso 2: Llamar al Procedimiento Almacenado
                SqlCommand cmd = new SqlCommand("CargaLaboratorioFormulario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso 3: Pasar Parametros en este caso solo hay 1 parametro
                cmd.Parameters.Add("@LaboratorioID", SqlDbType.Int);
                cmd.Parameters["@LaboratorioID"].Value = LaboratorioID;
                #endregion
                #region Paso 4: Ejecutar el Procedimiento
                dr = cmd.ExecuteReader();//siempre que el procedimiento sea un select
                #endregion
                #region Paso 5: Cargar el DataTable con lo que viene desde la B.D
                dt.Load(dr);
                #endregion
                #region Paso 6: Cerrar Conexion
                dr.Close();
                conn.Close();
                #endregion

                return dt;
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }


        public DataTable CargaComboEstudiante(string ModuloID)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr = null;
            try
            {
                conn = new SqlConnection(miConexion);
                conn.Open();//aqui abro la conexion a la bd

                SqlCommand cmd = new SqlCommand("ListaEstudiante", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ModuloID", SqlDbType.Int);
                cmd.Parameters["@ModuloID"].Value = ModuloID;

                dr = cmd.ExecuteReader();
                dt.Load(dr);

                dr.Close();
                conn.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;


        }




       
        public string InsertaLaboratorio(string Capacidad,
                                                string Piso,
                                          bool chbInformatica)
        {
            string Mensaje;
            try
            {
                conn = new SqlConnection(miConexion);
                conn.Open(); //Aqui abro la conexion a la base de datos

                SqlCommand cmd = new SqlCommand("InsertaLaboratorio", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CapasidadLaboratorio", SqlDbType.VarChar, 255);
                cmd.Parameters["@CapasidadLaboratorio"].Value = Capacidad;

                cmd.Parameters.Add("@pisoLaboratorio", SqlDbType.VarChar, 255);
                cmd.Parameters["@pisoLaboratorio"].Value = Piso;

                cmd.Parameters.Add("@esinformatica", SqlDbType.Bit);
                cmd.Parameters["@esinformatica"].Value = chbInformatica;

                cmd.ExecuteNonQuery();
                Mensaje = "Datos Insertados Correctamente";
                conn.Close();
                return Mensaje;


            }
            catch (Exception)
            {

                throw;
            }

        }

        /*clase del 03 de octubre*/

        //metodo actualizar
        public string ActualizarLaboratorio(string LaboratorioID,//este metodo funcionaa
                                            string Capacidad,
                                            string Piso,
                                            bool chbInformatica)
        {
            string Mensaje = "";
            try
            {
                //1.abrir conexion
                conn = new SqlConnection(miConexion);
                conn.Open(); //Aqui abro la conexion a la base de datos
                //2.LLAMO AL PROCEDIMIETO
                SqlCommand cmd = new SqlCommand("ActualizarLaboratorio", conn);//nombre del prcedimiento listo
                cmd.CommandType = CommandType.StoredProcedure;
                //3.PASO PARAMETROS
                cmd.Parameters.Add("@LaboratorioID", SqlDbType.Int);
                cmd.Parameters["@LaboratorioID"].Value = LaboratorioID;

                cmd.Parameters.Add("@Capacidad", SqlDbType.VarChar, 255);
                cmd.Parameters["@Capacidad"].Value = Capacidad;

                cmd.Parameters.Add("@Piso", SqlDbType.VarChar, 255);
                cmd.Parameters["@Piso"].Value = Piso;

                cmd.Parameters.Add("@esInformatica", SqlDbType.Bit);
                cmd.Parameters["@esInformatica"].Value = chbInformatica;
                //4 ejecutar procedimiento
                cmd.ExecuteNonQuery();//siempre de quese un insert/update/delete
                //paso 5 mensjae
                //mensaje
                Mensaje = "datos actualizados correctamente.";
                //paso 6 = cerra conexion
                conn.Close();
                //return mensjae
                return Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
        }




        //fin clase 3 de oct


        //tarea del 03 oct
        public DataTable CargarFormularioModulo(string ModuloID)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr = null;
            try
            {
                #region Paso 1: Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();//aqui abro la conexion a la bd
                #endregion
                #region Paso 2: Llamar al Procedimiento Almacenado
                SqlCommand cmd = new SqlCommand("CargarModuloFormulario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso 3: Pasar Parametros
                cmd.Parameters.Add("@ModuloID", SqlDbType.Int);
                cmd.Parameters["@ModuloID"].Value = ModuloID;
                #endregion
                #region Paso 4: Ejecutar el Procedimiento
                dr = cmd.ExecuteReader();//siempre que el procedimiento sea un select
                #endregion
                #region Paso 5: Cargar el DataTable con lo que viene desde la B.D
                dt.Load(dr);
                #endregion
                #region Paso 6: Cerrar Conexion
                dr.Close();
                conn.Close();
                #endregion

                return dt;
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }


        public string ActualizaModulo(string ModuloID,
                                       string ModuloNombre,
                                       string ModuloCodigo,
                                       bool chbModuloActivo)
        {
                string Mensaje = "";
                try
                {
                    //1.abrir conexion
                    conn = new SqlConnection(miConexion);
                    conn.Open(); //Aqui abro la conexion a la base de datos
                                 //2.LLAMO AL PROCEDIMIETO
                    SqlCommand cmd = new SqlCommand("ActualizarModulo", conn);//nombre del prcedimiento listo
                    cmd.CommandType = CommandType.StoredProcedure;
                    //3.PASO PARAMETROS
                    cmd.Parameters.Add("@mod_moduloId", SqlDbType.Int);
                    cmd.Parameters["@mod_moduloId"].Value = ModuloID;

                    cmd.Parameters.Add("@mod_nombre", SqlDbType.VarChar, 255);
                    cmd.Parameters["@mod_nombre"].Value = ModuloNombre;

                    cmd.Parameters.Add("@mod_codigo", SqlDbType.VarChar, 255);
                    cmd.Parameters["@mod_codigo"].Value = ModuloCodigo;

                    cmd.Parameters.Add("@mod_Activo", SqlDbType.Bit);
                    cmd.Parameters["@mod_Activo"].Value = chbModuloActivo;
                    //4 ejecutar procedimiento
                    cmd.ExecuteNonQuery();//siempre de quese un insert/update/delete
                                          //paso 5 mensjae
                                          //mensaje
                    Mensaje = "datos actualizados correctamente.";

                    //paso 6 = cerra conexion
                    conn.Close();
                    //return mensjae
                    return Mensaje;
                }
                catch (Exception)
                {

                    throw;
                }
        }
            

    




        /*

        public DataTable CargaComboLaboratorios()
        {
            DataTable dt = new DataTable();
            SqlDataReader dr = null;
            try
            {
                #region Abrir la coneccion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion

                #region Llamada al procedimiento Almacenado
                SqlCommand cmd = new SqlCommand("ListaLaboratorioTodo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion

                //en este caso no hay parametros


                #region Ejecutar Procedimiento almacenado
                dr = cmd.ExecuteReader();
                #endregion region
                #region caragr data table

                dt.Load(dr);
                #endregion
                dr.Close();
                conn.Close();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        */


        //data gridviw grilla

        public DataTable CargaEnGrilla()//   <----ME FALTA AQUI DEBE AÑADIR LOS DATOS
        {
            DataTable grilla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                #region Paso 1: Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();//aqui abro la conexion a la bd
                #endregion
                #region Paso 2: lalmo al procedimeitno
                SqlCommand cmd = new SqlCommand("CARGAGRILLA", conn);//nombre del prcedimiento listo
                cmd.CommandType = CommandType.StoredProcedure;
                //en este caso no hay prametros porwuqe paso todos los datos
                #endregion

                #region
                dr = cmd.ExecuteReader();//simpre que un prc. sea un select
                #endregion

                #region cago el dt table
                grilla.Load(dr);
                #endregion

                dr.Close();
                conn.Close();

                return grilla;
            }
            catch (Exception)
            {

                throw;
            }

        }



    }
}
