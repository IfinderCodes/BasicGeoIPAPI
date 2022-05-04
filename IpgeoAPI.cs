using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IpgeoAPI
{
    class IpgeoAPI
    {
        public static IpgeoClass getIPcountry(string ip)
        {
            WebClient wc = new WebClient();

            IpgeoClass country = JsonConvert.DeserializeObject<IpgeoClass>(wc.DownloadString($"https://api.iplocation.net/?cmd=ip-country&ip={ip}"));

            return country;
        }
    }
}
