using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection fon = new SqlConnection("Data Source =.; Initial Catalog=Credentials; Integrated Security = True");
            string query = "Select * FROM Credentials where Username='" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'";
            fon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, fon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else 
            {
                MessageBox.Show("Try to enter Correct credentials...", "Info", MessageBoxButtons.OKCancel);
            }
        }
    }
}
