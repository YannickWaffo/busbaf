using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Model
{
    class AdresseIp
    {
        private string ipadr = string.Empty;
        public string GetIpLocal()
        {
            IPHostEntry h = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in h.AddressList)
            {
                if (ip.ToString().Contains("."))
                {
                    ipadr = ip.ToString();
                }
            }

            return ipadr;
        }

        public string renvoieNomMachine()
        {
            string s = Dns.GetHostName();
            return s;
        }
    }
}
