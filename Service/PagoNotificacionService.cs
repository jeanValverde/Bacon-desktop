﻿using bacon_desktop.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace bacon_desktop.Service
{
    public class PagoNotificacionService
    {
        private ConnectionBacon connectionBacon;
        private OracleConnection con;
        private OracleCommand cmd;

        public PagoNotificacionService()
        {
            //instacia la conexion a la base de datos  
            connectionBacon = new ConnectionBacon();

            // obtenemos a conexion 
            con = connectionBacon.Connection();

            //para crear hacer sentencias o llamarlas    
            cmd = con.CreateCommand();
        }


        public List<Notificacion> getNotificacionDePago()
        {
            cmd.CommandText = "PACKAGE_NOTIFICACION.PR_LISTAR_DE_PAGO";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("P_NOTIFICACIONES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            List<Notificacion> notificaciones = new List<Notificacion>();

            try
            {

                OracleDataReader reader = cmd.ExecuteReader();


                foreach (var item in reader)
                {

                    Notificacion notificacion = new Notificacion();

                    notificacion.IdNotificacion = reader.GetInt32(0);
                    notificacion.Descripcion = reader.GetString(1);
                    notificacion.Estado = reader.GetInt32(2);
                    Rol rol = new Rol();
                    rol.Id_rol = reader.GetInt32(3);
                    notificacion.Rol = rol;
                    notificacion.Fecha = reader.GetDateTime(4);
                    notificacion.Asunto = reader.GetString(5);

                    notificaciones.Add(notificacion);

                }

                con.Close();

                return notificaciones;


            }
            catch (Exception)
            {
                return notificaciones;
            }
        }



        //
        public List<Notificacion> getNotificacionParaPago()
        {
            cmd.CommandText = "PACKAGE_NOTIFICACION.PR_LISTAR_PARA_PAGO";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("P_NOTIFICACIONES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            List<Notificacion> notificaciones = new List<Notificacion>();

            try
            {

                OracleDataReader reader = cmd.ExecuteReader();


                foreach (var item in reader)
                {

                    Notificacion notificacion = new Notificacion();

                    notificacion.IdNotificacion = reader.GetInt32(0);
                    notificacion.Descripcion = reader.GetString(1);
                    notificacion.Estado = reader.GetInt32(2);
                    Rol rol = new Rol();
                    rol.Id_rol = reader.GetInt32(3);
                    notificacion.Rol = rol;
                    notificacion.Fecha = reader.GetDateTime(4);
                    notificacion.Asunto = reader.GetString(5);

                    notificaciones.Add(notificacion);

                }

                con.Close();

                return notificaciones;


            }
            catch (Exception)
            {
                return notificaciones;
            }
        }



        public List<Notificacion> obtenerTodasNotificacionesOrdenFecha(List<Notificacion> de, List<Notificacion> para)
        {
            List<Notificacion> notificacions = new List<Notificacion>();

            foreach (var item in de)
            {
                notificacions.Add(item);
            }

            foreach (var item in para)
            {
                notificacions.Add(item);
            }

            notificacions = notificacions.OrderByDescending(o => o.Fecha).ToList();

            return notificacions;

        }


        //UPDATE NOTIFY ESTADO 
        public int cambiarEstadoNotificacion(int idNotificacion)
        {
            cmd.CommandText = "PACKAGE_NOTIFICACION.PR_SET_ESTADO_NOTIFY";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("P_ID_NOTIFICACION", OracleDbType.Int32).Value = idNotificacion;

            cmd.Parameters.Add("V_EXITO", OracleDbType.Int32).Direction = ParameterDirection.Output;

            try
            {

                cmd.ExecuteNonQuery();

                int result = int.Parse(cmd.Parameters["V_EXITO"].Value.ToString());

                con.Close();

                return result;

            }
            catch (Exception)
            {
                return -1;
            }
        }

    }
}

