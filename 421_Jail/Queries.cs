using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _421_Jail
{
    public static class Queries
    {
        private static string connectionStr = "Data Source=jail-cis-436.cwztroxlwrad.us-east-2.rds.amazonaws.com,1433; Initial Catalog = jail; Persist Security Info=True;User ID=admin;Password=Test12345";

        public static List<Employees> GetEmployees()
        {
            var Employees = new List<Employees>();
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open) //and others
                {
                    SqlCommand cmd = new SqlCommand("SELECT ESSN, Fname, Lname, Birthday, Payroll, JailID FROM EMPLOYEE ", sqlCon);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read()) //adds db info into an Employees-type variable
                    {
                        Employees.Add(new Employees{
                            ESSN = reader.GetString(reader.GetOrdinal("ESSN")),
                            Fname = reader.GetString(reader.GetOrdinal("Fname")),
                            Lname = reader.GetString(reader.GetOrdinal("Lname")),
                            Birthday = reader.GetDateTime(reader.GetOrdinal("Birthday")),
                            Payroll = reader.GetDecimal(reader.GetOrdinal("Payroll")),
                            JailID = reader.GetInt32(reader.GetOrdinal("JailID")),
                            StreetAddress = reader.GetString(reader.GetOrdinal("StrAddress")),
                            City = reader.GetString(reader.GetOrdinal("City")),
                            State = reader.GetString(reader.GetOrdinal("State")),
                            Zip = reader.GetString(reader.GetOrdinal("Zip"))
                        });
                    }
                }
            }
            return Employees;
        }

        public static Employees EmpDisplayOne(string ESSN)
        {
            Employees employees = null;
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open) //and others
                {
                    SqlCommand sqlCmd = new SqlCommand("SELECT * FROM EMPLOYEE, GUARD, CARE, DESK WHERE ESSN = @ESSN " +
                        "AND (EMPLOYEE.ESSN = GUARD.ESSN OR EMPLOYEE.ESSN = CARE.ESSN OR EMPLOYEE.ESSN = DESK.ESSN)", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@ESSN", ESSN);
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        employees = new Employees
                        {
                            ESSN = reader.GetString(reader.GetOrdinal("ESSN")),
                            Fname = reader.GetString(reader.GetOrdinal("Fname")),
                            Lname = reader.GetString(reader.GetOrdinal("Lname")),
                            Birthday = reader.GetDateTime(reader.GetOrdinal("Birthday")),
                            Payroll = reader.GetDecimal(reader.GetOrdinal("Payroll")),
                            JailID = reader.GetInt32(reader.GetOrdinal("JailID")),
                            StreetAddress = reader.GetString(reader.GetOrdinal("StrAddress")),
                            City = reader.GetString(reader.GetOrdinal("City")),
                            State = reader.GetString(reader.GetOrdinal("State")),
                            Zip = reader.GetString(reader.GetOrdinal("Zip")),
                            EmpType = reader.GetString(reader.GetOrdinal("")),////////////////
                        };
                    }
                }
            }
            return employees;
        }    

        public static void EmpDeletion(string ESSN)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open) 
                {
                    SqlCommand sqlCmd = new SqlCommand("DELETE FROM EMPLOYEE WHERE ESSN = @ESSN", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@ESSN", ESSN);
                    sqlCmd.ExecuteNonQuery();
                }
            }
        }

        public static void EmpAddition(string ESSN, string Fname, string Lname, DateTime Birthday, decimal Payroll, int JailID, string Street, string City, string State, string Zip, string empType, string typeInfo)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand sqlCmd = new SqlCommand("INSERT INTO EMPLOYEE VALUES(@ESSN, @Fname, @Lname, @Birthday, @Payroll, @JailID, @Street, @City, @State, @Zip)", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@ESSN", ESSN);
                    sqlCmd.Parameters.AddWithValue("@Fname", Fname);
                    sqlCmd.Parameters.AddWithValue("@Lname", Lname);
                    sqlCmd.Parameters.AddWithValue("@Birthday", Birthday);
                    sqlCmd.Parameters.AddWithValue("@Payroll", Payroll);
                    sqlCmd.Parameters.AddWithValue("@JailID", JailID);
                    sqlCmd.Parameters.AddWithValue("@Street", Street);
                    sqlCmd.Parameters.AddWithValue("@City", City);
                    sqlCmd.Parameters.AddWithValue("@State", State);
                    sqlCmd.Parameters.AddWithValue("@Zip", Zip);
                    sqlCmd.ExecuteNonQuery();
                    if (empType == "GUARD")
                    {
                        SqlCommand addEmpType = new SqlCommand("INSERT INTO GUARD VALUES (@ESSN, @AssignedBlock)");
                        addEmpType.Parameters.AddWithValue("@ESSN", ESSN);
                        addEmpType.Parameters.AddWithValue("@AssignedBlock", typeInfo);
                    }
                    else if (empType == "DESK")
                    {
                        SqlCommand addEmpType = new SqlCommand("INSERT INTO DESK VALUES (@ESSN, @DeskNumber)");
                        addEmpType.Parameters.AddWithValue("@ESSN", ESSN);
                        addEmpType.Parameters.AddWithValue("@DeskNumber", typeInfo);
                    }
                    else if (empType == "CARE")
                    {
                        SqlCommand addEmpType = new SqlCommand("INSERT INTO CARE VALUES (@ESSN, @CareType)");
                        addEmpType.Parameters.AddWithValue("@ESSN", ESSN);
                        addEmpType.Parameters.AddWithValue("@CareType", typeInfo);
                    }
                }
            }
        }

        public static void EmpEdit()
        {
           
        }   
    }

    public class Employees
    {
        public string ESSN { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Payroll { get; set; }
        public int JailID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string EmpType { get; set; }
        public string TypeInfo { get; set; }
    }


}
