using BusBaf.Model;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Dao
{
    class ChauffeurDao
    {
        public static void save(Chauffeur chauffeur)
        {
            if (chauffeur.Id == 0)
            {
                OdbcCommand cmd = new OdbcCommand("insert into chauffeur (Numero,Nom,Prenom, DateNaissance, Telephone, Adresse, Permis, Status) values(?,?,?,?,?,?,?,?)", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = chauffeur.Numero;
                cmd.Parameters.Add("@nom", OdbcType.VarChar).Value = chauffeur.Nom;
                cmd.Parameters.Add("@prenom", OdbcType.VarChar).Value = chauffeur.Prenom;
                cmd.Parameters.Add("@DateNais", OdbcType.DateTime).Value = chauffeur.DateNais;
                cmd.Parameters.Add("@Telephone", OdbcType.VarChar).Value = chauffeur.Telephone;
                cmd.Parameters.Add("@Adresse", OdbcType.VarChar).Value = chauffeur.Adresse;
                cmd.Parameters.Add("@Adresse", OdbcType.VarChar).Value = chauffeur.Permis;
                cmd.Parameters.Add("@Status", OdbcType.VarChar).Value = chauffeur.Status;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else
            {
                OdbcCommand cmd = new OdbcCommand("update chauffeur set Numero=?,Nom=?,Prenom=?, DateNaissance=?, Telephone=?, Adresse=?, Permis=?, Status=? where Id=?", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = chauffeur.Numero;
                cmd.Parameters.Add("@nom", OdbcType.VarChar).Value = chauffeur.Nom;
                cmd.Parameters.Add("@prenom", OdbcType.VarChar).Value = chauffeur.Prenom;
                cmd.Parameters.Add("@DateNais", OdbcType.DateTime).Value = chauffeur.DateNais;
                cmd.Parameters.Add("@Telephone", OdbcType.VarChar).Value = chauffeur.Telephone;
                cmd.Parameters.Add("@Adresse", OdbcType.VarChar).Value = chauffeur.Adresse;
                cmd.Parameters.Add("@Adresse", OdbcType.VarChar).Value = chauffeur.Permis;
                cmd.Parameters.Add("@Status", OdbcType.VarChar).Value = chauffeur.Status;
                cmd.Parameters.Add("@id", OdbcType.Int).Value = chauffeur.Id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
        }

        public static void delete(int Id)
        {
            OdbcCommand cmd = new OdbcCommand("delete from chauffeur where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public static Chauffeur find(int Id)
        {
            Chauffeur chauffeur = null;
            OdbcCommand cmd = new OdbcCommand("select * from chauffeur where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                chauffeur = new Chauffeur { Id = dr.GetInt32(0), Numero = dr.GetString(1), Nom = dr.GetString(2), Prenom = dr.GetString(3), DateNais = dr.GetDate(4), Telephone = dr.GetString(5), Adresse = dr.GetString(6), Permis = dr.GetString(6), Status = dr.GetString(7) };
            }
            cmd.Dispose();
            return chauffeur;
        }

        public static Chauffeur findByNumero(string Numero)
        {
            Chauffeur chauffeur = null;
            OdbcCommand cmd = new OdbcCommand("select * from chauffeur where Numero=?", AccesBd.getConnection());
            cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = Numero;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                chauffeur = new Chauffeur { Id = dr.GetInt32(0), Numero = dr.GetString(1), Nom = dr.GetString(2), Prenom = dr.GetString(3), DateNais = dr.GetDate(4), Telephone = dr.GetString(5), Adresse = dr.GetString(6), Permis = dr.GetString(6), Status = dr.GetString(7) };
            }
            cmd.Dispose();
            return chauffeur;
        }

        public static List<Chauffeur> findAll()
        {
            List<Chauffeur> chauffeurs = new List<Chauffeur>();
            OdbcCommand cmd = new OdbcCommand("select Id from chauffeur", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Chauffeur chauffeur = find(dr.GetInt32(0));
                chauffeurs.Add(chauffeur);
            }
            cmd.Dispose();
            return chauffeurs;
        }

        public static List<Chauffeur> findby(string tab, string val)
        {
            List<Chauffeur> chauffeurs = new List<Chauffeur>();
            OdbcCommand cmd = new OdbcCommand("select Id from chauffeur where " + tab + " LIKE('%" + val + "%') ", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Chauffeur chau = find(dr.GetInt32(0));
                chauffeurs.Add(chau);
            }
            cmd.Dispose();
            return chauffeurs;
        }


        public static string generateKey()
        {
            int nbr = 0;
            string lastNumero = "";
            OdbcCommand cmd = new OdbcCommand("select count(*) from chauffeur", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { nbr = dr.GetInt32(0); }
            cmd.Dispose();

            if (nbr == 0)
            {
                lastNumero = "CHAU0001";
            }
            else
            {
                OdbcCommand cmd2 = new OdbcCommand("Select max(Numero) from chauffeur", AccesBd.getConnection());
                OdbcDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                { lastNumero = dr2.GetString(0); }
                cmd.Dispose();
                lastNumero = lastNumero.Substring(4);
                int lastnbr = int.Parse(lastNumero);
                lastnbr++;
                lastNumero = "CHAU" + string.Format("{0:D4}", lastnbr);
            }

            return lastNumero;
        }

    }
}
