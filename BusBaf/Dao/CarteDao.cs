using BusBaf.Model;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Dao
{
    class CarteDao
    {
        public static void save(Carte carte)
        {
            if (carte.Id == 0)
            {
                OdbcCommand cmd = new OdbcCommand("insert into carte (Numero,DateCreation,DateExpiration, Type, Code, Porteur, Solde,SoldeMin) values(?,?,?,?,?,?,?,?)", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = carte.Numero;
                cmd.Parameters.Add("@nom", OdbcType.DateTime).Value = carte.DateCreation;
                cmd.Parameters.Add("@prenom", OdbcType.DateTime).Value = carte.DateExpiration;
                cmd.Parameters.Add("@DateNais", OdbcType.VarChar).Value = carte.Type;
                cmd.Parameters.Add("@Telephone", OdbcType.VarChar).Value = carte.Code;
                cmd.Parameters.Add("@porteur", OdbcType.VarChar).Value = carte.Porteur;
                cmd.Parameters.Add("@sol", OdbcType.Double).Value = carte.Solde;
                cmd.Parameters.Add("@min", OdbcType.Double).Value = carte.SoldeMin;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else
            {
                OdbcCommand cmd = new OdbcCommand("update carte set Numero=?,DateCreation=?,DateExpiration=?, Type=?, Code=?, Porteur=?, Solde=?, SoldeMin=? where Id=?", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = carte.Numero;
                cmd.Parameters.Add("@nom", OdbcType.DateTime).Value = carte.DateCreation;
                cmd.Parameters.Add("@prenom", OdbcType.DateTime).Value = carte.DateExpiration;
                cmd.Parameters.Add("@DateNais", OdbcType.VarChar).Value = carte.Type;
                cmd.Parameters.Add("@Telephone", OdbcType.VarChar).Value = carte.Code;
                cmd.Parameters.Add("@porteur", OdbcType.VarChar).Value = carte.Porteur;
                cmd.Parameters.Add("@sol", OdbcType.Double).Value = carte.Solde;
                cmd.Parameters.Add("@min", OdbcType.Double).Value = carte.SoldeMin;
                cmd.Parameters.Add("@id", OdbcType.Int).Value = carte.Id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
        }

        public static void delete(int Id)
        {
            OdbcCommand cmd = new OdbcCommand("delete from carte where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public static void Recharge(Carte carte)
        {
            OdbcCommand cmd = new OdbcCommand("update carte set Solde=? where Numero=?", AccesBd.getConnection());
            cmd.Parameters.Add("@Adresse", OdbcType.Double).Value = carte.Solde;
            cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = carte.Numero;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }


        public static Carte find(int Id)
        {
            Carte carte = null;
            OdbcCommand cmd = new OdbcCommand("select * from carte where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                carte = new Carte { Id = dr.GetInt32(0), Numero = dr.GetString(1), DateCreation = dr.GetDate(2), DateExpiration = dr.GetDate(3), Type = dr.GetString(4), Code = dr.GetString(5), Porteur = dr.GetString(6), Solde = dr.GetInt32(7), SoldeMin = dr.GetInt32(8) };
            }
            cmd.Dispose();
            return carte;
        }

        public static Carte findByNumero(string numero)
        {
            Carte carte = null;
            OdbcCommand cmd = new OdbcCommand("select * from carte where Numero=?", AccesBd.getConnection());
            cmd.Parameters.Add("@numero", OdbcType.VarChar).Value = numero;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                carte = new Carte { Id = dr.GetInt32(0), Numero = dr.GetString(1), DateCreation = dr.GetDate(2), DateExpiration = dr.GetDate(3), Type = dr.GetString(4), Code = dr.GetString(5), Porteur = dr.GetString(6), Solde = dr.GetInt32(7), SoldeMin = dr.GetInt32(8) };
            }
            cmd.Dispose();
            return carte;
        }


        public static List<Carte> findAll()
        {
            List<Carte> cartes = new List<Carte>();
            OdbcCommand cmd = new OdbcCommand("select Id from carte", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Carte carte = find(dr.GetInt32(0));
                cartes.Add(carte);
            }
            cmd.Dispose();
            return cartes;
        }

        public static List<Carte> findby(string tab, string val)
        {
            List<Carte> cartes = new List<Carte>();
            OdbcCommand cmd = new OdbcCommand("select Id from Carte where " + tab + " LIKE('%" + val + "%') ", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Carte chau = find(dr.GetInt32(0));
                cartes.Add(chau);
            }
            cmd.Dispose();
            return cartes;
        }


        public static string generateKey()
        {
            int nbr = 0;
            string lastNumero = "";
            OdbcCommand cmd = new OdbcCommand("select count(*) from carte", AccesBd.getConnection());
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
                OdbcCommand cmd2 = new OdbcCommand("Select max(Numero) from carte", AccesBd.getConnection());
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
