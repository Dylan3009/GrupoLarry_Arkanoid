using System;
using System.Collections.Generic;
using System.Data;

namespace IArkanoid
{
    public static class scoresDAO
    {
        
        public static List<user> getLista()
        {
            string sql = "select * from pedidos";

            DataTable dt = Connection.realizarConsulta(sql);

            List<user> lista = new List<user>();
            foreach (DataRow fila in dt.Rows)
            {
                user u = new user();
                u.username = fila[0].ToString();
                u.score = Convert.ToInt32(fila[1].ToString());

                lista.Add(u);
            }
            return lista;
        }
        
        public static void crearNuevo(string username)
        {
            string sql = String.Format(
                "insert into user(username) " +
                "values('{0}');",
                username);
            
            Connection.realizarAccion(sql);
        }
        
        public static void actualizarpuntaje(int score, string username)
        {
            string sql = String.Format(
                "update user set score={0} where username='{1}';",
                score, username);
            
            Connection.realizarAccion(sql);
        }
        
        public static void eliminar(string username)
        {
            string sql = String.Format(
                "delete from user where username ='{0}'; ",
                username);
            
            Connection.realizarAccion(sql);
        }
        
    }
}