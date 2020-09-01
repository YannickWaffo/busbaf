using BusBaf.Model;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Dao
{
    class DroitDao
    {
        public static void save(Droits droits)
        {
            if (droits.Id == 0)
            {
                OdbcCommand cmd = new OdbcCommand("insert into droits (admin,Tables,Consulter, Ajouter, Modifier, Supprimer) values(?,?,?,?,?,?)", AccesBd.getConnection());
                cmd.Parameters.Add("@Admin", OdbcType.VarChar).Value = droits.admin.Numero;
                cmd.Parameters.Add("@table", OdbcType.VarChar).Value = droits.Table;
                cmd.Parameters.Add("@Consult", OdbcType.VarChar).Value = droits.Consulter;
                cmd.Parameters.Add("@ajou", OdbcType.VarChar).Value = droits.Ajouter;
                cmd.Parameters.Add("@modif", OdbcType.VarChar).Value = droits.Modifier;
                cmd.Parameters.Add("@Suppri", OdbcType.VarChar).Value = droits.Supprimer;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else
            {
                OdbcCommand cmd = new OdbcCommand("update droits set admin=?,tables=?,consulter=?, ajouter=?, modifier=?, supprimer=? where Id=?", AccesBd.getConnection());
                cmd.Parameters.Add("@Admin", OdbcType.VarChar).Value = droits.admin.Numero;
                cmd.Parameters.Add("@table", OdbcType.VarChar).Value = droits.Table;
                cmd.Parameters.Add("@Consult", OdbcType.VarChar).Value = droits.Consulter;
                cmd.Parameters.Add("@ajou", OdbcType.VarChar).Value = droits.Ajouter;
                cmd.Parameters.Add("@modif", OdbcType.VarChar).Value = droits.Modifier;
                cmd.Parameters.Add("@Suppri", OdbcType.VarChar).Value = droits.Supprimer;
                cmd.Parameters.Add("@id", OdbcType.Int).Value = droits.Id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
        }

        public static void delete(int Id)
        {
            OdbcCommand cmd = new OdbcCommand("delete from droits where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public static Droits find(int Id)
        {
            Droits droits = null;
            OdbcCommand cmd = new OdbcCommand("select * from droits where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                droits = new Droits { Id = dr.GetInt32(0), admin = AdminDao.findByNumero(dr.GetString(1)), Table = dr.GetString(2), Consulter = dr.GetString(3), Ajouter = dr.GetString(4), Modifier = dr.GetString(5), Supprimer = dr.GetString(6) };
            }
            cmd.Dispose();
            return droits;
        }

        public static Droits findByNumero(string numero)
        {
            Droits droits = null;
            OdbcCommand cmd = new OdbcCommand("select * from droits where Numero=?", AccesBd.getConnection());
            cmd.Parameters.Add("@numero", OdbcType.VarChar).Value = numero;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                droits = new Droits { Id = dr.GetInt32(0), admin = AdminDao.findByNumero(dr.GetString(1)), Table = dr.GetString(2), Consulter = dr.GetString(3), Ajouter = dr.GetString(4), Modifier = dr.GetString(5), Supprimer = dr.GetString(6) };
            }
            cmd.Dispose();
            return droits;
        }

        public static Droits findAdmin(string Admin)
        {
            Droits droits = null;
            OdbcCommand cmd = new OdbcCommand("select * from droits where admin=?", AccesBd.getConnection());
            cmd.Parameters.Add("@numero", OdbcType.VarChar).Value = Admin;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                droits = new Droits { Id = dr.GetInt32(0), admin = AdminDao.findByNumero(dr.GetString(1)), Table = dr.GetString(2), Consulter = dr.GetString(3), Ajouter = dr.GetString(4), Modifier = dr.GetString(5), Supprimer = dr.GetString(6) };
            }
            cmd.Dispose();
            return droits;
        }


        public static List<Droits> findAll()
        {
            List<Droits> droitss = new List<Droits>();
            OdbcCommand cmd = new OdbcCommand("select Id from droits", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Droits droits = find(dr.GetInt32(0));
                droitss.Add(droits);
            }
            cmd.Dispose();
            return droitss;
        }

        public static bool findDroit(string Admin, String tab, String drit)
        {
            bool atr = false;
            //OdbcCommand cmd = new OdbcCommand("select Ajouter from droits where ((admin='ADM001') and (Tables = 'Bus'))", AccesBd.getConnection());
            OdbcCommand cmd = new OdbcCommand("select "+drit+" from droits where ((admin=?) and (Tables=?))", AccesBd.getConnection());
            cmd.Parameters.Add("@numero", OdbcType.VarChar).Value = Admin;
            cmd.Parameters.Add("@fgfg", OdbcType.VarChar).Value = tab;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if(dr.GetString(0) == "O" || dr.GetString(0) == "o")
                {
                    atr = true;
                }
            }
            cmd.Dispose();
            return atr;
        }


        public static string generateKey()
        {
            int nbr = 0;
            string lastNumero = "";
            OdbcCommand cmd = new OdbcCommand("select count(*) from droits", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { nbr = dr.GetInt32(0); }
            cmd.Dispose();

            if (nbr == 0)
            {
                lastNumero = "CAR00001";
            }
            else
            {
                OdbcCommand cmd2 = new OdbcCommand("Select max(Numero) from droits", AccesBd.getConnection());
                OdbcDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                { lastNumero = dr2.GetString(0); }
                cmd.Dispose();
                lastNumero = lastNumero.Substring(3);
                int lastnbr = int.Parse(lastNumero);
                lastnbr++;
                lastNumero = "CAR" + string.Format("{0:D5}", lastnbr);
            }

            return lastNumero;
        }

    }
}
