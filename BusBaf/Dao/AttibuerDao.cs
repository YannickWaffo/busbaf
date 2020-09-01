using BusBaf.Model;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Dao
{
    class AttibuerDao
    {
        public static void save(Attribuer attribuer)
        {
            if (attribuer.Id == 0)
            {
                OdbcCommand cmd = new OdbcCommand("insert into attribuer (Numero, DateDebut,DateFin,id_bus,id_chauffeur) values(?,?,?,?,?)", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = attribuer.Numero;
                cmd.Parameters.Add("@DateDebut", OdbcType.DateTime).Value = attribuer.DateDebut;
                cmd.Parameters.Add("@DateFin", OdbcType.DateTime).Value = attribuer.DateFin;
                cmd.Parameters.Add("@idbus", OdbcType.VarChar).Value = attribuer.bus.Numero;
                cmd.Parameters.Add("@idchau", OdbcType.VarChar).Value = attribuer.chauffeur.Numero;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else
            {
                OdbcCommand cmd = new OdbcCommand("update attribuer set Numero=?,DateDebut=?,DateFin=?,id_bus=?,id_chauffeur=? where Id=?", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = attribuer.Numero;
                cmd.Parameters.Add("@DateDebut", OdbcType.DateTime).Value = attribuer.DateDebut;
                cmd.Parameters.Add("@DateFin", OdbcType.DateTime).Value = attribuer.DateFin;
                cmd.Parameters.Add("@idbus", OdbcType.VarChar).Value = attribuer.bus.Numero;
                cmd.Parameters.Add("@idchau", OdbcType.VarChar).Value = attribuer.chauffeur.Numero;
                cmd.Parameters.Add("@id", OdbcType.Int).Value = attribuer.Id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
        }

        public static void delete(int Id)
        {
            OdbcCommand cmd = new OdbcCommand("delete from attribuer where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public static Attribuer find(int Id)
        {
            Attribuer attribuer = null;
            OdbcCommand cmd = new OdbcCommand("select * from attribuer where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                attribuer = new Attribuer { Id = dr.GetInt32(0), Numero = dr.GetString(1), DateDebut = dr.GetDateTime(2), DateFin = dr.GetDateTime(3), bus = BusDao.findByNumero(dr.GetString(4)), chauffeur = ChauffeurDao.findByNumero(dr.GetString(5)) };
            }
            cmd.Dispose();
            return attribuer;
        }
        public static Attribuer findByNumero(string numero)
        {
            Attribuer attribuer = null;
            OdbcCommand cmd = new OdbcCommand("select * from attribuer where Numero=?", AccesBd.getConnection());
            cmd.Parameters.Add("@numero", OdbcType.VarChar).Value = numero;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                attribuer = new Attribuer { Id = dr.GetInt32(0), Numero = dr.GetString(1), DateDebut = dr.GetDateTime(2), DateFin = dr.GetDateTime(3), bus = BusDao.find(dr.GetInt32(4)), chauffeur= ChauffeurDao.find(dr.GetInt32(5)) };
            }
            cmd.Dispose();
            return attribuer;
        }

        public static List<Attribuer> findAll()
        {
            List<Attribuer> attribuers = new List<Attribuer>();
            OdbcCommand cmd = new OdbcCommand("select Id from attribuer", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Attribuer attribuer = find(dr.GetInt32(0));
                attribuers.Add(attribuer);
            }
            cmd.Dispose();
            return attribuers;
        }

        public static string generateKey()
        {
            int nbr = 0;
            string lastNumero = "";
            OdbcCommand cmd = new OdbcCommand("select count(*) from attribuer", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { nbr = dr.GetInt32(0); }
            cmd.Dispose();

            if (nbr == 0)
            {
                lastNumero = "AT001";
            }
            else
            {
                OdbcCommand cmd2 = new OdbcCommand("Select max(Numero) from attribuer", AccesBd.getConnection());
                OdbcDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                { lastNumero = dr2.GetString(0); }
                cmd.Dispose();
                lastNumero = lastNumero.Substring(2);
                int lastnbr = int.Parse(lastNumero);
                lastnbr++;
                lastNumero = "AT" + string.Format("{0:D3}", lastnbr);
            }

            return lastNumero;
        }

    }
}
