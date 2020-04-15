using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace _421_Jail
{
    public class InmateQueries
    {
        private static string connectionStr = "Data Source=jail-cis-436.cwztroxlwrad.us-east-2.rds.amazonaws.com,1433; Initial Catalog = jail; Persist Security Info=True;User ID=admin;Password=Test12345";

        //begin inmate queries
        public static List<InmatesModel> GetInmates()
        {
            var InmateList = new List<InmatesModel>();
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open) //and others
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT INMATE.InmateID, INMATE.ISSN, INMATE.Fname, INMATE.Lname, INMATE.Birthday, 
                                                    INMATE.HealthStatus, INMATE.ArrivalDate, INMATE.YearsLeft, INMATE.BlockID
                                                    FROM INMATE", sqlCon);
                    SqlDataReader inmateReader = cmd.ExecuteReader();
                    while (inmateReader.Read())
                    {
                        InmateList.Add(new InmatesModel
                        {
                            InmateID = inmateReader.GetInt32(inmateReader.GetOrdinal("InmateID")),
                            ISSN = inmateReader.GetString(inmateReader.GetOrdinal("ISSN")),
                            Fname = inmateReader.GetString(inmateReader.GetOrdinal("Fname")).Trim(),
                            Lname = inmateReader.GetString(inmateReader.GetOrdinal("Lname")).Trim(),
                            Birthday = inmateReader.GetDateTime(inmateReader.GetOrdinal("Birthday")),
                            HealthStatus = inmateReader.GetString(inmateReader.GetOrdinal("HealthStatus")).Trim(),
                            ArrivalDate = inmateReader.GetDateTime(inmateReader.GetOrdinal("ArrivalDate")),
                            YearsLeft = inmateReader.GetInt32(inmateReader.GetOrdinal("YearsLeft")),
                            BlockID = inmateReader.GetInt32(inmateReader.GetOrdinal("BlockID")),
                        });
                    }
                }
            }
            return InmateList;
        }
        public static InmatesModel InmateDisplayOne(int inmateID)
        {
            InmatesModel singleInmate = null;
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM INMATE WHERE InmateID = @inmateID", sqlCon);
                    cmd.Parameters.AddWithValue("@inmateID", inmateID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        singleInmate = new InmatesModel
                        {
                            InmateID = reader.GetInt32(reader.GetOrdinal("InmateID")),
                            ISSN = reader.GetString(reader.GetOrdinal("ISSN")).Trim(),
                            Fname = reader.GetString(reader.GetOrdinal("Fname")).Trim(),
                            Lname = reader.GetString(reader.GetOrdinal("Lname")).Trim(),
                            Birthday = reader.GetDateTime(reader.GetOrdinal("Birthday")),
                            HealthStatus = reader.GetString(reader.GetOrdinal("HealthStatus")).Trim(),
                            ArrivalDate = reader.GetDateTime(reader.GetOrdinal("ArrivalDate")),
                            YearsLeft = reader.GetInt32(reader.GetOrdinal("YearsLeft")),
                            BlockID = reader.GetInt32(reader.GetOrdinal("BlockID"))
                        };
                    }
                }
            }
            return singleInmate;
        }

        public static void InmateDeletion(int inmateID)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand crimeIDcmd = new SqlCommand("DELETE FROM CRIMEID WHERE InmateID = @inmateID", sqlCon);
                    SqlCommand cmd = new SqlCommand("DELETE FROM INMATE WHERE InmateID = @inmateID", sqlCon);
                    crimeIDcmd.Parameters.AddWithValue("@inmateID", inmateID);
                    cmd.Parameters.AddWithValue("@inmateID", inmateID);
                    crimeIDcmd.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void InmateAddition(int inmateID, string issn, string fname, string lname, DateTime birthday, string healthStatus, DateTime arrivalDate, int yrsLeft, int blockID)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO INMATE VALUES(@inmateID, @issn, @fname, @lname, @birthday, @healthStatus, @arrivalDate, @yrsLeft, @blockID)", sqlCon);
                    cmd.Parameters.AddWithValue("@inmateID", inmateID); //int
                    cmd.Parameters.AddWithValue("@issn", issn); //char9
                    cmd.Parameters.AddWithValue("@fname", fname); //char 20
                    cmd.Parameters.AddWithValue("@lname", lname); //char 20
                    cmd.Parameters.AddWithValue("@birthday", birthday); //date
                    cmd.Parameters.AddWithValue("@healthStatus", healthStatus); //char 4
                    cmd.Parameters.AddWithValue("@arrivalDate", arrivalDate); //date
                    cmd.Parameters.AddWithValue("@yrsLeft", yrsLeft); //int
                    cmd.Parameters.AddWithValue("@blockID", blockID); //int
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void InmateEdit(int inmateID, string fname, string lname, DateTime birthday, string healthStatus, DateTime arrivalDate, int yearsLeft, int blockID)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(@"UPDATE INMATE
                                                      SET Fname = @fname,
                                                      Lname = @lname,
                                                      Birthday = @birthday,
                                                      HealthStatus = @healthStatus,
                                                      ArrivalDate = @arrivalDate,
                                                      YearsLeft = @yearsLeft,
                                                      BlockID = @blockID
                                                      WHERE InmateID = @inmateID", sqlCon);
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@birthday", birthday);
                    cmd.Parameters.AddWithValue("@healthStatus", healthStatus);
                    cmd.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                    cmd.Parameters.AddWithValue("@yearsLeft", yearsLeft);
                    cmd.Parameters.AddWithValue("@blockID", blockID);
                    cmd.Parameters.AddWithValue("@inmateID", inmateID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<int> FillBlockIDDropDown()
        {
            List<int> filling = new List<int>();
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("SELECT BlockID FROM BLOCK", sqlCon);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        filling.Add(reader.GetInt32(reader.GetOrdinal("BlockID")));
                    }
                }
            }
            return filling;
        }
    }
}

public class InmatesModel
{
    public int InmateID;
    public string ISSN;
    public string Fname;
    public string Lname;
    public DateTime Birthday;
    public string HealthStatus;
    public DateTime ArrivalDate;
    public int YearsLeft;
    public int BlockID;
    public int Crime_ID;
}