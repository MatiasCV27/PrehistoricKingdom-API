using PrehistoricKingdom_API.Models;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrehistoricKingdom_API.Data
{
    public class EspecieData
    {
        //METODO POST
        public static bool Registrar(Especie oespecie)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Registrar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", oespecie.Nombre);
                cmd.Parameters.AddWithValue("@Significado", oespecie.Significado);
                cmd.Parameters.AddWithValue("@Dieta", oespecie.Dieta);
                cmd.Parameters.AddWithValue("@Peso", oespecie.Peso); 
                cmd.Parameters.AddWithValue("@Periodo", oespecie.Periodo);
                cmd.Parameters.AddWithValue("@Hallazgo", oespecie.Hallazgo);
                cmd.Parameters.AddWithValue("@Dimensiones", oespecie.Dimensiones);
                cmd.Parameters.AddWithValue("@Descripcion", oespecie.Descripcion);
                cmd.Parameters.AddWithValue("@Tiempo", oespecie.Tiempo);
                cmd.Parameters.AddWithValue("@Imagen", oespecie.Imagen);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        //METODO PUT
        public static bool Editar(Especie oespecie)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Editar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEspecie", oespecie.IdEspecie);
                cmd.Parameters.AddWithValue("@Nombre", oespecie.Nombre);
                cmd.Parameters.AddWithValue("@Significado", oespecie.Significado);
                cmd.Parameters.AddWithValue("@Dieta", oespecie.Dieta);
                cmd.Parameters.AddWithValue("@Peso", oespecie.Peso); 
                cmd.Parameters.AddWithValue("@Periodo", oespecie.Periodo);
                cmd.Parameters.AddWithValue("@Hallazgo", oespecie.Hallazgo);
                cmd.Parameters.AddWithValue("@Dimensiones", oespecie.Dimensiones);
                cmd.Parameters.AddWithValue("@Descripcion", oespecie.Descripcion);
                cmd.Parameters.AddWithValue("@Tiempo", oespecie.Tiempo);
                cmd.Parameters.AddWithValue("@Imagen", oespecie.Imagen);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        //METODO GET
        public static List<Especie> Listar()
        {
            List<Especie> oListaEspecie = new List<Especie>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Listar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaEspecie.Add(new Especie()
                            {
                                IdEspecie = Convert.ToInt32(dr["IdEspecie"]),
                                Nombre = dr["Nombre"].ToString(),
                                Significado = dr["Significado"].ToString(),
                                Dieta = dr["Dieta"].ToString(),
                                Peso = dr["Peso"].ToString(),
                                Periodo = dr["Periodo"].ToString(),
                                Hallazgo = dr["Hallazgo"].ToString(),
                                Dimensiones = dr["Dimensiones"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                Tiempo = dr["Tiempo"].ToString(),
                                Imagen = dr["Imagen"].ToString(),
                            });
                        }
                    }
                    return oListaEspecie;
                }
                catch (Exception ex)
                {
                    return oListaEspecie;
                }
            }
        }
        //METODO GET/[ID]
        public static Especie Obtener(int IdEspecie)
        {
            Especie especie = new Especie();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Obtener", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEspecie", IdEspecie);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            especie = new Especie()
                            {
                                IdEspecie = Convert.ToInt32(dr["IdEspecie"]),
                                Nombre = dr["Nombre"].ToString(),
                                Significado = dr["Significado"].ToString(),
                                Dieta = dr["Dieta"].ToString(),
                                Peso = dr["Peso"].ToString(),
                                Periodo = dr["Periodo"].ToString(),
                                Hallazgo = dr["Hallazgo"].ToString(),
                                Dimensiones = dr["Dimensiones"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                Tiempo = dr["Tiempo"].ToString(),
                                Imagen = dr["Imagen"].ToString(),
                            };
                        }
                    }
                    return especie;
                }
                catch (Exception ex)
                {
                    return especie;
                }
            }
        }
        //METODO DELETE
        public static bool Eliminar(int IdEspecie)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Eliminar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEspecie", IdEspecie);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}