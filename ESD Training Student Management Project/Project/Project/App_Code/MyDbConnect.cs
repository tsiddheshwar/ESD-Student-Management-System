using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Project.App_Code
{
    class MyDbConnect
    {
        public MySqlConnection connection;
        //  public MySqlCommand cmd;
        //   public MySqlDataReader dataReader;
        public string host;
        public string database;
        public string userName;
        public string password;

        public MyDbConnect()
        {
            host = "localhost";
            database = "ESDTraining";
            userName = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + host + ";" + "DATABASE=" +
            database + ";" + "UID=" + userName + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Closing Connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


    }
}
