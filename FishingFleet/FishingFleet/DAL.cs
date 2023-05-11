using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FishingFleet
{
    internal class DAL
    {
        //-------------------SqlConnection-----------------------
        #region
        public static SqlConnection ConnectToDatabase()
        {
            string strConnection = @"Data Source=Inas-Nuzair\SQLEXPRESS;Initial Catalog=FishingFleet;Integrated Security=True";
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            return connection;
        }
        #endregion
        //-------------------Login-------------------------------
        #region
        public static bool LoginInputIsValid(Login.Login userLogin)
        {
            string query = "SELECT * FROM tblUSER WHERE User_Name = @userName AND Password = @password";
            SqlConnection connection = ConnectToDatabase();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@userName", userLogin.Username);
            command.Parameters.AddWithValue("@password", userLogin.Password);
            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
                return true;
            else
                return false;
        }
        public static void LoginUser(Login.Login userLogin)
        {
            if (LoginInputIsValid(userLogin))
            {
                Thread thread = new Thread(OpenMainMenuForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!!!"," LoginFailed ");
                Thread thread = new Thread(OpenLoginForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
        #endregion
        //-------------------SignUp------------------------------
        #region
        //Check for Username
        public static bool UserNameAlreadyExist(Login.SignUp signUp)
        {
            string userCheckquery = "SELECT * FROM tblUSER WHERE User_Name = @userName";
            SqlConnection connection = ConnectToDatabase();
            SqlCommand command = new SqlCommand(userCheckquery, connection);
            command.Parameters.AddWithValue("@userName", signUp.UserName);
            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
                return true;
            else
                return false;
        }

        //Check for User
        public static bool UserExist(Login.SignUp signUp)
        {
            string userCheckquery = "SELECT * FROM tblUSER WHERE User_Name = @userName AND Password = @password";
            SqlConnection connection = ConnectToDatabase();
            SqlCommand command = new SqlCommand(userCheckquery, connection);
            command.Parameters.AddWithValue("@userName", signUp.UserName);
            command.Parameters.AddWithValue("@password", signUp.Password);
            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
                return true;
            else
                return false;
        }

        //Add User
        public static void SignUp(Login.SignUp signUp)
        {

            if (UserNameAlreadyExist(signUp))
            {
                MessageBox.Show("Username Already Exist!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SignUp showSignUp = new SignUp();
                showSignUp.Show();
            }
            else
            {
                string signUpQuery = "INSERT INTO tblUSER VALUES(@fullName, @userName, @password, @phoneNumber, @petName)";
                SqlConnection connection = ConnectToDatabase();
                SqlCommand command = new SqlCommand(signUpQuery, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@userName", signUp.UserName);
                command.Parameters.AddWithValue("@fullName", signUp.FirstName);
                command.Parameters.AddWithValue("@password", signUp.Password);
                command.Parameters.AddWithValue("@phoneNumber", signUp.PhoneNumber);
                command.Parameters.AddWithValue("@petName", signUp.PetName);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("User Registered Succesfully!!!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Unsuccesfull!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        //Forgot Password
        public static void ForgotPassword(string userName, string petName)
        {
            string searchQuery = "SELECT * FROM tblUSER WHERE User_Name = @userName AND Pet_Name = @petName";
            SqlConnection connection = ConnectToDatabase();
            SqlCommand command = new SqlCommand(searchQuery, connection);
            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@petName", petName);
            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                ChangeForgotPassword changePasswordForm = new ChangeForgotPassword();
                changePasswordForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Pet Name!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ForgotPassword forgotPassword = new ForgotPassword();
                forgotPassword.Show();
            }
        }

        //User Search
        public static DataSet SearchUser(string userName)
        {
            string searchQuery = "SELECT * FROM tblUSER WHERE User_Name = @userName";
            SqlConnection connection = ConnectToDatabase();
            SqlCommand command = new SqlCommand(searchQuery, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@userName", userName);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataSet dataSet = new DataSet();

            if (dataTable.Rows.Count == 1)
            {
                adapter.Fill(dataSet, "tblUSER");
            }
            else
                MessageBox.Show("User Unavailable!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return dataSet;
        }
        //User Delete
        public static void DeleteUser(Login.SignUp signUp)
        {
            if (UserExist(signUp))
            {
                string UserDeleteQuery = "DELETE FROM tblUSER WHERE User_Name = @userName AND Password = @password";
                SqlConnection connection = ConnectToDatabase();
                SqlCommand command = new SqlCommand(UserDeleteQuery, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@userName", signUp.UserName);
                command.Parameters.AddWithValue("@password", signUp.Password);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("User Removed Succesfully!!!");
                    Thread thread = new Thread(OpenLoginForm);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    CloseMainMenuForm();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Unsuccesfull!!!");
                }
            }
            else
                MessageBox.Show("Invalid Input!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Add New Password
        public static void AddNewPassword(Login.SignUp signUp)
        {
            if (UserNameAlreadyExist(signUp))
            {
                string updatePasswordQuery = "UPDATE tblUSER SET Password = @newPassword WHERE User_Name = @userName";
                SqlConnection connection = ConnectToDatabase();
                SqlCommand command = new SqlCommand(updatePasswordQuery, connection);
                command.Parameters.AddWithValue("@userName", signUp.UserName);
                command.Parameters.AddWithValue("@newPassword", signUp.Password);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Password Changed Succesfully!!!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Unsuccesfull!!!");
                }
            }
            else
                MessageBox.Show("Invalid Input!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
        //Check For Data in Database
        #region
        public static bool DataExist(string columnName, string query, string id)
        {
            SqlConnection connection = ConnectToDatabase();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue(columnName, id);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
                return true;
            else
                return false;
        }

        public static bool SpeciesExist(string species)
        {
            SqlConnection connection = ConnectToDatabase();
            string query = "SELECT * FROM Quotas WHERE Species = @species";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@species", species);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
                return true;
            else
                return false;
        }

        #endregion

        //Check For Searched Data in Database
        #region
        public static SqlDataAdapter SearchDataExist(string columnName, string query, string id)
        {
            SqlConnection connection = ConnectToDatabase();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue(columnName, id);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
                return adapter;
            else
                return null;
        }
        #endregion

        //---------------------Boats--------------------------
        #region
        public static void OperationOnBoat(string boatId, string name, string licenseNo, string maxLoadSize, string species1, string species2, string species3, string species4, string query, string operation)
        {
            SqlConnection connection = ConnectToDatabase();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@boatId", boatId);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@licenseNo", licenseNo);
            command.Parameters.AddWithValue("@maxLoadSize", maxLoadSize);
            command.Parameters.AddWithValue("@species1", species1);
            command.Parameters.AddWithValue("@species2", species2);
            command.Parameters.AddWithValue("@species3", species3);
            command.Parameters.AddWithValue("@species4", species4);
            try
            {
                command.ExecuteNonQuery();
                ViewBoat();
                MessageBox.Show("Boat " + operation +  " Succesfully!!!", "Successfull");
                BoatDetails boatDetails = new BoatDetails();
                boatDetails.Show();
            }
            catch (SqlException)
            {
                MessageBox.Show("Operation Unsuccesfull!!!", "Unsuccesfull");
            }
        }
        public static void AddBoat(string boatId, string name, string licenseNo, string maxLoadSize, string species1, string species2, string species3, string species4)
        {
            string checkboatQuery = "SELECT * FROM Boats WHERE Boat_Id = @boatId";
            if (DataExist("@boatId", checkboatQuery, boatId))
            {
                MessageBox.Show("Boat with boat Id (" + boatId + ") already Exists!!!", "Unsuccesfull");
                BoatsModule boatModule = new BoatsModule();
                boatModule.Show();
            }
            else
            {
                string addBoatQuery = "INSERT INTO Boats VALUES (@boatId, @name, @licenseNo, @maxLoadSize, @species1, @species2, @species3, @species4)";
                OperationOnBoat(boatId, name, licenseNo, maxLoadSize, species1, species2, species3, species4 ,addBoatQuery, "Added");
            }
        }

        //View Boat
        public static DataSet ViewBoat()
        {
            string query = "SELECT * FROM Boats";
            SqlConnection connection = ConnectToDatabase();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Boats");
            return dataSet;
        }

        //Search boat
        public static DataSet SearchBoat(string boatID)
        {
            string searchboatQuery = "SELECT * FROM Boats WHERE Boat_Id = @boatID";
            SqlDataAdapter adapter = SearchDataExist("@boatID", searchboatQuery, boatID);
            DataSet dataSet = new DataSet();
            if (adapter != null)
                adapter.Fill(dataSet, "Boats");
            else
                MessageBox.Show("Boat Unavailable!!!");
            return dataSet;
        }

        //Update boat
        public static void UpdateBoat(string boatID, string name, string licenseNo, string maxLoadSize, string species1, string species2, string species3, string species4)
        {
            string checkBoatQuery = "SELECT * FROM Boats WHERE Boat_Id = @boatID";
            if (DataExist("@boatID", checkBoatQuery, boatID))
            {
                string updateBoatQuery = "UPDATE Boats SET Name = @name, License_Number = @licenseNo, Max_Load_Size = @maxLoadSize, Species1 = @species1, Species2 = @species2,Species3 = @species3,Species4 = @species4   WHERE Boat_Id = @boatID;";
                OperationOnBoat(boatID, name, licenseNo, maxLoadSize, species1, species2, species3, species4, updateBoatQuery, "Updated");
            }
            else
            {
                MessageBox.Show("Boat with boat ID (" + boatID + ") Is Unavailable to Update!!!");
                BoatsModule boatModule = new BoatsModule();
                boatModule.Show();
            }
        }

        //Delete boat
        public static void DeleteBoat(string boatID)
        {
            string checkBoatsQuery = "SELECT * FROM Boats WHERE Boat_Id = @boatID";
            if (DataExist("@boatID", checkBoatsQuery, boatID))
            {
                string deleteBoatQuery = "DELETE FROM Boats WHERE Boat_ID = @boatID;";
                OperationOnBoat(boatID, "", "", "", "", "", "", "", deleteBoatQuery, "Deleted");
            }
            else
            {
                MessageBox.Show("Boat Unavailable to Delete!!!");
                BoatsModule boatModule = new BoatsModule();
                boatModule.Show();
            }
        }
        #endregion


        ////---------------------Fishes--------------------------
        //#region
        //public static void OperationOnFish(string fishId, string name, string query, string operation)
        //{
        //    SqlConnection connection = ConnectToDatabase();
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.CommandType = CommandType.Text;
        //    command.Parameters.AddWithValue("@fishId", fishId);
        //    command.Parameters.AddWithValue("@name", name);
        //    try
        //    {
        //        command.ExecuteNonQuery();
        //        ViewFish();
        //        MessageBox.Show("Fish " + operation + " Succesfully!!!", "Successfull");
        //        FishDetails fishDetails = new FishDetails();
        //        fishDetails.Show();
        //    }
        //    catch (SqlException)
        //    {
        //        MessageBox.Show("Operation Unsuccesfull!!!", "Unsuccesfull");
        //    }
        //}
        //public static void AddFish(string fishId, string name)
        //{
        //    string checkFishQuery = "SELECT * FROM FishSpecies WHERE Fish_Id = @fishId";
        //    if (DataExist("@fishId", checkFishQuery, fishId))
        //    {
        //        MessageBox.Show("Fish with fish Id (" + fishId + ") already Exists!!!", "Unsuccesfull");
        //        FishSpecies fishModule = new FishSpecies();
        //        fishModule.Show();
        //    }
        //    if (SpeciesExist(name))
        //    {
        //        MessageBox.Show("Species (" + name + ") Doesn't Exists in Quota List!!!", "Unsuccesfull");
        //        FishSpecies fishModule = new FishSpecies();
        //        fishModule.Show();
        //    }
        //    else
        //    {
        //        string addFishQuery = "INSERT INTO FishSpecies VALUES (@fishId, @name)";
        //        OperationOnFish(fishId, name, addFishQuery, "Added");
        //    }
        //}

        ////View Fish Species
        //public static DataSet ViewFish()
        //{
        //    string query = "SELECT * FROM FishSpecies";
        //    SqlConnection connection = ConnectToDatabase();
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.CommandType = CommandType.Text;
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    DataSet dataSet = new DataSet();
        //    adapter.Fill(dataSet, "FishSpecies");
        //    return dataSet;
        //}

        ////Search Fish Species
        //public static DataSet SearchFish(string fishID)
        //{
        //    string searchFishQuery = "SELECT * FROM FishSpecies WHERE Fish_Id = @fishID";
        //    SqlDataAdapter adapter = SearchDataExist("@fishID", searchFishQuery, fishID);
        //    DataSet dataSet = new DataSet();
        //    if (adapter != null)
        //        adapter.Fill(dataSet, "FishSpecies");
        //    else
        //        MessageBox.Show("Fish Species Unavailable!!!");
        //    return dataSet;
        //}

        ////Update Fish
        //public static void UpdateFish(string fishID, string name)
        //{
        //    string checkFishQuery = "SELECT * FROM FishSpecies WHERE Fish_Id = @fishID";
        //    if (DataExist("@fishID", checkFishQuery, fishID))
        //    {
        //        string updateFishQuery = "UPDATE FishSpecies SET Name = @name WHERE Fish_Id = @fishID;";
        //        OperationOnFish(fishID, name, updateFishQuery, "Updated");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Fish with fish ID (" + fishID + ") Is Unavailable to Update!!!", "Unsuccessfull");
        //        FishSpecies fishModule = new FishSpecies();
        //        fishModule.Show();
        //    }
        //}

        ////Delete fish
        //public static void DeleteFish(string fishID)
        //{
        //    string checkFishQuery = "SELECT * FROM FishSpecies WHERE Fish_Id = @fishID";
        //    if (DataExist("@fishID", checkFishQuery, fishID))
        //    {
        //        string deleteFishQuery = "DELETE FROM FishSpecies WHERE Fish_Id = @fishID;";
        //        OperationOnFish(fishID, "",deleteFishQuery, "Deleted");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Fish Unavailable!!!", "Unsuccesfull");
        //        FishSpecies fishModule = new FishSpecies();
        //        fishModule.Show();
        //    }
        //}
        //#endregion

        
        //---------------------Quota--------------------------
        //View Quota
        #region
        public static DataSet ViewQuota()
        {
            string query = "SELECT * FROM Quotas";
            SqlConnection connection = ConnectToDatabase();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Quotas");
            return dataSet;
        }
        //Search Quota
        public static DataSet SearchQuota(string species)
        {
            string searchSpeciesQuery = "SELECT * FROM Quotas WHERE Species = @species";
            SqlDataAdapter adapter = SearchDataExist("@species", searchSpeciesQuery, species);
            DataSet dataSet = new DataSet();
            if (adapter != null)
                adapter.Fill(dataSet, "Quotas");
            else
            {
                MessageBox.Show("Species Unavailable!!!", "Oops");
            }
            return dataSet;
        }
        #endregion

        #region
       
        public static void AddCatches(string boatId, string species, string weight, string catchDate)
        {
            string checkCatchesQuery = "SELECT * FROM Catches WHERE Boat_Id = @boatID AND Species = @species";
            SqlConnection connection1 = ConnectToDatabase();
            SqlCommand command1 = new SqlCommand(checkCatchesQuery, connection1);
            command1.CommandType = CommandType.Text;
            command1.Parameters.AddWithValue("@boatID", boatId);
            command1.Parameters.AddWithValue("@species", species);
            command1.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command1);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show(boatId + " with " + species + " is Already Selected.\nYou can Update thier weight Now", "Oops");
                CatchesDetails catches = new CatchesDetails();
                catches.Show();
            }
            else
            {
                string addCatchesQuery = "INSERT INTO Catches VALUES (@boatId, @species, @weight, @catchDate)";
                SqlConnection connection = ConnectToDatabase();
                SqlCommand command = new SqlCommand(addCatchesQuery, connection);
                command.CommandType = CommandType.Text;
                //command.Parameters.AddWithValue("@catchId", 1);
                command.Parameters.AddWithValue("@boatId", boatId);
                command.Parameters.AddWithValue("@species", species);
                command.Parameters.AddWithValue("@weight", weight);
                command.Parameters.AddWithValue("@catchDate", catchDate);
                try
                {
                    command.ExecuteNonQuery();
                    ViewCatches();
                    MessageBox.Show("Catches Added Succesfully!!!", "Successfull");
                    CatchesDetails catchesDetails = new CatchesDetails();
                    catchesDetails.Show();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Operation Unsuccesfull!!!","Unsuccesfull");
                }
            }
        }

        //View Boat
        public static DataSet ViewCatches()
        {
            string query = "SELECT * FROM Catches";
            SqlConnection connection = ConnectToDatabase();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Catches");
            return dataSet;
        }

        //Search Catches
        public static DataSet SearchBoatInCatches(string boatID)
        {
            string searchCatchesQuery = "SELECT * FROM Catches WHERE Boat_Id = @boatID";
            SqlConnection connection = ConnectToDatabase();
            SqlCommand command = new SqlCommand(searchCatchesQuery, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@boatID", boatID);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataSet dataSet = new DataSet();
            if (dataTable.Rows.Count > 0)
                adapter.Fill(dataSet, "Catches");
            else
                MessageBox.Show("Catches Unavailable on This Boat!!!");
            return dataSet;
        }
        public static DataSet SearchSpeciesInCatches(string species)
        {
            string searchSpeciesQuery = "SELECT * FROM Catches WHERE Species = @species";
            SqlConnection connection = ConnectToDatabase();
            SqlCommand command = new SqlCommand(searchSpeciesQuery, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@species", species);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataSet dataSet = new DataSet();
            if (dataTable.Rows.Count > 0)
                adapter.Fill(dataSet, "Catches");
            else
                MessageBox.Show("This Species were not Caught!!!");
            return dataSet;
        }

        //Update Catches
        public static void UpdateCatches(string boatID, string species, string weight, string catchDate)
        {
            string checkBoatQuery = "SELECT * FROM Catches WHERE Boat_Id = @boatID AND Species = @species";

            SqlConnection connection1 = ConnectToDatabase();
            SqlCommand command1 = new SqlCommand(checkBoatQuery, connection1);
            command1.CommandType = CommandType.Text;
            command1.Parameters.AddWithValue("@boatID", boatID);
            command1.Parameters.AddWithValue("@species", species);
            command1.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command1);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                string updateCatchesQuery = "UPDATE Catches SET Weight_kg = Weight_kg + @weight, Catch_date = @catchDate WHERE Species = @species AND Boat_Id = @boatID;";
                //OperationOnCatches(boatID, species, weight, catchDate updateBoatQuery, "Updated");
                SqlConnection connection = ConnectToDatabase();
                SqlCommand command = new SqlCommand(updateCatchesQuery, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@boatId", boatID);
                command.Parameters.AddWithValue("@species", species);
                command.Parameters.AddWithValue("@weight", weight);
                command.Parameters.AddWithValue("@catchDate", catchDate);
                try
                {
                    command.ExecuteNonQuery();
                    ViewCatches();
                    MessageBox.Show("Catches Updated Succesfully!!!", "Successfull");
                    CatchesDetails catchesDetails = new CatchesDetails();
                    catchesDetails.Show(); 
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Updation Unsuccesfull!!!" + ex.Message, "Unsuccesfull");
                }
            }
            else
            {
                MessageBox.Show("No "+ species +" Available in "+ boatID +"to Update!!!");
                Catches catches= new Catches();
                catches.Show();
            }
        }

        #endregion

        public DataTable ViewQuotaReport()
        {
            DataTable table = new DataTable();
            string query = "SELECT C.Species, SUM(C.Weight_kg) AS Total_Weight_kg, Q.Quota_Limit_kg AS Quota_Limit_kg, SUM(C.Weight_kg) - Q.Quota_Limit_kg AS Weight_Difference_kg, CASE WHEN SUM(C.Weight_kg) > Q.Quota_Limit_kg THEN 'Overloaded' ELSE 'Normal' END AS Status FROM Catches C INNER JOIN Quotas Q ON C.Species = Q.Species GROUP BY C.Species, Q.Quota_Limit_kg";
            using (SqlConnection connection = ConnectToDatabase())//new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }
            return table;
        }

        public DataTable ViewQuotaReportInTons()
        {
            DataTable table = new DataTable();
            string query = "SELECT C.Species, SUM(C.Weight_kg) / 1000 AS Total_Weight_Tons, Q.Quota_Limit_kg / 1000 AS Quota_Limit_Tons, (SUM(C.Weight_kg) - Q.Quota_Limit_kg) / 1000 AS Weight_Difference_Tons, CASE WHEN SUM(C.Weight_kg) > Q.Quota_Limit_kg THEN 'Overloaded' ELSE 'Normal' END AS Status FROM Catches C INNER JOIN Quotas Q ON C.Species = Q.Species GROUP BY C.Species, Q.Quota_Limit_kg";
            using (SqlConnection connection = ConnectToDatabase())//new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }
            return table;
        }

        #region
        private static void OpenMainMenuForm()
        {
            Application.Run(new MainMenu());
        }

        private static void CloseMainMenuForm()
        {
            Application.OpenForms["MainMenu"].Close();
        }

        private static void OpenLoginForm()
        {
            Application.Run(new frmLogin());
        }
        #endregion
    }
}