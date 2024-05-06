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
    public partial class FormRegister : Form
    {
        public static string slqconn = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Trade_gpo_prokaev1;Data Source=MEPHI3-MSSQL";
        SqlConnection conn = new SqlConnection(slqconn);
        public int id;
        public int role;
        public FormRegister(int id1, int role1)
        {
            id = id1;
            role = role1;
            InitializeComponent();
        }
      

        private void FormRegister_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand logRequst = new SqlCommand($"select max( Id_user +1) from [user] ");
            logRequst.Connection = conn;
            SqlDataReader rd = logRequst.ExecuteReader();
            while (rd.Read())
            {

                textBoxID.Text =Convert.ToString(rd.GetInt32(0));

            }


            GendersLoad();
            RolesLoad();
            DirectionsLoad();
            EventsLoad();
        }

        private void EventsLoad()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(slqconn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT it_Ivent as id, Ivent FROM Ivent WHERE it_Ivent is not null", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            comboBoxMP.ValueMember = "id";
                            comboBoxMP.DisplayMember = "Ivent";
                            comboBoxMP.DataSource = dataTable;
                            comboBoxMP.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void DirectionsLoad()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(slqconn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT it_direction as id, direction FROM direction WHERE it_direction is not null", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            comboBoxNAPRV.ValueMember = "id";
                            comboBoxNAPRV.DisplayMember = "direction";
                            comboBoxNAPRV.DataSource = dataTable;
                            comboBoxNAPRV.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void RolesLoad()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(slqconn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT Id_role as id, role FROM Role", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            comboBoxROL.ValueMember = "id";
                            comboBoxROL.DisplayMember = "role";
                            comboBoxROL.DataSource = dataTable;
                            comboBoxROL.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void GendersLoad()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(slqconn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT DISTINCT Gender FROM [user]", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            comboBoxPOL.DisplayMember = "Gender";
                            comboBoxPOL.DataSource = dataTable;
                            comboBoxPOL.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand logRequst = new SqlCommand();
            logRequst.CommandType = CommandType.StoredProcedure;
            logRequst.CommandText = "personAdd";

            logRequst.Connection = conn;
            logRequst.Parameters.AddWithValue("@Id_person", textBoxID.Text);
            logRequst.Parameters.AddWithValue("@_Surname", textBoxFIO.Text);
            logRequst.Parameters.AddWithValue("@name", textBoxFIO.Text);
            logRequst.Parameters.AddWithValue("@Lastname", textBoxFIO.Text);
            logRequst.Parameters.AddWithValue("@Gender", comboBoxPOL.Text);
            logRequst.Parameters.AddWithValue("@role", comboBoxROL.SelectedIndex);
            logRequst.Parameters.AddWithValue("@E-mail", textBoxEMAIL.Text);
            logRequst.Parameters.AddWithValue("@phone", maskedTextBoxPHONE.Text);
            logRequst.Parameters.AddWithValue("@direction", comboBoxNAPRV.SelectedIndex);
            logRequst.Parameters.AddWithValue("@event", comboBoxMP.SelectedIndex);
            logRequst.Parameters.AddWithValue("@password", textBoxPPW.Text);
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormСhoice Profil = new FormСhoice(id, role);
            Profil.ShowDialog();
        }

        private void checkBoxMP_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMP.Visible = true;
        }
    }
}
