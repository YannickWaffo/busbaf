using BusBaf.Model;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Dao
{
    class AffecterDao
    {
        public static void save(Affecter affecter)
        {
            if (affecter.Id == 0)
            {
                OdbcCommand cmd = new OdbcCommand("insert into affecter (Numero, DateDebut,DateFin,id_ligne,id_bus) values(?,?,?,?,?)", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = affecter.Numero;
                cmd.Parameters.Add("@DateDebut", OdbcType.DateTime).Value = affecter.DateDebut;
                cmd.Parameters.Add("@DateFin", OdbcType.DateTime).Value = affecter.DateFin;
                cmd.Parameters.Add("@idlig", OdbcType.VarChar).Value = affecter.ligne.Numero;
                cmd.Parameters.Add("@idbus", OdbcType.VarChar).Value = affecter.bus.Numero;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else
            {
                OdbcCommand cmd = new OdbcCommand("update affecter Numero=?, DateDebut=?,DateFin=?,id_ligne=?,id_bus=? where Id=?", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = affecter.Numero;
                cmd.Parameters.Add("@DateDebut", OdbcType.DateTime).Value = affecter.DateDebut;
                cmd.Parameters.Add("@DateFin", OdbcType.DateTime).Value = affecter.DateFin;
                cmd.Parameters.Add("@idlig", OdbcType.VarChar).Value = affecter.ligne.Numero;
                cmd.Parameters.Add("@idbus", OdbcType.VarChar).Value = affecter.bus.Numero;
                cmd.Parameters.Add("@id", OdbcType.Int).Value = affecter.Id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
        }

        public static void delete(int Id)
        {
            OdbcCommand cmd = new OdbcCommand("delete from affecter where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public static Affecter find(int Id)
        {
            Affecter affecter = null;
            OdbcCommand cmd = new OdbcCommand("select * from affecter where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                affecter = new Affecter { Id = dr.GetInt32(0),Numero=dr.GetString(1), DateDebut = dr.GetDateTime(2), DateFin = dr.GetDateTime(3), ligne = LigneDao.findByNumero(dr.GetString(4)), bus = BusDao.findByNumero(dr.GetString(5)) };
            }
            cmd.Dispose();
            return affecter;
        }
        public static Affecter findByNumero(string numero)
        {
            Affecter affecter = null;
            OdbcCommand cmd = new OdbcCommand("select * from affecter where Numero=?", AccesBd.getConnection());
            cmd.Parameters.Add("@numero", OdbcType.VarChar).Value = numero;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                affecter = new Affecter { Id = dr.GetInt32(0), Numero = dr.GetString(1), DateDebut = dr.GetDateTime(2), DateFin = dr.GetDateTime(3), ligne = LigneDao.findByNumero(dr.GetString(4)), bus = BusDao.findByNumero(dr.GetString(5)) };
            }
            cmd.Dispose();
            return affecter;
        }

        public static List<Affecter> findAll()
        {
            List<Affecter> affecters = new List<Affecter>();
            OdbcCommand cmd = new OdbcCommand("select Id from affecter", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Affecter affecter = find(dr.GetInt32(0));
                affecters.Add(affecter);
            }
            cmd.Dispose();
            return affecters;
        }

        public static string generateKey()
        {
            int nbr = 0;
            string lastNumero = "";
            OdbcCommand cmd = new OdbcCommand("select count(*) from affecter", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { nbr = dr.GetInt32(0); }
            cmd.Dispose();

            if (nbr == 0)
            {
                lastNumero = "AF001";
            }
            else
            {
                OdbcCommand cmd2 = new OdbcCommand("Select max(Numero) from affecter", AccesBd.getConnection());
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
