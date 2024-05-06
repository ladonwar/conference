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
    public partial class FormCange : Form
    {
        public static string slqconn = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Trade_gpo_prokaev1;Data Source=MEPHI3-MSSQL";
        SqlConnection conn = new SqlConnection(slqconn);
        public int id;
        public int role;
        public FormCange(int id1, int role1)
        {
            id = id1;
            role = role1;
            InitializeComponent();
        }

        private void FormCange_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (role == 1 && role == 4)
            {
                comboBoxMP.Visible = false;
                comboBoxNAPRV.Visible = false;
                checkBoxMP.Visible = false;
            }

            SqlCommand logRequst = new SqlCommand($"Select * from [user] Where Id_user ={id}");
            logRequst.Connection = conn;
            SqlDataReader rd = logRequst.ExecuteReader();
            GendersLoad();
            RolesLoad();
            DirectionsLoad();
            EventsLoad();
            while (rd.Read())
            {

                textBoxID.Text = rd["Id_user"].ToString();
                textBoxFIO.Text = rd["Sername"].ToString() + rd["name"].ToString() + rd["Lastname"].ToString();

                textBoxEMAIL.Text = rd["Email"].ToString();
                maskedTextBoxPHONE.Text = rd["Phone"].ToString();

                textBoxPassword.Text = rd["Password"].ToString();


            }

           




           

            conn.Close();
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
            logRequst.Connection = conn;
            logRequst.CommandType = CommandType.StoredProcedure;
            logRequst.CommandText = "personUpdate";
            SqlCommand logRequstsd = new SqlCommand();
            logRequstsd.Connection = conn;
            logRequstsd.CommandType = CommandType.StoredProcedure;
            logRequstsd.CommandText = "personUpdate";
            logRequst.Parameters.AddWithValue("@Id_person", textBoxID.Text);
            logRequst.Parameters.AddWithValue("@_Surname", textBoxFIO.Text);
            logRequst.Parameters.AddWithValue("@name", textBoxFIO.Text);
            logRequst.Parameters.AddWithValue("@Lastname", textBoxFIO.Text);
            logRequst.Parameters.AddWithValue("@Gender", comboBoxPOL.Text);
            logRequst.Parameters.AddWithValue("@role", comboBoxROL.SelectedIndex);
            logRequst.Parameters.AddWithValue("@Email", textBoxEMAIL.Text);
            logRequst.Parameters.AddWithValue("@phone", maskedTextBoxPHONE.Text);
            logRequst.Parameters.AddWithValue("@direction", comboBoxNAPRV.SelectedIndex);
            logRequst.Parameters.AddWithValue("@event", comboBoxMP.SelectedIndex);
            logRequst.Parameters.AddWithValue("@password", textBoxPPW.Text);





            try
            {
                logRequst.ExecuteNonQuery();
                MessageBox.Show("Данные изменены");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! : " + ex.Message);
            }
            finally
            {
                conn.Close();

            }
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormProfil Profil = new FormProfil(id, role);
            Profil.ShowDialog();
        }
    }
}
