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
    public partial class FormСhoice : Form
    {
        public static string slqconn = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Trade_gpo_prokaev1;Data Source=MEPHI3-MSSQL";
        SqlConnection conn = new SqlConnection(slqconn);
        public int id;
        public int role;
        public FormСhoice(int id1, int role1)
        {
            id = id1;
            role = role1;
            InitializeComponent();
        }

        private void FormСhoice_Load(object sender, EventArgs e)
        {
            if (role == 1)
                buttonReg.Visible = true;
            else
                buttonReg.Visible = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfil Organization = new FormProfil(id, role);
            Organization.ShowDialog();
        }

        private void buttonChange_Click(object sender, EventArgs e)

        {
            FormCange cange = new FormCange(id, role);
            cange.ShowDialog();
            this.Hide();
            

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister register = new FormRegister(id, role);
            register.ShowDialog();
        }
    }
}
