using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tecnica.Models;

namespace tecnica.Data
{
    public class Estudiantecs
    {
        //agreagamos la clase que guardara los datos de los sp
        public static bool Registrar(Estudiante Oestudiante)
        {
            using (SqlConnection Oconexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("Sp_insert_estudiante", Oconexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ap", Oestudiante.ApellidoP);
                cmd.Parameters.AddWithValue("@am", Oestudiante.ApellidoM);
                cmd.Parameters.AddWithValue("@nombre", Oestudiante.Nombres);
                cmd.Parameters.AddWithValue("@ciudad", Oestudiante.Ciudad);
                cmd.Parameters.AddWithValue("@direccion", Oestudiante.Direccion);

                try
                {
                    Oconexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }


        public static bool Modificar(Estudiante Oestudiante)
        {
            using (SqlConnection Oconexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_modificar_estudiante", Oconexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Oestudiante.Id);
                cmd.Parameters.AddWithValue("@ap", Oestudiante.ApellidoP);
                cmd.Parameters.AddWithValue("@am", Oestudiante.ApellidoM);
                cmd.Parameters.AddWithValue("@nombre", Oestudiante.Nombres);
                cmd.Parameters.AddWithValue("@ciudad", Oestudiante.Ciudad);
                cmd.Parameters.AddWithValue("@direccion", Oestudiante.Direccion);

                try
                {
                    Oconexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
    public static List<Estudiante> Listar()
    {
        List<Estudiante> OListar = new List<Estudiante>();
        using (SqlConnection Oconexion = new SqlConnection(Conexion.rutaConexion))
        {
            SqlCommand cmd = new SqlCommand("SP_listar_estudiante", Oconexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                Oconexion.Open();
                cmd.ExecuteNonQuery();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        OListar.Add(new Estudiante()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            ApellidoP = dr["apellidoP"].ToString(),
                            ApellidoM = dr["apellidoM"].ToString(),
                            Nombres = dr["nombres"].ToString(),
                            Ciudad = dr["ciudad"].ToString(),
                            Direccion = dr["direccion"].ToString()
                        });
                    }
                }
                return OListar;
            }

            catch (Exception e)
            {
                return OListar;
            }
        }
    }

        public static List<Estudiante> Obtener(int id)
        {
            List<Estudiante> Oobtener = new List<Estudiante>();
            using (SqlConnection Oconexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_obtner_estudiante", Oconexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_esstudiante", Oconexion);
                try
                {
                    Oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Oobtener.Add(new Estudiante()
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                ApellidoP = dr["apellidoP"].ToString(),
                                ApellidoM = dr["apellidoM"].ToString(),
                                Nombres = dr["nombres"].ToString(),
                                Ciudad = dr["ciudad"].ToString(),
                                Direccion = dr["direccion"].ToString()
                            });
                        }
                    }
                    return Oobtener;
                }

                catch (Exception e)
                {
                    return Oobtener;
                }

            }
        }
    }



}