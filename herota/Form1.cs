using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herota
{
    public partial class Form1 : Form
    {
        public SqlConnection sqlconnect = new SqlConnection(@"Data Source=WIN-QSVU46CDT49\SQLHOME;Initial Catalog=test_sql;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
            sqlconnect.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand($"SELECT [ID_User]\r\n      ,[Login]\r\n      ,[Password]\r\n  FROM [dbo].[User] WHERE [Login] = '{textBox1.Text}' and [Password] = '{textBox2.Text}'", sqlconnect);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count==1)
            {
                MessageBox.Show("Информация", "Добро пожаловать!");
            }
            else
            {
                MessageBox.Show("Ошибка", "Неверный логин или пароль!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = System.IO.Path.GetFullPath("..\\IMG\\" + "lol.png");
        }
    }
}
//System.IO.Path.GetFullPath("..\\Услуги школы\\" + img)