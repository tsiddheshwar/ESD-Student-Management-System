using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.App_Code
{
    class AdminLoginBL
    {
       
        public void Add(int Id, string name, string branch, int year, string gender, string email, long mobile)
        {
            AdminLoginDAO a1 = new AdminLoginDAO();
            if (a1.AddStudDAO(Id,name,branch,year,gender,email,mobile))
            {
                MessageBox.Show("inserted");
            }
            else
            {
                MessageBox.Show("not inserted");
            }
        }
        public void AddTrainer(string name,string uname,string pass,string email, long mobile,string session)
        {
            AdminLoginDAO a1 = new AdminLoginDAO();
            if (a1.AddTrainerDAO(name,uname,pass,email, mobile,session))
            {
                MessageBox.Show("inserted");
            }
            else
            {
                MessageBox.Show("not inserted");
            }
        }
        public void AddMarks(int id,int t1,int t2,int proj)
        {
            AdminLoginDAO a1 = new AdminLoginDAO();
            if (a1.AddMark(id,t1,t2,proj))
            {
                MessageBox.Show("inserted");
            }
            else
            {
                MessageBox.Show("not inserted");
            }
        }
        internal void Add(int id, string name, string branch, string year, object gender, string email)
        {
            throw new NotImplementedException();
        }
    }
}
