using System;
using System.Collections.Generic;
using System.Data;

namespace IArkanoid
{
    public static class usuarDAO
    {
        
        public static List<usuar> getLista()
        {
            string sql = "select * from usuar order by score desc";

            DataTable dt = Connection.realizarConsulta(sql);

            List<usuar> lista = new List<usuar>();
            foreach (DataRow fila in dt.Rows)
            {
                usuar u = new usuar();
                u.username = fila[0].ToString();
                u.score = Convert.ToInt32(fila[1].ToString());

                lista.Add(u);
            }
            return lista;
        }
        
        public static void crearNuevo(string username)
        {
            string sql = String.Format(
                "insert into usuar(username) " +
                "values('{0}');",
                username);
            
            Connection.realizarAccion(sql);
        }
        
        public static void actualizarpuntaje(int score, string username)
        {
            string sql = String.Format(
                "update usuar set score={0} where username='{1}';",
                score, username);
            
            Connection.realizarAccion(sql);
        }
        
        public static void eliminar(string username)
        {
            string sql = String.Format(
                "delete from usuar where username ='{0}'; ",
                username);
            
            Connection.realizarAccion(sql);
        }
        
    }
}