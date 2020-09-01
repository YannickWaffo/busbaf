using BusBaf.Model;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Dao
{
    class PointDao
    {
        public static void save(Points point)
        {
            if (point.Id == 0)
            {
                OdbcCommand cmd = new OdbcCommand("insert into point (Numero, Description,coordonnee, Etat, Ligne) values(?,?,?,?)", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = point.Numero;
                cmd.Parameters.Add("@Description", OdbcType.VarChar).Value = point.Description;
                cmd.Parameters.Add("@coordonnee", OdbcType.VarChar).Value = point.coordonnee;
                cmd.Parameters.Add("@Etat", OdbcType.VarChar).Value = point.Etat;
                cmd.Parameters.Add("@ligne", OdbcType.VarChar).Value = point.ligne.Numero;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else
            {
                OdbcCommand cmd = new OdbcCommand("update point set Numero=?, Description=?,coordonnee=?,Etat=?,Ligne=? where Id=?", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = point.Numero;
                cmd.Parameters.Add("@Description", OdbcType.VarChar).Value = point.Description;
                cmd.Parameters.Add("@coordonnee", OdbcType.VarChar).Value = point.coordonnee;
                cmd.Parameters.Add("@Etat", OdbcType.VarChar).Value = point.Etat;
                cmd.Parameters.Add("@ligne", OdbcType.VarChar).Value = point.ligne.Numero;
                cmd.Parameters.Add("@id", OdbcType.Int).Value = point.Id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
        }

        public static void delete(int Id)
        {
            OdbcCommand cmd = new OdbcCommand("delete from point where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public static Points find(int Id)
        {
            Points point = null;
            OdbcCommand cmd = new OdbcCommand("select * from point where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                point = new Points { Id = dr.GetInt32(0), Numero = dr.GetString(1), Description = dr.GetString(2), coordonnee = dr.GetString(3), Etat = dr.GetString(4), ligne = LigneDao.findByNumero(dr.GetString(5)) };
            }
            cmd.Dispose();
            return point;
        }

        public static string generateKey()
        {
            int nbr = 0;
            string lastNumero = "";
            OdbcCommand cmd = new OdbcCommand("select count(*) from point", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {nbr = dr.GetInt32(0);}
            cmd.Dispose();

            if(nbr == 0)
            {
                lastNumero =  "pt0001";
            }
            else
            {
                OdbcCommand cmd2 = new OdbcCommand("Select max(Numero) from point", AccesBd.getConnection());
                OdbcDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                { lastNumero = dr2.GetString(0); }
                cmd.Dispose();
                lastNumero = lastNumero.Substring(2);
                int lastnbr = int.Parse(lastNumero);
                lastnbr++;
                lastNumero = "pt" + string.Format("{0:D4}", lastnbr);
            }

            return lastNumero;
        }


        public static Points findByNumero(string numero)
        {
            Points point = null;
            OdbcCommand cmd = new OdbcCommand("select * from point where Numero=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.VarChar).Value = numero;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                point = new Points { Id = dr.GetInt32(0), Numero = dr.GetString(1), Description = dr.GetString(2), coordonnee = dr.GetString(3), Etat = dr.GetString(4), ligne = LigneDao.findByNumero(dr.GetString(5)) };
            }
            cmd.Dispose();
            return point;
        }

        public static List<Points> findRecherche(string valu)
        {
            List<Points> points = new List<Points>();
            OdbcCommand cmd = new OdbcCommand("select ? from point", AccesBd.getConnection());
            cmd.Parameters.Add("@val", OdbcType.VarChar).Value = valu;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Points point = find(dr.GetInt32(0));
                points.Add(point);
            }
            cmd.Dispose();
            return points;
        }


        public static List<Points> findAll()
        {
            List<Points> points = new List<Points>();
            OdbcCommand cmd = new OdbcCommand("select Id from point", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Points point = find(dr.GetInt32(0));
                points.Add(point);
            }
            cmd.Dispose();
            return points;
        }
    }
}
