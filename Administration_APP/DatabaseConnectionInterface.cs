using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Administration_APP
{
   
    class DatabaseConnectionInterface
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string port;
        private string username;
        private string password;    

        bool errorToUserInterface;
        bool errorToGraphicalUserInterface;
        private string errorMessage;
        private MySqlDataAdapter dataAdapter;
        private MySqlCommandBuilder commandBuilder;
        public DatabaseConnectionInterface()
        {
            server = string.Empty;
            database = string.Empty;
            port = string.Empty;
            username = string.Empty;
            password = string.Empty;
        }
        private bool isEmptyOneParameter()
        {
            if (server == string.Empty)
                return true;
            else if (database == string.Empty)
                return true;
            else if (port == string.Empty)
                return true;
            else if (username == string.Empty)
                return true;
            else if (password == string.Empty)
                return true;
            else return false;

        }
        public bool isConnectionExsist()
        {
            if (connection == null)
                return false;
            else
                return true;
        }
        public void setConnectionServerData(string server, string database, string port)
        {
            this.server = server;
            this.database = database;
            this.port = port;
        }
        public void setConnectionUserData(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public void makeConnectionToDatabase()
        {
            if (isEmptyOneParameter())
            {
                connection = null;
                return;
            }
            string connectionString = "SERVER=" + server + ";"
                                    + "DATABASE=" + database + ";"
                                    + "PORT="+port+";"
                                    + "UID=" + username + ";"
                                    + "PASSWORD=" + password + ";";
            try
            {
                connection = new MySqlConnection(connectionString);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public bool open()
        {
            if (!isConnectionExsist())
                return false;
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException me)
            {
                
                switch (me.Number)
                {
                    case 0:
                        
                        break;

                    case 1045:
                        
                        break;
                    default:
                       
                        break;
                }
                connection = null;
                return false;
            }
        }
        public bool close()
        {
            if (!isConnectionExsist())
                return false;
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool isExecutableQuery(string query)
        {
            if (query == string.Empty)
            {
                return false;
            }
            if (!isConnectionExsist())
            {
                return false;
            }
            return true;
        }
        public void executeDMQuery(string query)
        {

            if (!isExecutableQuery(query))
            {
                return;
            }
            MySqlCommand cmd;
            try
            {
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me.Message);
            }
            finally
            {
            }
        }
        public string getOneField(string query)
       
        {
            query += "LIMIT 1";
            string result = string.Empty;
            if (!isExecutableQuery(query))
            {
                return string.Empty;
            }
            MySqlDataReader dataReader = null;
            try
            {
               
                MySqlCommand cmd = new MySqlCommand(query, connection);
                
                dataReader = cmd.ExecuteReader();
                
                dataReader.Read();
                result = dataReader[0].ToString();

            }
            catch (MySqlException me)
            {
                Console.WriteLine(me.Message);
            }
            finally
            {
                if (dataReader != null)
                {
                   
                    dataReader.Close();
                }
            }
           
            return result;
        }

        public string executeScalarQuery(string query)
        {
            string scalar = string.Empty;

            if (!isExecutableQuery(query))
            {
                return scalar;
            }
            MySqlCommand cmd;
            try
            {
                cmd = new MySqlCommand(query, connection);
               
                scalar = cmd.ExecuteScalar().ToString();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me.Message);
            }
            finally
            {

            }
            return scalar;
        }
        public DataTable getToDataTable(string query) 
        {
           
            DataTable dt = new DataTable();
            if (!isExecutableQuery(query))
            {
                return dt;
            }
            MySqlCommand cmd;
            try
            {
                cmd = new MySqlCommand(query, connection);
                if (cmd == null)
                    return dt;
                dataAdapter = new MySqlDataAdapter(cmd);
                commandBuilder = new MySqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(dt);

            }
            catch (MySqlException me)
            {
                setErrorDataAndShow("Error in database query.\n" +
                                                    me.Message
                                                    );
            }
            finally
            {
            }
            return dt;
        }
        public void setErrorToUserInterface(bool etui)
        {
            errorToUserInterface = etui;
        }
        public void setErrorToGraphicalUserInterface(bool etgui)
        {
            errorToGraphicalUserInterface = etgui;
        }

        private void writeErrorToConsoleUserInterface()
        {
            Console.WriteLine("Error in the following operation:");
            Console.WriteLine(errorMessage);
        }

        private void writeErrorToGrapichalUserInterface()
        {
                MessageBox.Show(
                "Database error:" + errorMessage,
                "Database error...",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
           );
        }
        private void setErrorDataAndShow(string message)
        {
            errorMessage = message;
            if (errorToUserInterface)
            {
                if (errorToGraphicalUserInterface)
                    writeErrorToGrapichalUserInterface();
                else
                    writeErrorToConsoleUserInterface();
            }

        }
    }

}
