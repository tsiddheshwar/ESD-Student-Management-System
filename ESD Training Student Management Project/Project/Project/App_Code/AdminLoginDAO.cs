using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Project.App_Code
{
    class AdminLoginDAO
    {
        #region Initialisation
        MyDbConnect db;
        public MySqlCommand cmd;
        public MySqlDataReader dataReader;
        public string userName { get; set; }
        public string password { get; set; }
        #endregion


        #region Constructor
        public AdminLoginDAO()
        {
            db = new MyDbConnect();
        }
        #endregion


        #region Methods
        // Code for Validate Login Details
        public bool AdminLogin(string uname, string pass)
        {
            if (db.OpenConnection())
            {
                string query = "SELECT * FROM Admin";
                cmd = new MySqlCommand(query, db.connection);
                dataReader = cmd.ExecuteReader();
                
                while (dataReader.Read())
                {

                    if (uname.Equals(dataReader["Username"].ToString()))
                    {
                        if (pass.Equals(dataReader["Password"].ToString()))
                        {
                            return true;
                        }
                       

                    }

                }   //end of while
           
                    
                   
                    
                

            }    //end of if condition
            MessageBox.Show("Invalid Username or Password !!!");
            return false;
        }
        public bool AddStudDAO(int Id,string name, string branch, int year, string gender, string email,long mobile)
        {
            if (db.OpenConnection())
            {
                MySqlParameter p1, p2,p3,p4,p5,p6,p7;
                p1 = new MySqlParameter("@id", Id);
                p2 = new MySqlParameter("@name", name);
                p3 = new MySqlParameter("@branch", branch);
                p4 = new MySqlParameter("@year", year);
                p5 = new MySqlParameter("@gender", gender);
                p6 = new MySqlParameter("@email", email);
                p7 = new MySqlParameter("@mobile", mobile);

                string query = "INSERT INTO Students(Id,name,branch,year,gender,email,mobile) VALUES(@id,@name,@branch,@year,@gender,@email,@mobile)";
               
                cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);

                cmd.ExecuteNonQuery();

                return true;
            }
            return false;
        }
        public bool AddTrainerDAO(string name, string uname, string pass,string email,long mobile, string session)
        {
            if (db.OpenConnection())
            {
                MySqlParameter p1, p2, p3, p4, p5, p6;
                p1 = new MySqlParameter("@name", name);
                p2 = new MySqlParameter("@uname", uname);
                p3 = new MySqlParameter("@pass", pass);
                p4 = new MySqlParameter("@email",email);
                p5 = new MySqlParameter("@mobile",mobile);
                p6 = new MySqlParameter("@session", session);

                string query = "INSERT INTO Trainer(name,uname,pass,email,mobile,session) VALUES(@name,@uname,@pass,@email,@mobile,@session)";
                string query1 = "INSERT INTO Admin(Username,Password) VALUES(@uname,@pass)";
                
                cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);

                cmd.ExecuteNonQuery();
                cmd=new MySqlCommand(query1,db.connection);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.ExecuteNonQuery();

                return true;
            }
            return false;
        }
        public bool AddMark(int id, int t1, int t2, int proj)
        {
            if (db.OpenConnection())
            {
                MySqlParameter p1, p2, p3, p4;
                p1 = new MySqlParameter("@id",id);
                p2 = new MySqlParameter("@t1", t1);
                p3 = new MySqlParameter("@t2",t2);
                p4 = new MySqlParameter("@proj",proj);
               

                string query = "UPDATE Students SET Marks1=@t1,Marks2=@t2,project=@proj where Id=@id";
               

                cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);


                cmd.ExecuteNonQuery();
          

                return true;
            }
            return false;
        }



        #endregion
    }
}
