using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text =="")
            {
                MessageBox.Show("Fill mandatory fields");
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Passwords donot match", " Help", MessageBoxButtons.RetryCancel);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=Desktop-30389UE;Initial Catalog=Credentials;Integrated Security=True;Encrypt=False;");
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Credentials]\r\n           ([Username]\r\n ,[Password])\r\n  VALUES\r\n " +
                    "     ('" + textBox1.Text + "' ,'" + textBox2.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                //    con.Close();

                MessageBox.Show("Data submitted successfully");

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
