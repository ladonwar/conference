using Microsoft.SqlServer.Server;
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

namespace conference
{
    public partial class FormPeopleInformation : Form
    {
        public static string slqconn = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Trade_gpo_prokaev1;Data Source=MEPHI3-MSSQL";
        SqlConnection conn = new SqlConnection(slqconn);
        public int id;
        public int role;
        public int people;
        public FormPeopleInformation(int id1, int role1,int people1)
        {
            id = id1;
            role = role1;
            people = people1;
            InitializeComponent();
        }

        private void FormPeopleInformation_Load(object sender, EventArgs e)
        {
            if (people == 1) {
                SqlCommand logRequst = new SqlCommand();
                logRequst.CommandText = $"SELECT * FROM  [dbo].[name] where [Роль] = 'участники' ";
                logRequst.Connection = conn;
                SqlDataAdapter adapter = new SqlDataAdapter(logRequst);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridViewOccasion.DataSource = dataSet.Tables[0];
            }
            if (people == 2)
            {
                SqlCommand logRequst = new SqlCommand();
                logRequst.CommandText = $"SELECT * FROM [dbo].[name] where [Роль] = 'жюри' ";
                logRequst.Connection = conn;
                SqlDataAdapter adapter = new SqlDataAdapter(logRequst);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridViewOccasion.DataSource = dataSet.Tables[0];
            }


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfil Juri = new FormProfil(id, role);
            Juri.ShowDialog();
        }
    }
}
