using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conference
{
    public partial class FormMain : Form
    {
        public static string slqconn = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Trade_gpo_prokaev1;Data Source=MEPHI3-MSSQL";
        SqlConnection conn = new SqlConnection(slqconn);
        int row = 0;
        public int id;
        public int role;
        public int Profil=0;

        public FormMain(int id1, int role1, int profil1)
        {
            id = id1;
            role = role1;
            InitializeComponent();
            Profil = profil1;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand logrec = new SqlCommand();
            logrec.CommandText = $"select * from [dbo].[Info]";
            logrec.Connection = conn;
            Image o = new Bitmap("C:\\Users\\it-student.MEPHI3.005\\Desktop\\conference\\image\\VnYkQHbmqi.jpg");
            DataGridViewColumn column = dataGridViewInformation.Columns[0];
            column.Width = 60;
            SqlDataReader reader = logrec.ExecuteReader();
            
            while (reader.Read())
            {
                dataGridViewInformation.Rows.Add();
                dataGridViewInformation.Rows[row].Cells[0].Value = o;
                dataGridViewInformation.Rows[row].Cells[1].Value = reader[0].ToString();
                dataGridViewInformation.Rows[row].Cells[2].Value = reader[1].ToString();
                dataGridViewInformation.Rows[row].Cells[3].Value = reader[2].ToString();

                row++;

            }
     
            conn.Close();
            conn.Open();
            DataTable tbl1 = new DataTable();
            logrec.CommandText = $"select * from [dbo].[Event]";
            comboBoxData.DataSource = tbl1;
            SqlDataAdapter da = new SqlDataAdapter(logrec);
            da.Fill(tbl1);
            comboBoxData.DisplayMember = "DATE";
            conn.Close();
            conn.Open();
            DataTable tbl = new DataTable();
            logrec.CommandText = $"select * from [dbo].[Info]";
            comboBoxEvent.DataSource = tbl;
            SqlDataAdapter da1 = new SqlDataAdapter(logrec);
            da1.Fill(tbl);
            comboBoxEvent.DisplayMember = "Activity";
            conn.Close();

        }

        private void comboBoxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            //conn.Close();
            //conn.Open();
            //SqlCommand logrec = new SqlCommand();
            //logrec.Connection = conn;
            //DataTable tbl2 = new DataTable();
            //logrec.CommandText = $"select * from [dbo].[Info] where {comboBoxData.SelectedValue} like [date] ";
            //comboBoxEvent.DataSource = tbl2;
            //SqlDataAdapter da2 = new SqlDataAdapter(logrec);
            //da2.Fill(tbl2);
            //comboBoxEvent.DisplayMember = "Activity";
            //conn.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {if (Profil == 0)
            {
                FormLogin login = new FormLogin();
                this.Hide();
                login.ShowDialog();
            }
            if (Profil == 1)
            {
                FormProfil login = new FormProfil(id,role);
                this.Hide();
                login.ShowDialog();
            }
        }
    }
}
