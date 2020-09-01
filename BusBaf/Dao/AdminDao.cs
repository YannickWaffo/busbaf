using BusBaf.Model;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Dao
{
    class AdminDao
    {
        public static void save(Admin administrateur)
        {
            if (administrateur.Id == 0)
            {
                OdbcCommand cmd = new OdbcCommand("insert into administrateur (Numero,Nom,Prenom,User, Password) values(?,?,?,?,?)", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = administrateur.Numero;
                cmd.Parameters.Add("@nom", OdbcType.VarChar).Value = administrateur.Nom;
                cmd.Parameters.Add("@prenom", OdbcType.VarChar).Value = administrateur.Prenom;
                cmd.Parameters.Add("@UserName", OdbcType.VarChar).Value = administrateur.UserName;
                cmd.Parameters.Add("@Password", OdbcType.VarChar).Value = administrateur.Password;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else
            {
                OdbcCommand cmd = new OdbcCommand("update administrateur set Numero=?,Nom=?,Prenom=?, User=?, Password=? where Id=?", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = administrateur.Numero;
                cmd.Parameters.Add("@nom", OdbcType.VarChar).Value = administrateur.Nom;
                cmd.Parameters.Add("@prenom", OdbcType.VarChar).Value = administrateur.Prenom;
                cmd.Parameters.Add("@UserName", OdbcType.VarChar).Value = administrateur.UserName;
                cmd.Parameters.Add("@Password", OdbcType.VarChar).Value = administrateur.Password;
                cmd.Parameters.Add("@id", OdbcType.Int).Value = administrateur.Id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
        }

        public static void delete(int Id)
        {
            OdbcCommand cmd = new OdbcCommand("delete from administrateur where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public static Admin find(int Id)
        {
            Admin administrateur = null;
            OdbcCommand cmd = new OdbcCommand("select * from administrateur where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                administrateur = new Admin { Id = dr.GetInt32(0), Numero = dr.GetString(1), Nom = dr.GetString(2), Prenom = dr.GetString(3), UserName = dr.GetString(4), Password = dr.GetString(5) };
            }
            cmd.Dispose();
            return administrateur;
        }

        public static Admin findByNumero(string numero)
        {
            Admin administrateur = null;
            OdbcCommand cmd = new OdbcCommand("select * from administrateur where Numero=?", AccesBd.getConnection());
            cmd.Parameters.Add("@numero", OdbcType.VarChar).Value = numero;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                administrateur = new Admin { Id = dr.GetInt32(0), Numero = dr.GetString(1), Nom = dr.GetString(2), Prenom = dr.GetString(3),UserName = dr.GetString(4), Password = dr.GetString(5) };
            }
            cmd.Dispose();
            return administrateur;
        }


        public static Admin findUser(string user, string pass)
        {
            Admin administrateur = null;
            OdbcCommand cmd = new OdbcCommand("select * from administrateur where User=? and Password=? ", AccesBd.getConnection());
            cmd.Parameters.Add("@numero", OdbcType.VarChar).Value = user;
            cmd.Parameters.Add("@pass", OdbcType.VarChar).Value = pass;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                administrateur = new Admin { Id = dr.GetInt32(0), Numero = dr.GetString(1), Nom = dr.GetString(2), Prenom = dr.GetString(3),UserName = dr.GetString(4), Password = dr.GetString(5) };
            }
            cmd.Dispose();
            return administrateur;
        }

        public static List<Admin> findAll()
        {
            List<Admin> administrateurs = new List<Admin>();
            OdbcCommand cmd = new OdbcCommand("select Id from administrateur", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Admin administrateur = find(dr.GetInt32(0));
                administrateurs.Add(administrateur);
            }
            cmd.Dispose();
            return administrateurs;
        }


        public static string generateKey()
        {
            int nbr = 0;
            string lastNumero = "";
            OdbcCommand cmd = new OdbcCommand("select count(*) from administrateur", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { nbr = dr.GetInt32(0); }
            cmd.Dispose();

            if (nbr == 0)
            {
                lastNumero = "ADM001";
            }
            else
            {
                OdbcCommand cmd2 = new OdbcCommand("Select max(Numero) from administrateur", AccesBd.getConnection());
                OdbcDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                { lastNumero = dr2.GetString(0); }
                cmd.Dispose();
                lastNumero = lastNumero.Substring(3);
                int lastnbr = int.Parse(lastNumero);
                lastnbr++;
                lastNumero = "ADM" + string.Format("{0:D3}", lastnbr);
            }

            return lastNumero;
        }
    }
}
