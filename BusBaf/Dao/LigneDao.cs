using BusBaf.Model;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Dao
{
    class LigneDao
    {
        public static void save(Ligne ligne)
        {
            if (ligne.Id == 0)
            {
                OdbcCommand cmd = new OdbcCommand("insert into ligne (Numero,Description,Etat, Distance, PointD, PointF) values(?,?,?,?,?,?)", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = ligne.Numero;
                cmd.Parameters.Add("@Description", OdbcType.VarChar).Value = ligne.Description;
                cmd.Parameters.Add("@Etat", OdbcType.VarChar).Value = ligne.Etat;
                cmd.Parameters.Add("@Distance", OdbcType.VarChar).Value = ligne.Distance;
                cmd.Parameters.Add("@Etat", OdbcType.VarChar).Value = ligne.PointD;
                cmd.Parameters.Add("@Distance", OdbcType.VarChar).Value = ligne.PointF;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else
            {
                OdbcCommand cmd = new OdbcCommand("update ligne set Numero=?,Description=?,Etat=?, Distance=?, PointD=?, PointF=?where Id=?", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = ligne.Numero;
                cmd.Parameters.Add("@Description", OdbcType.VarChar).Value = ligne.Description;
                cmd.Parameters.Add("@Etat", OdbcType.VarChar).Value = ligne.Etat;
                cmd.Parameters.Add("@Distance", OdbcType.VarChar).Value = ligne.Distance;
                cmd.Parameters.Add("@Etat", OdbcType.VarChar).Value = ligne.PointD;
                cmd.Parameters.Add("@Distance", OdbcType.VarChar).Value = ligne.PointF;
                cmd.Parameters.Add("@id", OdbcType.Int).Value = ligne.Id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
        }

        public static void delete(int Id)
        {
            OdbcCommand cmd = new OdbcCommand("delete from ligne where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public static Ligne find(int Id)
        {
            Ligne ligne = null;
            OdbcCommand cmd = new OdbcCommand("select * from ligne where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ligne = new Ligne { Id = dr.GetInt32(0), Numero = dr.GetString(1), Description = dr.GetString(2), Etat = dr.GetString(3), Distance = dr.GetString(4), PointD = dr.GetString(5), PointF = dr.GetString(6) };
            }
            cmd.Dispose();
            return ligne;
        }

        public static Ligne findByNumero(string numero)
        {
            Ligne ligne = null;
            OdbcCommand cmd = new OdbcCommand("select * from ligne where Numero=?", AccesBd.getConnection());
            cmd.Parameters.Add("@numero", OdbcType.VarChar).Value = numero;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ligne = new Ligne { Id = dr.GetInt32(0), Numero = dr.GetString(1), Description = dr.GetString(2), Etat = dr.GetString(3), Distance = dr.GetString(4), PointD = dr.GetString(5), PointF = dr.GetString(6) };
            }
            cmd.Dispose();
            return ligne;
        }

        public static List<Ligne> findAll()
        {
            List<Ligne> lignes = new List<Ligne>();
            OdbcCommand cmd = new OdbcCommand("select Id from ligne", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Ligne ligne = find(dr.GetInt32(0));
                lignes.Add(ligne);
            }
            cmd.Dispose();
            return lignes;
        }

        public static List<Ligne> findby(string tab, string val)
        {
            List<Ligne> lignes = new List<Ligne>();
            OdbcCommand cmd = new OdbcCommand("select Id from ligne where "+ tab +" LIKE('%" +val +"%') ", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Ligne ligne = find(dr.GetInt32(0));
                lignes.Add(ligne);
            }
            cmd.Dispose();
            return lignes;
        }

        public static string generateKey()
        {
            int nbr = 0;
            string lastNumero = "";
            OdbcCommand cmd = new OdbcCommand("select count(*) from ligne", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { nbr = dr.GetInt32(0); }
            cmd.Dispose();

            if (nbr == 0)
            {
                lastNumero = "lig0001";
            }
            else
            {
                OdbcCommand cmd2 = new OdbcCommand("Select max(Numero) from ligne", AccesBd.getConnection());
                OdbcDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                { lastNumero = dr2.GetString(0); }
                cmd.Dispose();
                lastNumero = lastNumero.Substring(3);
                int lastnbr = int.Parse(lastNumero);
                lastnbr++;
                lastNumero = "lig" + string.Format("{0:D4}", lastnbr);
            }

            return lastNumero;
        }
    }
}
