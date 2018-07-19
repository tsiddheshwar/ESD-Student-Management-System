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
   
    public partial class Form1 : Form
    {
        public bool admin;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            string un = bunifuMaterialTextbox13.Text;
            string pass = bunifuMaterialTextbox12.Text;


            MyDbConnect m1 = new MyDbConnect();
            m1.OpenConnection();
            AdminLoginDAO a1 = new AdminLoginDAO();

            if (un.Equals("Admin") && pass.Equals("Admin123"))
            {
                this.Hide();
                new Admin().Show();
            }

            else if (a1.AdminLogin(un, pass))
            {
                this.Hide();
                new Trainer().Show();

            }
            m1.CloseConnection();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

        }
    }
}
