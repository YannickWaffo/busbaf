using BusBaf.Model;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Dao
{
    class PaiementDao
    {
        public static void save(Paiement paiement)
        {
            if (paiement.Id == 0)
            {
                OdbcCommand cmd = new OdbcCommand("insert into paiement (Montant,Description,Date, Lieu) values(?,?,?,?)", AccesBd.getConnection());
                cmd.Parameters.Add("@Montant", OdbcType.VarChar).Value = paiement.Montant;
                cmd.Parameters.Add("@Description", OdbcType.VarChar).Value = paiement.Description;
                cmd.Parameters.Add("@Date", OdbcType.DateTime).Value = paiement.Date;
                cmd.Parameters.Add("@Lieu", OdbcType.VarChar).Value = paiement.Lieu;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else
            {
                OdbcCommand cmd = new OdbcCommand("update paiement set Montant=?,DateCreation=?,Date=?, Type=? where Id=?", AccesBd.getConnection());
                cmd.Parameters.Add("@Montant", OdbcType.VarChar).Value = paiement.Montant;
                cmd.Parameters.Add("@Description", OdbcType.VarChar).Value = paiement.Description;
                cmd.Parameters.Add("@Date", OdbcType.DateTime).Value = paiement.Date;
                cmd.Parameters.Add("@Lieu", OdbcType.VarChar).Value = paiement.Lieu;
                cmd.Parameters.Add("@id", OdbcType.Int).Value = paiement.Id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
        }

        public static void delete(int Id)
        {
            OdbcCommand cmd = new OdbcCommand("delete from paiement where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public static Paiement find(int Id)
        {
            Paiement paiement = null;
            OdbcCommand cmd = new OdbcCommand("select * from paiement where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                paiement = new Paiement { Id = dr.GetInt32(0), Montant = dr.GetInt32(1), Description = dr.GetString(2), Date = dr.GetDateTime(3), Lieu = dr.GetString(4) };
            }
            cmd.Dispose();
            return paiement;
        }

        public static List<Paiement> findAll()
        {
            List<Paiement> paiements = new List<Paiement>();
            OdbcCommand cmd = new OdbcCommand("select Id from paiement", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Paiement paiement = find(dr.GetInt32(0));
                paiements.Add(paiement);
            }
            cmd.Dispose();
            return paiements;
        }

        public static string generateKey()
        {
            int nbr = 0;
            string lastNumero = "";
            OdbcCommand cmd = new OdbcCommand("select count(*) from paiement", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { nbr = dr.GetInt32(0); }
            cmd.Dispose();

            if (nbr == 0)
            {
                lastNumero = "PAI00001";
            }
            else
            {
                OdbcCommand cmd2 = new OdbcCommand("Select max(Numero) from paiement", AccesBd.getConnection());
                OdbcDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                { lastNumero = dr2.GetString(0); }
                cmd.Dispose();
                lastNumero = lastNumero.Substring(3);
                int lastnbr = int.Parse(lastNumero);
                lastnbr++;
                lastNumero = "PAI" + string.Format("{0:D5}", lastnbr);
            }

            return lastNumero;
        }


    }
}
