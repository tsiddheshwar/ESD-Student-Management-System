using MySql.Data.MySqlClient;
using Project.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            panel5.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {      
            panel4.Visible = true;
            panel5.Visible = false;
            panel4.BringToFront();
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
            panel4.Visible = false;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            AdminLoginBL ad = new AdminLoginBL();
            int id = Int32.Parse(bunifuMaterialTextbox1.Text);
            string name = bunifuMaterialTextbox2.Text;
            string branch = comboBox1.Text;
            string gender = null;
            if (materialRadioButton1.Checked)
            {
                gender = "Male";
            }
            if (materialRadioButton2.Checked)
            {
                gender = "Female";
            }
            int year = Int32.Parse(comboBox2.Text);

            string email = bunifuMaterialTextbox3.Text;
            long mobile = Int64.Parse(bunifuMaterialTextbox4.Text);
            ad.Add(id, name, branch, year, gender, email, mobile);
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox7.Text.Equals(bunifuMaterialTextbox8.Text))
            {
                AdminLoginBL ad = new AdminLoginBL();
                string name = bunifuMaterialTextbox5.Text;
                string uname = bunifuMaterialTextbox6.Text;
                string pass = bunifuMaterialTextbox7.Text;
                string email = bunifuMaterialTextbox9.Text;
                long mobile = Int64.Parse(bunifuMaterialTextbox10.Text);
                string session = bunifuMaterialTextbox11.Text;
                ad.AddTrainer(name, uname, pass, email, mobile, session);
            }
            else
            {
                MessageBox.Show("Password Missmatch..!!");
            }
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.BringToFront();
            panel5.Visible = true;
            
            try
            {
                MyDbConnect obj = new MyDbConnect();
                if (obj.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand("Select * from Students", obj.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dataReader);
                        dataGridView1.DataSource = dt;
                    }
                }

            }
            catch (Exception e1) { MessageBox.Show(e1.ToString()); }
        }
    }
}
