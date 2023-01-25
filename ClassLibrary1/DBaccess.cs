using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DbLib
{
    public static class DBaccess
    {
        //private const string connectString = @"Server=localhost; Database= Birds; Integrated Security=True";
        private const string connectString = @"Server=tcp:eds-azure.database.windows.net,1433;Initial Catalog = Birds; Persist Security Info=False;
            User ID = ericsergio; Password=r1gHtCl1ck$; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";

        private const string sqlErrorMessage = "Database operation failed. Please contact your System Administrator";
        private const String xmlFile = @"Y:\Documents\School\23\Winter\isit310\docs\RemoteBirdClub.xml";


        public static DataSet GetRawCountDataSet() { 
        SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from BirdCount Order By CountID", connectString);
            DataTable dataTable = new DataTable();
            //dataTable.Columns.Add()
            dataAdapter.Fill(dataTable);
            foreach(DataRow row in dataTable.Rows)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", row["CountID"], row["RegionID"], row["BirderID"], row["BirdID"], row["CountDate"], row["Counted"]);
            }
            Console.WriteLine("-----------");
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "BirdCount");
            //dataTable
            /*foreach(DataRow row in dataSet.Tables["BirdCount"].Rows)
            {
                //Console.WriteLine((string)row["CountID"], row["RegionID"], row["BirderID"], row["BirdID"], row["CountDate"], row["Counted"]);
            }*/
            return dataSet;
        }

        static public List<CountRowReturn> GetCountData()
        {
            List<CountRowReturn> DataList = new List<CountRowReturn>();
            SqlDataReader birdReader;  //datareader
            SqlCommand selectCommand = new SqlCommand();
            selectCommand.Connection = new SqlConnection(connectString);
            selectCommand.CommandText =
                    "SELECT Region.RegionName, Bird.Name, Birder.FirstName, Birder.LastName, BirdCount.CountDate, BirdCount.Counted " +
                        "FROM Bird INNER JOIN " +
                         "BirdCount ON Bird.BirdID = BirdCount.BirdID INNER JOIN " +
                         "Birder ON BirdCount.BirderID = Birder.BirderID INNER JOIN " +
                         "Region ON BirdCount.RegionID = Region.RegionID " +
                         "ORDER BY RegionName";
            selectCommand.Connection.Open();

            birdReader = selectCommand.ExecuteReader();

           
            while (birdReader.Read())
            {
                CountRowReturn tempRow = new CountRowReturn();
                tempRow.Birder = birdReader["FirstName"].ToString() + " " + birdReader["LastName"].ToString();
                tempRow.Bird = birdReader["Name"].ToString();
                tempRow.Region = birdReader["RegionName"].ToString();
                tempRow.Count = (int)birdReader["Counted"];
                tempRow.CountDate = (DateTime)birdReader["CountDate"];
                DataList.Add(tempRow);
            }

            birdReader.Close();
            return DataList;
        }

        public static List<Bird> GetBird()
        {
            SqlConnection connection = new SqlConnection(connectString);
            SqlCommand commRegion = new SqlCommand("SELECT BirdID, Name FROM Bird", connection);
            List<Bird> BirdList = new List<Bird>();
            try
            {
                connection.Open();
                SqlDataReader reader = commRegion.ExecuteReader();
                while (reader.Read())
                {
                    Bird tempBird = new Bird();
                    tempBird.BirdID = reader["BirdID"].ToString();
                    tempBird.Name = reader["Name"].ToString();
                    BirdList.Add(tempBird);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error loading the from Birds DB: " + ex);
            }
            finally
            {
                connection.Close();
            }
            return BirdList;
        }

        public static string AddBird(string pNewBird, string pNewID, string pNewDesc)
        {
            string returnString = "failed to add new bird";
            try
            {
                SqlCommand insertCommand = new SqlCommand();
                insertCommand.Connection = new SqlConnection(connectString);
                insertCommand.CommandText = "INSERT INTO Bird (Name, BirdID, Description) VALUES( @Name, @ID, @DESC) ";
                
                insertCommand.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar);
                insertCommand.Parameters["@Name"].Value = pNewBird;

                insertCommand.Parameters.Add("@ID", System.Data.SqlDbType.NVarChar);
                insertCommand.Parameters["@ID"].Value = pNewID;

                insertCommand.Parameters.Add("@DESC", System.Data.SqlDbType.NVarChar);
                insertCommand.Parameters["@DESC"].Value = pNewDesc;

                insertCommand.Connection.Open();
                insertCommand.ExecuteNonQuery();
                insertCommand.Connection.Close();
                returnString = "success, " + pNewBird + " added.";
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error loading the from Birds DB: " + ex);
            }           
            return returnString;            
        }

        public static string AddBirder(string pNewBirderFirst, string pNewBirderLast, string pNewPhone)
        {
            string returnString = "failed to add new birder";
            try
            {
                SqlCommand insertCommand = new SqlCommand();
                insertCommand.Connection = new SqlConnection(connectString);
                insertCommand.CommandText = "INSERT INTO Birder (FirstName, LastName, Phone) VALUES( @FirstName, @LastName, @PHONE)";
                
                insertCommand.Parameters.Add("@FirstName", System.Data.SqlDbType.NVarChar);
                insertCommand.Parameters["@FirstName"].Value = pNewBirderFirst;

                insertCommand.Parameters.Add("@LastName", System.Data.SqlDbType.NVarChar);
                insertCommand.Parameters["@LastName"].Value = pNewBirderLast;

                insertCommand.Parameters.Add("@PHONE", System.Data.SqlDbType.NVarChar);
                insertCommand.Parameters["@PHONE"].Value = pNewPhone;

                insertCommand.Connection.Open();
                insertCommand.ExecuteNonQuery();
                insertCommand.Connection.Close();
                returnString = "success, " + pNewBirderFirst + " " + pNewBirderLast + " added.";
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error loading the from Birds DB: " + ex);
            }
            return returnString;

        }

        public static string AddRegion(string pNewRegion, string pNewID)
        {
            string returnString = "failed to add new region";
            try
            {
                SqlCommand insertCommand = new SqlCommand();
                insertCommand.Connection = new SqlConnection(connectString);
                insertCommand.CommandText = "INSERT INTO Region (RegionName, RegionID) VALUES( @Name, @ID) ";
               
                insertCommand.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar);
                insertCommand.Parameters["@Name"].Value = pNewRegion;

                insertCommand.Parameters.Add("@ID", System.Data.SqlDbType.NVarChar);
                insertCommand.Parameters["@ID"].Value = pNewID;

                insertCommand.Connection.Open();
                insertCommand.ExecuteNonQuery();
                insertCommand.Connection.Close();
                returnString = "success, " + pNewRegion + " added.";
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error loading the from Birds DB: " + ex);
            }
            return returnString;
        }

        public static List<Birder> GetBirder()
        {
            SqlConnection connection = new SqlConnection(connectString);
            SqlCommand commRegion = new SqlCommand("SELECT BirderID, LastName, FirstName FROM Birder", connection);
            List<Birder> BirderList = new List<Birder>();
            try
            {
                connection.Open();
                SqlDataReader reader = commRegion.ExecuteReader();
                while (reader.Read())
                {
                    Birder tempBirder = new Birder();
                    tempBirder.BirderID = Convert.ToInt32(reader["BirderID"]);
                    tempBirder.BirderName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                    BirderList.Add(tempBirder);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error loading the from Birds DB: " + ex);
            }
            finally
            {
                connection.Close();
            }
            return BirderList;
        }

        public static void AddCount(CountRow addCountRow)
        {
            try
            {
                SqlCommand insertCommand = new SqlCommand();
                insertCommand.Connection = new SqlConnection(connectString);
                insertCommand.CommandText =
                    "INSERT INTO BirdCount (BirderID, BirdID, RegionID, Counted, CountDate ) VALUES( " +
                    "" + addCountRow.BirderID + " , '" + addCountRow.BirdID + "' , '" + addCountRow.RegionID + "' ,  @Counted, @CountDate) ";
                insertCommand.Parameters.Add("@Counted", System.Data.SqlDbType.Int);
                insertCommand.Parameters["@Counted"].Value = addCountRow.Count;

                insertCommand.Parameters.Add("@CountDate", System.Data.SqlDbType.Date);
                insertCommand.Parameters["@CountDate"].Value = addCountRow.CountDate;

                insertCommand.Connection.Open();
                insertCommand.ExecuteNonQuery();
                insertCommand.Connection.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error loading the from Birds DB: " + ex);                
            }
        }

        public static List<Regions> GetRegions() 
        {
            SqlConnection connection = new SqlConnection(connectString);
            SqlCommand commRegion = new SqlCommand("SELECT RegionID, RegionName FROM Region", connection);
            List<Regions> RegionList = new List<Regions>();
            try
            {
                connection.Open();
                SqlDataReader reader = commRegion.ExecuteReader();
                while (reader.Read())
                {
                    Regions tempRegion = new Regions();
                    tempRegion.RegionID = reader["RegionID"].ToString();
                    tempRegion.RegionName = reader["RegionName"].ToString();
                    RegionList.Add(tempRegion);   
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error loading the from Birds DB: " + ex);
            }
            finally
            {
                connection.Close();
            }
            return RegionList;
        }


        public static DataSet GetBirds()
        {
            SqlDataAdapter BirdAdapter = new SqlDataAdapter();
            BirdAdapter.SelectCommand = new SqlCommand();
            BirdAdapter.SelectCommand.Connection = new SqlConnection();
            try
            {
                BirdAdapter.SelectCommand.Connection.ConnectionString = connectString;
                BirdAdapter.SelectCommand.CommandText = "Select * from [Bird] order by BirdID";

                DataSet birdDataSet = new DataSet("BirdDataSet");
                BirdAdapter.Fill(birdDataSet, "Bird");

                BirdAdapter.SelectCommand.CommandText = "Select * from [BirdCount] order by CountID";
                BirdAdapter.Fill(birdDataSet, "BirdCount");


                DataRelation birdDataRelation = new DataRelation("UsefulRelation",
                  birdDataSet.Tables["Bird"].Columns["BirdID"],
                  birdDataSet.Tables["BirdCount"].Columns["BirdID"]);
                birdDataSet.Relations.Add(birdDataRelation);
                birdDataRelation.ChildKeyConstraint.DeleteRule = Rule.Cascade;


                return birdDataSet;
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException(sqlErrorMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
 
        public static int DoXML(DataSet birdDataSet)
        {
            int rowCount;
            SqlDataAdapter birdCountAdapter = new SqlDataAdapter();
            
            birdCountAdapter.InsertCommand = new SqlCommand();
            birdCountAdapter.InsertCommand.CommandText = "INSERT into BirdCount(RegionID,BirderID,BirdID,CountDate,Counted)" +
                "VALUES (@RegionID,@BirderID,@BirdID,@CountDate,@Counted)";
            birdCountAdapter.InsertCommand.Connection = new SqlConnection();
            birdCountAdapter.InsertCommand.Connection.ConnectionString = connectString;
            try
            {
                birdCountAdapter.InsertCommand.Parameters.Add("@RegionID", System.Data.SqlDbType.NVarChar, 5);
                birdCountAdapter.InsertCommand.Parameters["@RegionID"].SourceColumn = "RegionID";
                birdCountAdapter.InsertCommand.Parameters.Add("@BirderID", System.Data.SqlDbType.Int);
                birdCountAdapter.InsertCommand.Parameters["@BirderID"].SourceColumn = "BirderID";
                birdCountAdapter.InsertCommand.Parameters.Add("@BirdID", System.Data.SqlDbType.NVarChar, 10);
                birdCountAdapter.InsertCommand.Parameters["@BirdID"].SourceColumn = "BirdID";
                birdCountAdapter.InsertCommand.Parameters.Add("@CountDate", System.Data.SqlDbType.SmallDateTime);
                birdCountAdapter.InsertCommand.Parameters["@CountDate"].SourceColumn = "CountDate";
                birdCountAdapter.InsertCommand.Parameters.Add("@Counted", System.Data.SqlDbType.Int);
                birdCountAdapter.InsertCommand.Parameters["@Counted"].SourceColumn = "Counted";
                birdCountAdapter.InsertCommand.Connection.Open();

                rowCount = birdCountAdapter.Update(birdDataSet, "BirdCount");
            } 
            catch(SqlException sqlEx)
            {
                throw new ApplicationException(sqlErrorMessage);
            }

            return rowCount;
        }
    } 
}