using System;
using System.Collections.Generic;
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
                    SqlCommand cmd = new SqlCommand(@"SELECT  EMPLOYEE.ESSN,
                                                    EMPLOYEE.Fname,
                                                    EMPLOYEE.Lname,
                                                    EMPLOYEE.Birthday,
                                                    EMPLOYEE.Payroll,
                                                    EMPLOYEE.StrAddress,
                                                    EMPLOYEE.City,
                                                    EMPLOYEE.State,
                                                    EMPLOYEE.Zip,
                                                    GUARD.AssignedBlock,
                                                    CARE.CareType,
                                                    DESK.DeskNumber
                                                    FROM EMPLOYEE
                                                    LEFT JOIN GUARD
                                                    ON EMPLOYEE.ESSN = GUARD.ESSN
                                                    LEFT JOIN CARE
                                                    ON EMPLOYEE.ESSN = CARE.ESSN
                                                    LEFT JOIN DESK
                                                    ON EMPLOYEE.ESSN = DESK.ESSN", sqlCon);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) //adds db info into an Employees-type variable
                    {
                        var extraInfo = reader.GetValue(reader.GetOrdinal("DeskNumber")).ToString();
                        var empType = "DESK";
                        if (extraInfo == null || extraInfo == "")
                        {
                            extraInfo = reader.GetValue(reader.GetOrdinal("CareType")).ToString();
                            empType = "CARE";
                        }
                        if (extraInfo == null || extraInfo == "")
                        {
                             extraInfo = reader.GetValue(reader.GetOrdinal("AssignedBlock")).ToString();
                             empType = "GUARD";
                        }
                        Employees.Add(new Employees
                        {
                            ESSN = reader.GetString(reader.GetOrdinal("ESSN")).Trim(),
                            Fname = reader.GetString(reader.GetOrdinal("Fname")).Trim(),
                            Lname = reader.GetString(reader.GetOrdinal("Lname")).Trim(),
                            Birthday = reader.GetDateTime(reader.GetOrdinal("Birthday")),
                            Payroll = reader.GetDecimal(reader.GetOrdinal("Payroll")),
                            StreetAddress = reader.GetString(reader.GetOrdinal("StrAddress")).Trim(),
                            City = reader.GetString(reader.GetOrdinal("City")).Trim(),
                            State = reader.GetString(reader.GetOrdinal("State")).Trim(),
                            Zip = reader.GetString(reader.GetOrdinal("Zip")).Trim(),
                            EmpType = empType,
                            TypeInfo = extraInfo
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
                    SqlCommand sqlCmd = new SqlCommand(@"SELECT EMPLOYEE.ESSN,
                                                        EMPLOYEE.Fname,
                                                        EMPLOYEE.Lname,
                                                        EMPLOYEE.Birthday,
                                                        EMPLOYEE.Payroll,
                                                        EMPLOYEE.StrAddress,
                                                        EMPLOYEE.State,
                                                        EMPLOYEE.City,
                                                        EMPLOYEE.Zip,
                                                        GUARD.AssignedBlock,
                                                        CARE.CareType,
                                                        DESK.DeskNumber
                                                        FROM EMPLOYEE
                                                        LEFT JOIN GUARD
                                                        ON EMPLOYEE.ESSN = GUARD.ESSN
                                                        LEFT JOIN CARE
                                                        ON EMPLOYEE.ESSN = CARE.ESSN
                                                        LEFT JOIN DESK
                                                        ON EMPLOYEE.ESSN = DESK.ESSN 
                                                        WHERE EMPLOYEE.ESSN = @ESSN", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@ESSN", ESSN);
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var extraInfo = reader.GetValue(reader.GetOrdinal("DeskNumber")).ToString();
                        var empType = "DESK";
                        if (extraInfo == null || extraInfo == "")
                        {
                            extraInfo = reader.GetValue(reader.GetOrdinal("CareType")).ToString();
                            empType = "CARE";
                        }
                        if (extraInfo == null || extraInfo == "")
                        {
                            extraInfo = reader.GetValue(reader.GetOrdinal("AssignedBlock")).ToString();
                            empType = "GUARD";
                        }
                        employees = new Employees
                        {
                            ESSN = reader.GetString(reader.GetOrdinal("ESSN")).Trim(),
                            Fname = reader.GetString(reader.GetOrdinal("Fname")).Trim(),
                            Lname = reader.GetString(reader.GetOrdinal("Lname")).Trim(),
                            Birthday = reader.GetDateTime(reader.GetOrdinal("Birthday")),
                            Payroll = reader.GetDecimal(reader.GetOrdinal("Payroll")),
                            StreetAddress = reader.GetString(reader.GetOrdinal("StrAddress")).Trim(),
                            City = reader.GetString(reader.GetOrdinal("City")).Trim(),
                            State = reader.GetString(reader.GetOrdinal("State")).Trim(),
                            Zip = reader.GetString(reader.GetOrdinal("Zip")).Trim(),
                            EmpType = empType,
                            TypeInfo = extraInfo
                        };
                    }
                }
            }
            return employees;
        }
        public static void EmpDeletion(string ESSN)
        {
            var employee = EmpDisplayOne(ESSN);
            if (employee != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionStr))
                {
                    sqlCon.Open();
                    if (sqlCon.State == System.Data.ConnectionState.Open)
                    {
                        if (employee?.EmpType == "GUARD")
                        {
                            SqlCommand delEmpType = new SqlCommand("DELETE FROM GUARD WHERE ESSN = @ESSN", sqlCon);
                            delEmpType.Parameters.AddWithValue("@ESSN", ESSN);
                            delEmpType.ExecuteNonQuery();
                        }
                        else if (employee?.EmpType == "DESK")
                        {
                            SqlCommand delEmpType = new SqlCommand("DELETE FROM DESK WHERE ESSN = @ESSN", sqlCon);
                            delEmpType.Parameters.AddWithValue("@ESSN", ESSN);
                            delEmpType.ExecuteNonQuery();
                        }
                        else if (employee?.EmpType == "CARE")
                        {
                            SqlCommand delEmpType = new SqlCommand("DELETE FROM CARE WHERE ESSN = @ESSN", sqlCon);
                            delEmpType.Parameters.AddWithValue("@ESSN", ESSN);
                            delEmpType.ExecuteNonQuery();
                        }
                        SqlCommand sqlCmd = new SqlCommand("DELETE FROM EMPLOYEE WHERE ESSN = @ESSN", sqlCon);
                        sqlCmd.Parameters.AddWithValue("@ESSN", ESSN);
                        sqlCmd.ExecuteNonQuery();
                    }
                }
            }
        }
        public static void EmpAddition(string ESSN, string Fname, string Lname, DateTime Birthday, decimal Payroll, string Street, string City, string State, string Zip, string empType, string typeInfo)
        {
            if(EmpDisplayOne(ESSN) != null)
            {
                return;
            }
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand sqlCmd = new SqlCommand("INSERT INTO EMPLOYEE VALUES(@ESSN, @Fname, @Lname, @Birthday, @Payroll, @Street, @City, @State, @Zip)", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@ESSN", ESSN);
                    sqlCmd.Parameters.AddWithValue("@Fname", Fname);
                    sqlCmd.Parameters.AddWithValue("@Lname", Lname);
                    sqlCmd.Parameters.AddWithValue("@Birthday", Birthday);
                    sqlCmd.Parameters.AddWithValue("@Payroll", Payroll);
                    sqlCmd.Parameters.AddWithValue("@Street", Street);
                    sqlCmd.Parameters.AddWithValue("@City", City);
                    sqlCmd.Parameters.AddWithValue("@State", State);
                    sqlCmd.Parameters.AddWithValue("@Zip", Zip);
                    sqlCmd.ExecuteNonQuery();

                    if (empType == "GUARD")
                    {
                        SqlCommand addEmpType = new SqlCommand("INSERT INTO GUARD VALUES (@ESSN, @AssignedBlock)", sqlCon);
                        addEmpType.Parameters.AddWithValue("@ESSN", ESSN);
                        addEmpType.Parameters.AddWithValue("@AssignedBlock", typeInfo);
                        addEmpType.ExecuteNonQuery();
                    }
                    else if (empType == "DESK")
                    {
                        SqlCommand addEmpType = new SqlCommand("INSERT INTO DESK VALUES (@ESSN, @DeskNum)", sqlCon);
                        addEmpType.Parameters.AddWithValue("@ESSN", ESSN);
                        addEmpType.Parameters.AddWithValue("@DeskNum", typeInfo);
                        addEmpType.ExecuteNonQuery();
                    }
                    else if (empType == "CARE")
                    {
                        SqlCommand addEmpType = new SqlCommand("INSERT INTO CARE VALUES (@ESSN, @CareType)", sqlCon);
                        addEmpType.Parameters.AddWithValue("@ESSN", ESSN);
                        addEmpType.Parameters.AddWithValue("@CareType", typeInfo);
                        addEmpType.ExecuteNonQuery();
                    }
                }
            }
        }
        public static void EmpEdit(string ESSN, string Fname, string Lname, DateTime Birthday, decimal Payroll, string Street, string City, string State, string Zip, string empType, string typeInfo)
        {
            var employee = EmpDisplayOne(ESSN);

            if(employee == null)
            {
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    if (employee.EmpType == "GUARD")
                    {
                        SqlCommand delEmpType = new SqlCommand("DELETE FROM GUARD WHERE ESSN = @ESSN", sqlCon);
                        delEmpType.Parameters.AddWithValue("@ESSN", ESSN);
                        delEmpType.ExecuteNonQuery();
                    }
                    else if (employee.EmpType == "CARE")
                    {
                        SqlCommand delEmpType = new SqlCommand("DELETE FROM CARE WHERE ESSN = @ESSN", sqlCon);
                        delEmpType.Parameters.AddWithValue("@ESSN", ESSN);
                        delEmpType.ExecuteNonQuery();
                    }
                    else if (employee.EmpType == "DESK")
                    {
                        SqlCommand delEmpType = new SqlCommand("DELETE FROM DESK WHERE ESSN = @ESSN", sqlCon);
                        delEmpType.Parameters.AddWithValue("@ESSN", ESSN);
                        delEmpType.ExecuteNonQuery();
                    }

                    if (empType == "GUARD")
                    {
                        SqlCommand addNewType = new SqlCommand("INSERT INTO GUARD VALUES(@ESSN, @AssignedBlock)", sqlCon);
                        addNewType.Parameters.AddWithValue("@ESSN", ESSN);
                        addNewType.Parameters.AddWithValue("@AssignedBlock", typeInfo);
                        addNewType.ExecuteNonQuery();
                    }
                    else if (empType == "CARE")
                    {
                        SqlCommand addNewType = new SqlCommand("INSERT INTO CARE VALUES(@ESSN, @CareType)", sqlCon);
                        addNewType.Parameters.AddWithValue("@ESSN", ESSN);
                        addNewType.Parameters.AddWithValue("@CareType", typeInfo);
                        addNewType.ExecuteNonQuery();
                    }
                    else if (empType == "DESK")
                    {
                        SqlCommand addNewType = new SqlCommand("INSERT INTO DESK VALUES(@ESSN, @DeskNumber)", sqlCon);
                        addNewType.Parameters.AddWithValue("@ESSN", ESSN);
                        addNewType.Parameters.AddWithValue("@DeskNumber", typeInfo);
                        addNewType.ExecuteNonQuery();
                    }

                    SqlCommand sqlCmd = new SqlCommand(@"UPDATE EMPLOYEE 
                                                        SET Fname = @Fname,
                                                        Lname = @Lname,
                                                        Birthday = @Birthday,
                                                        Payroll = @Payroll, 
                                                        StrAddress = @Address,
                                                        City = @City,
                                                        Zip = @Zip
                                                        WHERE ESSN = @ESSN", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@ESSN", ESSN);
                    sqlCmd.Parameters.AddWithValue("@Fname", Fname);
                    sqlCmd.Parameters.AddWithValue("@Lname", Lname);
                    sqlCmd.Parameters.AddWithValue("@Birthday", Birthday);
                    sqlCmd.Parameters.AddWithValue("@Payroll", Payroll);
                    sqlCmd.Parameters.AddWithValue("@Address", Street);
                    sqlCmd.Parameters.AddWithValue("@City", City);
                    sqlCmd.Parameters.AddWithValue("@Zip", Zip);
                    sqlCmd.ExecuteNonQuery();
                }
            }
        }

        public static List<int> GrabAssignedBlocks()
        {
            List<int> blockList = new List<int>();
            int block = 0;
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand grabGuardInfo = new SqlCommand("SELECT AssignedBlock FROM GUARD", sqlCon);
                    SqlDataReader reader = grabGuardInfo.ExecuteReader();
                    while (reader.Read())
                    {
                        block = reader.GetInt32(reader.GetOrdinal("AssignedBlock"));
                        blockList.Add(block);
                    }
                }
            }
            return blockList;
        }

        public static List<string> GrabCareTypes()
        {
            List<string> careList = new List<string>();
            string care = "";
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand grabCareInfo = new SqlCommand("SELECT CareType FROM CARE", sqlCon);
                    SqlDataReader reader = grabCareInfo.ExecuteReader();
                    while (reader.Read())
                    {
                        care = reader.GetString(reader.GetOrdinal("CareType"));
                        careList.Add(care);
                    }
                }
            }
            return careList;
        }

        public static List<int> GrabDeskNumbers()
        {
            List<int> deskList = new List<int>();
            int desk = 0;
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand grabDeskInfo = new SqlCommand("SELECT DeskNumber FROM DESK", sqlCon);
                    SqlDataReader reader = grabDeskInfo.ExecuteReader();
                    while (reader.Read())
                    {
                        desk = reader.GetInt32(reader.GetOrdinal("DeskNumber"));
                        deskList.Add(desk);
                    }
                }
            }
            return deskList;
        }

        //Block query
        public static List<BlockModel> GetBlockInfo()
        {
            var Block = new List<BlockModel>();
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT BLOCK.BlockID,BLOCK.BName,BLOCK.Location FROM BLOCK", sqlCon);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Block.Add(new BlockModel
                        {
                            BlockID = reader.GetInt32(reader.GetOrdinal("BlockID")),
                            BName = reader.GetString(reader.GetOrdinal("BName")).Trim(),
                            Location = reader.GetString(reader.GetOrdinal("Location")).Trim()
                        });
                              
                    }
                }
            }  
            return Block;
        }

        //Display Block info
        public static BlockModel DisplayBlockInfo(int BlockID)
        {
            BlockModel block = null;
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand sqlCmd = new SqlCommand(@"SELECT BLOCK.BlockID,BLOCK.BName,BLOCK.Location FROM BLOCK WHERE BLOCK.BlockID = @BlockID", sqlCon);
                        // string blockID = BlockID.ToString();
                    sqlCmd.Parameters.AddWithValue("@BlockID", BlockID);
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        block = new BlockModel
                        {
                            BlockID = reader.GetInt32(reader.GetOrdinal("BlockID")),
                            BName = reader.GetString(reader.GetOrdinal("BName")).Trim(),
                            Location = reader.GetString(reader.GetOrdinal("Location")).Trim(),
                        };
                    }
                }
            }
            return block;
        }

        //Delete Block info
        public static void BlockDeletion(int BlockID)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand sqlCmd = new SqlCommand("DELETE FROM BLOCK WHERE BlockID = @BlockID", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@BlockID", BlockID);
                    sqlCmd.ExecuteNonQuery();
                }
            }
        }

        //Add Block info
        public static void BlockAddition(int BlockID, string BName, string Location)
        {
            if(DisplayBlockInfo(BlockID) != null)
            {
                return;
            }
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand sqlCmd = new SqlCommand("INSERT INTO BLOCK VALUES (@BlockID, @BName, @Location)", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@BlockID", BlockID);
                    sqlCmd.Parameters.AddWithValue("@BName", BName);
                    sqlCmd.Parameters.AddWithValue("@Location", Location);
                    sqlCmd.ExecuteNonQuery();
                }
            }
        }

        //Edit Block info
        public static void BlockEdit(int BlockID, string BName, string Location)
        {
            if(DisplayBlockInfo(BlockID) == null)
            {
                return;
            }
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand sqlCmd = new SqlCommand(@"UPDATE BLOCK 
                                                         SET Bname = @Bname, 
                                                         Location = @Location
                                                         WHERE BlockID = @BlockID", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@BlockID", BlockID);
                    sqlCmd.Parameters.AddWithValue("@Bname", BName);
                    sqlCmd.Parameters.AddWithValue("@Location", Location);
                    sqlCmd.ExecuteNonQuery();
                }
            }
        }
        // end of BLOCK Query


        //Crime query
        public static List<Crimes> GetCrimeInfo()
        {
            var Crime = new List<Crimes>();
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT CRIME.CrimeID, CRIME.Name, CRIME.Severity FROM CRIME", sqlCon);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Crime.Add(new Crimes
                        {
                            CrimeID = reader.GetInt32(reader.GetOrdinal("CrimeID")),
                            CrimeName = reader.GetString(reader.GetOrdinal("Name")).Trim(),
                            Severity = reader.GetString(reader.GetOrdinal("Severity"))
                        });

                    }
                }
            }
            return Crime;
        }

        //Display Block info
        public static Crimes DisplayCrimeInfo(int CrimeID)
        {
            Crimes crime = null;
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand sqlCmd = new SqlCommand(@"SELECT CRIME.CrimeID, CRIME.Name, CRIME.Severity FROM CRIME WHERE CRIME.CrimeID = @CrimeID", sqlCon);
                    // string blockID = BlockID.ToString();
                    sqlCmd.Parameters.AddWithValue("@CrimeID", CrimeID);
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        crime = new Crimes 
                        {
                            CrimeID = reader.GetInt32(reader.GetOrdinal("CrimeID")),
                            CrimeName = reader.GetString(reader.GetOrdinal("Name")).Trim(),
                            Severity = reader.GetString(reader.GetOrdinal("Severity"))
                        };
                    }
                }
            }
            return crime;
        }

        //Delete Block info
        public static void CrimeDeletion(int CrimeID)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand sqlCmd = new SqlCommand("DELETE FROM CRIME WHERE CrimeID = @CrimeID", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@CrimeID", CrimeID);
                    sqlCmd.ExecuteNonQuery();
                }
            }
        }

        //Add Crime info
        public static void CrimeAddition(int CrimeID, string CrimeName, string Severity)
        {
            if(DisplayCrimeInfo(CrimeID) != null)
            {
                return;
            }
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand sqlCmd = new SqlCommand("INSERT INTO CRIME VALUES (@CrimeID, @Name, @Severity)", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@CrimeID", CrimeID);
                    sqlCmd.Parameters.AddWithValue("@Name", CrimeName);
                    sqlCmd.Parameters.AddWithValue("@Severity", Severity);
                    sqlCmd.ExecuteNonQuery();
                }
            }
        }

        //Edit Crime info
        public static void CrimeEdit(int CrimeID, string CrimeName, string Severity)
        {
            if(DisplayCrimeInfo(CrimeID) == null)
            {
                return;
            }
            using (SqlConnection sqlCon = new SqlConnection(connectionStr))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand sqlCmd = new SqlCommand(@"UPDATE CRIME 
                                                         SET Name = @Name, 
                                                         Severity = @Severity
                                                         WHERE CrimeID = @CrimeID", sqlCon);

                    sqlCmd.Parameters.AddWithValue("@CrimeID", CrimeID);
                    sqlCmd.Parameters.AddWithValue("@Name", CrimeName);
                    sqlCmd.Parameters.AddWithValue("@Severity", Severity);
                    sqlCmd.ExecuteNonQuery();
                }
            }
        }
    } // end of Crime Query
}

    public class Employees
    {
        public string ESSN { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Payroll { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string EmpType { get; set; }
        public string TypeInfo { get; set; }
    }

     public class BlockModel
     {
          public int BlockID { get; set; }
          public string BName { get; set; }
          public string Location { get; set; }
     }

    public class Crimes
    {
        public int CrimeID { get; set; }
        public string CrimeName { get; set; }
        public string Severity { get; set; }
    }




