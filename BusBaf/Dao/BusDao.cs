using BusBaf.Model;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Dao
{
    class BusDao
    {
        public static void save(Bus bus)
        {
            if (bus.Id == 0)
            {
                OdbcCommand cmd = new OdbcCommand("insert into bus (Numero,Type,Marque, Places, Kilometrage, Puissance, Energie, DateMise, CarteGrise, Chassis) values(?,?,?,?,?,?,?,?,?,?)", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = bus.Numero;
                cmd.Parameters.Add("@Type", OdbcType.VarChar).Value = bus.Type;
                cmd.Parameters.Add("@Marque", OdbcType.VarChar).Value = bus.Marque;
                cmd.Parameters.Add("@Place", OdbcType.VarChar).Value = bus.Place;
                cmd.Parameters.Add("@Kilometrage", OdbcType.VarChar).Value = bus.Kilometrage;
                cmd.Parameters.Add("@Puissance", OdbcType.VarChar).Value = bus.Puissance;
                cmd.Parameters.Add("@Energie", OdbcType.VarChar).Value = bus.Energie;
                cmd.Parameters.Add("@DateMise", OdbcType.DateTime).Value = bus.DateMise;
                cmd.Parameters.Add("@CarteGrise", OdbcType.VarChar).Value = bus.CarteGrise;
                cmd.Parameters.Add("@Chassis", OdbcType.VarChar).Value = bus.Chassis;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else
            {
                OdbcCommand cmd = new OdbcCommand("update bus set Numero=?,Type=?,Marque=?, Places=?, Kilometrage=?, Puissance=?, Energie=?, DateMise=?, CarteGrise=?, Chassis=? where Id=?", AccesBd.getConnection());
                cmd.Parameters.Add("@Numero", OdbcType.VarChar).Value = bus.Numero;
                cmd.Parameters.Add("@Type", OdbcType.VarChar).Value = bus.Type;
                cmd.Parameters.Add("@Marque", OdbcType.VarChar).Value = bus.Marque;
                cmd.Parameters.Add("@Place", OdbcType.VarChar).Value = bus.Place;
                cmd.Parameters.Add("@Kilometrage", OdbcType.VarChar).Value = bus.Kilometrage;
                cmd.Parameters.Add("@Puissance", OdbcType.VarChar).Value = bus.Puissance;
                cmd.Parameters.Add("@Energie", OdbcType.VarChar).Value = bus.Energie;
                cmd.Parameters.Add("@DateMise", OdbcType.DateTime).Value = bus.DateMise;
                cmd.Parameters.Add("@CarteGrise", OdbcType.VarChar).Value = bus.CarteGrise;
                cmd.Parameters.Add("@Chassis", OdbcType.VarChar).Value = bus.Chassis;
                cmd.Parameters.Add("@id", OdbcType.Int).Value = bus.Id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
        }

        public static void delete(int Id)
        {
            OdbcCommand cmd = new OdbcCommand("delete from bus where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public static Bus find(int Id)
        {
            Bus bus = null;
            OdbcCommand cmd = new OdbcCommand("select * from bus where Id=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = Id;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                bus = new Bus { Id = dr.GetInt32(0), Numero = dr.GetString(1), Type=dr.GetString(2), Marque=dr.GetString(3), Place = dr.GetString(4), Kilometrage = dr.GetString(5), Puissance = dr.GetString(6), Energie = dr.GetString(7), DateMise = dr.GetDateTime(9), CarteGrise = dr.GetString(10), Chassis = dr.GetString(11) };
            }
            cmd.Dispose();
            return bus;
        }

        public static Bus findByNumero(string numero)
        {
            Bus bus = null;
            OdbcCommand cmd = new OdbcCommand("select * from bus where Numero=?", AccesBd.getConnection());
            cmd.Parameters.Add("@id", OdbcType.VarChar).Value = numero;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                bus = new Bus { Id = dr.GetInt32(0), Numero = dr.GetString(1), Type = dr.GetString(2), Marque = dr.GetString(3), Place = dr.GetString(4), Kilometrage = dr.GetString(5), Puissance = dr.GetString(6), Energie = dr.GetString(7), DateMise = dr.GetDateTime(9), CarteGrise = dr.GetString(10), Chassis = dr.GetString(11) };
            }
            cmd.Dispose();
            return bus;
        }


        public static List<Bus> findAll()
        {
            List<Bus> buss = new List<Bus>();
            OdbcCommand cmd = new OdbcCommand("select Id from bus", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Bus bus = find(dr.GetInt32(0));
                buss.Add(bus);
            }
            cmd.Dispose();
            return buss;
        }

        public static string generateKey()
        {
            int nbr = 0;
            string lastNumero = "";
            OdbcCommand cmd = new OdbcCommand("select count(*) from bus", AccesBd.getConnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { nbr = dr.GetInt32(0); }
            cmd.Dispose();

            if (nbr == 0)
            {
                lastNumero = "BU001";
            }
            else
            {
                OdbcCommand cmd2 = new OdbcCommand("Select max(Numero) from bus", AccesBd.getConnection());
                OdbcDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                { lastNumero = dr2.GetString(0); }
                cmd.Dispose();
                lastNumero = lastNumero.Substring(2);
                int lastnbr = int.Parse(lastNumero);
                lastnbr++;
                lastNumero = "BU" + string.Format("{0:D3}", lastnbr);
            }

            return lastNumero;
        }
    }
}
