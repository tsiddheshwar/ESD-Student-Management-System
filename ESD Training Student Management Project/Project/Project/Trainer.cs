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
    public partial class Trainer : Form
    {
        public Trainer()
        {
            InitializeComponent();
            panel2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            AdminLoginBL ad = new AdminLoginBL();
            int studId = Int32.Parse(bunifuMaterialTextbox15.Text);
            int test1 = Int32.Parse(bunifuMaterialTextbox14.Text);
            int test2 = Int32.Parse(bunifuMaterialTextbox13.Text);
            int proj = Int32.Parse(bunifuMaterialTextbox12.Text);

            ad.AddMarks(studId, test1, test2, proj);
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {

            panel2.Visible = true;
            panel2.BringToFront();
            
           
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
            catch (Exception e1) { MessageBox.Show(e1.ToString());}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            panel5.BringToFront();
            panel2.Visible = false;
        }
    }
}
