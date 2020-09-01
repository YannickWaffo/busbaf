using BusBaf.Model;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Dao
{
    class VersementDao
    {
        public static void save(Versement versement)
        {
            if (versement.Id == 0)
            {
                OdbcCommand cmd = new OdbcCommand("insert into versement (Numero, Montant,Description,Date,Carte,Admin) values(?,?,?,?,?,?)", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = versement.Numero;
                cmd.Parameters.Add("@Montant", OdbcType.Double).Value = versement.Montant;
                cmd.Parameters.Add("@Description", OdbcType.VarChar).Value = versement.Description;
                cmd.Parameters.Add("@Date", OdbcType.DateTime).Value = versement.Date;
                cmd.Parameters.Add("@carte", OdbcType.VarChar).Value = versement.carte.Numero;
                cmd.Parameters.Add("@admin", OdbcType.VarChar).Value = versement.admin.Numero;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else
            {
                OdbcCommand cmd = new OdbcCommand("update versement set Numero=?,Montant=?,Description=?,Date=?,Carte=?,Admin=? where Id=?", AccesBd.getConnection());
                cmd.Parameters.Add("@Date", OdbcType.VarChar).Value = versement.Numero;
                cmd.Parameters.Add("@Montant", OdbcType.Double).Value = versement.Montant;
                cmd.Parameters.Add("@Description", OdbcType.VarChar).Value = versement.Description;
                cmd.Parameters.Add("@Date", OdbcType.DateTime).Value = versement.Date;
                cmd.Parameters.Add("@carte", OdbcType.VarChar).Value = versement.carte.Numero;
                cmd.Parameters.Add("@admin", OdbcType.VarChar).Value = versement.admin.Numero;
                cmd.Parameters.Add("@id", OdbcType.Int).Value = versement.Id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
        }

        public static void delete(int Id)
        {
            OdbcCommand cmd = new OdbcCommand("delete from versement where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public static Versement find(int Id)
        {
            Versement versement = null;
            OdbcCommand cmd = new OdbcCommand("select * from versement where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                versement = new Versement { Id = dr.GetInt32(0), Numero = dr.GetString(1), Montant = dr.GetDouble(3), Description = dr.GetString(2), Date = dr.GetDateTime(4), carte = CarteDao.findByNumero(dr.GetString(5)), admin = AdminDao.findByNumero(dr.GetString(6)) };
            }
            cmd.Dispose();
            return versement;
        }
        public static Versement findByNumero(string numero)
        {
            Versement versement = null;
            OdbcCommand cmd = new OdbcCommand("select * from versement where Numero=?", AccesBd.getConnection());
            cmd.Parameters.Add("@numero", OdbcType.VarChar).Value = numero;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                versement = new Versement { Id = dr.GetInt32(0), Numero = dr.GetString(1), Montant = dr.GetDouble(3), Description = dr.GetString(2), Date = dr.GetDateTime(4), carte = CarteDao.findByNumero(dr.GetString(5)), admin = AdminDao.findByNumero(dr.GetString(6)) };
            }
            cmd.Dispose();
            return versement;
        }

        public static List<Versement> findAll()
        {
            List<Versement> versements = new List<Versement>();
            OdbcCommand cmd = new OdbcCommand("select Id from versement", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Versement versement = find(dr.GetInt32(0));
                versements.Add(versement);
            }
            cmd.Dispose();
            return versements;
        }

        public static List<Versement> findby(string tab, string val)
        {
            List<Versement> versements = new List<Versement>();
            OdbcCommand cmd = new OdbcCommand("select Id from versement where " + tab + " LIKE('%" + val + "%') ", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Versement chau = find(dr.GetInt32(0));
                versements.Add(chau);
            }
            cmd.Dispose();
            return versements;
        }

        public static string generateKey()
        {
            int nbr = 0;
            string lastNumero = "";
            OdbcCommand cmd = new OdbcCommand("select count(*) from versement", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { nbr = dr.GetInt32(0); }
            cmd.Dispose();

            if (nbr == 0)
            {
                lastNumero = "MT0001";
            }
            else
            {
                OdbcCommand cmd2 = new OdbcCommand("Select max(Numero) from versement", AccesBd.getConnection());
                OdbcDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                { lastNumero = dr2.GetString(0); }
                cmd.Dispose();
                lastNumero = lastNumero.Substring(2);
                int lastnbr = int.Parse(lastNumero);
                lastnbr++;
                lastNumero = "MT" + string.Format("{0:D4}", lastnbr);
            }

            return lastNumero;
        }

    }
}
