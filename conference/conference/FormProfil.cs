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
    public partial class FormProfil : Form
    {
        public static string slqconn = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Trade_gpo_prokaev1;Data Source=MEPHI3-MSSQL";
        SqlConnection conn = new SqlConnection(slqconn);
        public int id;
        public int role;
        int people;
        public FormProfil(int id1, int role1)
        {
            id = id1;
            role = role1;
            InitializeComponent();
        }

        private void FormProfil_Load(object sender, EventArgs e)
        {
            SqlCommand logRequst = new SqlCommand();
            conn.Open();
            if (role == 1)
                labelName.Text = "Окно Модератора";
            if (role == 2)
                labelName.Text = "Окно Жюри";
            if (role == 3)
                labelName.Text = "Окно Организатора";
            if (role == 4)
                labelName.Text = "Окно Участника";



            logRequst.CommandText = ($"Select * from [user] Where [id_user] ='{id}'");
            logRequst.Connection = conn;
            SqlDataReader rd = logRequst.ExecuteReader();
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            
            while (rd.Read())
            {
                
                
                if (rd.GetString(5) == Convert.ToString("мужской"))
                {
                    labelPersonName.Text = "Mr " + rd.GetString(2) + " " + rd.GetString(3) + " " + rd.GetString(4); labelPersonName.Visible = true;
                }
                else
                {
                    labelPersonName.Text = "Mrs " + rd.GetString(2) + " " + rd.GetString(3) + " " + rd.GetString(4); labelPersonName.Visible = true;
                }
                if (dt.Hour > 6)
                {
                    if (dt.Hour < 12)
                        labelHallo.Text = "Доброе утро "; labelHallo.Visible = true;
                }

                if (dt.Hour > 12)
                {
                    if (dt.Hour < 18)
                        labelHallo.Text = "Добрый день "; labelHallo.Visible = true;
                }

                if (dt.Hour > 18)
                {
                    if (dt.Hour < 24)
                        labelHallo.Text = "Добрый вечер "; labelHallo.Visible = true;
                }

                if (dt.Hour > 24)
                {
                    if (dt.Hour < 6)
                        labelHallo.Text = "Доброй ночи "; labelHallo.Visible = true;
                }
            }
        }

        private void buttonMP_Click(object sender, EventArgs e)
        {int Profil=1;
            this.Hide();

            FormMain event1 = new FormMain(id, role,Profil);
            event1.ShowDialog();
        }

        private void buttonPL_Click(object sender, EventArgs e)
        {
            people = 1;
            this.Hide();

            FormPeopleInformation participant = new FormPeopleInformation(id, role, people);
            participant.ShowDialog();
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            people = 2;
            FormPeopleInformation Jurilist = new FormPeopleInformation(id, role, people);
            Jurilist.ShowDialog();
        }

        private void buttonProfil_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormСhoice Profil = new FormСhoice(id, role);
            Profil.ShowDialog();
        }
    }
}
