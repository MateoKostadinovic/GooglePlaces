using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Data.Common;
using System.Data.SqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CRUD;


namespace REST
{
    public class Rest
    {
        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            //webrequest.Headers.Add("Username", "xyz");
            //webrequest.Headers.Add("Password", "abc");
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(),
            enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }

        public string GetURL(string city, string type, float radius)
        {
            StringBuilder oStringBuilder = new StringBuilder();
            string endpoint = ConfigurationManager.AppSettings["GooglePlacesAPI"];
            
            float fCityLat;
            float fCityLng;
            string sSqlConnectionString = ConfigurationManager.AppSettings["GooglePlacesUrl"];//fali mi ovo u app
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT * FROM GooglePlaces_cities WHERE NAME = '" + city + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    fCityLat = 45;
                    fCityLng = 17;
                }
            }
            oStringBuilder.Append(endpoint + "?location=" + fCityLat + "," + fCityLng + "&radius=" + radius + "&type=" + type + "&key=AIzaSyAGoeeEBe7hme9iWAnP_1a_XKCP544ar4I");
            Trace.WriteLine(oStringBuilder.ToString());
            return oStringBuilder.ToString();
        }

        public List<GooglePlacesView> GetPlaces(string city, string type, float radius)
        {
            string sUrl = GetURL(city, type, radius);
            string sJson = CallRestMethod(sUrl);

            JObject oJson = JObject.Parse(sJson);
            var oPlaces = oJson["results"].ToList();
            //var oTypes = oJson["types"].ToList();
            //Trace.WriteLine(oTypes);
            List<GooglePlacesView> lPlaces = new List<GooglePlacesView>();
            //List<string> lPlaceTypes = new List<string>();
            Trace.WriteLine(sUrl);
            for (int i = 0; i < oPlaces.Count; i++)
            {
                /*
                 var oTypes= oPlaces[i]["types"];
                 */
                Trace.WriteLine(sUrl);
                lPlaces.Add(new GooglePlacesView
                {
                    sCityName = city,
                    sPlaceName = (string)oPlaces[i]["name"],
                    sPlaceType=type,
                    sPlaceAddress = (string)oPlaces[i]["vicinity"]
                });               
            }
            return lPlaces;
        }
    }
}
