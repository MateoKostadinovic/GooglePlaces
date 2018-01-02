using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using REST;

namespace CRUD
{
    public class Crud
    {
        List<Types> lTypes = new List<Types>();
        List<City> lCities = new List<City>();

        public List<Types> GetAllTypes()
        {
            string sSqlConnectionString = ConfigurationManager.AppSettings["GooglePlacesUrl"];
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT * FROM GooglePlaces_types";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        lTypes.Add(new Types()
                        {
                            nTypeID = (int)oReader["TYPE_ID"],
                            sTypeName = (string)oReader["TYPE_NAME"],
                            sTypeValue = (string)oReader["TYPE_VALUE"]
                        });
                    }
                }
            }
            return lTypes;
        }

        public void UpdateType(Types oType)
        {
            string sSqlConnectionString = ConfigurationManager.AppSettings["GooglePlacesUrl"];
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                Trace.WriteLine("UPDATE GooglePlaces_types SET TYPE_NAME = '" + oType.sTypeName + "', TYPE_VALUE = '" + oType.sTypeValue);
                oCommand.CommandText = "UPDATE GooglePlaces_types SET TYPE_NAME = '" + oType.sTypeName + "', TYPE_VALUE = '" + oType.sTypeValue + "'WHERE TYPE_ID = " + oType.nTypeID;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void DeleteType(int nIdType)
        {
            string sSqlConnectionString = ConfigurationManager.AppSettings["GooglePlacesUrl"];
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM GooglePlaces_types WHERE TYPE_ID = '" + nIdType + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void SaveNewType(Types oType)
        {
            string sSqlConnectionString = ConfigurationManager.AppSettings["GooglePlacesUrl"];
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())//nakon ove funkcije memorija se oslobada zbog using
            {
                oCommand.CommandText = "INSERT INTO GooglePlaces_types (TYPE_NAME, TYPE_VALUE) VALUES ('" + oType.sTypeName + "','" + oType.sTypeValue + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public List<City> GetAllCities()
        {
            string sSqlConnectionString = ConfigurationManager.AppSettings["GooglePlacesUrl"];
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT * FROM GooglePlaces_cities";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        lCities.Add(new City()//ovdje nesto ne valja cim ima nesto u bazi
                        {
                            nCityID = (int)oReader["CITY_ID"],
                            sCityName = (string)oReader["NAME"],
                            dCityLat = (decimal)oReader["LAT"],
                            dCityLng = (decimal)oReader["LNG"]

                        });
                    }
                }
            }
            return lCities;
        }

        public void UpdateCity(City oCity)
        {
            string sSqlConnectionString = ConfigurationManager.AppSettings["GooglePlacesUrl"];
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                Trace.WriteLine("UPDATE GooglePlaces_cities SET NAME = '" + oCity.sCityName + "', LAT = '" + oCity.dCityLat + "', LNG='" + oCity.dCityLng + "'");
                oCommand.CommandText = "UPDATE GooglePlaces_cities SET NAME = '" + oCity.sCityName + "', LAT = '" + oCity.dCityLat + "', LNG= '" + oCity.dCityLng + "' WHERE CITY_ID = " + oCity.nCityID;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void DeleteCity(int nIdCity)
        {
            string sSqlConnectionString = ConfigurationManager.AppSettings["GooglePlacesUrl"];
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM GooglePlaces_cities WHERE CITY_ID = '" + nIdCity + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void SaveNewCity(City oCity)
        {
            string sSqlConnectionString = ConfigurationManager.AppSettings["GooglePlacesUrl"];//spaja se na bazu
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())//nakon ove funkcije memorija se oslobada zbog using
            {
                oCommand.CommandText = "INSERT INTO GooglePlaces_cities (NAME, LAT, LNG) VALUES ('" + oCity.sCityName + "','" + oCity.dCityLat + "','" + oCity.dCityLng + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
    }
}
