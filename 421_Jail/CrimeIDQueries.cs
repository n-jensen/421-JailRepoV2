using System.Collections.Generic;
using System.Data.SqlClient;

namespace _421_Jail
{
    public static class CrimeIDQueries
    {
        private static string connectionStr = "Data Source=jail-cis-436.cwztroxlwrad.us-east-2.rds.amazonaws.com,1433; Initial Catalog = jail; Persist Security Info=True;User ID=admin;Password=Test12345";

        public static List<int> getAllIdsOfCrimes()
        {
            var crimeIds = new List<int>();
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if(sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT CrimeID from CRIME", sqlCon);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        crimeIds.Add(reader.GetInt32(reader.GetOrdinal("CrimeID")));
                    }
                }
            }
            return crimeIds;
        }

        public static List<CrimeIDModel> GetOneCrimeID(int inmateid)
        {
            List<CrimeIDModel> crimeIdList = new List<CrimeIDModel>();
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open) //and others
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT CRIMEID.CrimeID, CrimeID.ID, CRIMEID.InmateID, CRIME.Name FROM CRIMEID INNER JOIN CRIME ON CRIME.CrimeID = CRIMEID.CrimeID WHERE InmateID = @inmateid", sqlCon);
                    cmd.Parameters.AddWithValue("@inmateid", inmateid);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        crimeIdList.Add(new CrimeIDModel
                        {
                            ID = reader.GetInt32(reader.GetOrdinal("ID")),
                            CrimeID = reader.GetInt32(reader.GetOrdinal("CrimeID")),
                            InmateID = reader.GetInt32(reader.GetOrdinal("InmateID")),
                            CrimeName = reader.GetString(reader.GetOrdinal("Name"))
                        });
                    }
                }
            }
            return crimeIdList;
        }

        public static void AddCrimeID(int crimeid, int inmateid)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open) //and others
                {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO CRIMEID (CrimeID, InmateID) VALUES (@crimeid, @inmateid)", sqlCon);
                    cmd.Parameters.AddWithValue("@inmateid", inmateid);
                    cmd.Parameters.AddWithValue("@crimeid", crimeid);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteCrimeID(int ID, int inmateID)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open) //and others
                {
                    SqlCommand cmd = new SqlCommand(@"DELETE FROM CRIMEID WHERE ID = @ID AND InmateID = @InmateID", sqlCon);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@InmateID", inmateID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void EditCrimeID(int id, int crimeid, int inmateid)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open) //and others
                {
                    SqlCommand cmd = new SqlCommand(@"UPDATE CRIMEID SET CrimeId = @crimeid, InmateID = @inmateid WHERE ID = @id", sqlCon);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@crimeid", crimeid);
                    cmd.Parameters.AddWithValue("@inmateid", inmateid);
                    cmd.ExecuteNonQuery();
                } 
            }
        }

        public static List<CrimeIDModel> GetAllCrimeIDs()
        {
            List<CrimeIDModel> crimeIdList = new List<CrimeIDModel>();
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open) //and others
                {//grab a fuckin crime id 
                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM CRIMEID", sqlCon);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        crimeIdList.Add(new CrimeIDModel
                        {
                            ID = reader.GetInt32(reader.GetOrdinal("ID")),
                            CrimeID = reader.GetInt32(reader.GetOrdinal("CrimeID")),
                            InmateID = reader.GetInt32(reader.GetOrdinal("InmateID"))
                        });
                    }
                }
            }
            return crimeIdList;
        }
    }

    public class CrimeIDModel
    {
        public int ID { get; set; }
        public int CrimeID { get; set; }
        public int InmateID { get; set; }
        public string CrimeName { get; set; }
    }
}
