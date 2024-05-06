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
    public partial class FormLogin : Form
    {
        public static string slqconn = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Trade_gpo_prokaev1;Data Source=MEPHI3-MSSQL";
        int id = 0;
        int counter = 0;
        int role = 0;
        string text;
        int gem = 10;
        SqlConnection sqlConnect = new SqlConnection(slqconn);
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Image o = new Bitmap("C:\\Users\\it-student.MEPHI3.005\\Desktop\\conference\\image\\VnYkQHbmqi.jpg");
            pictureBoxLogo.Image = o;
        }
        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            //Добавим различные цвета
            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };

            
            Graphics g = Graphics.FromImage((Image)result);

           
            g.Clear(Color.Gray);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

           
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }


        private void buttonLogin_Click_1(object sender, EventArgs e)
        {

            
            try
            {
                sqlConnect.Open();
                SqlCommand logRequest = new SqlCommand();
                logRequest.CommandType = CommandType.StoredProcedure;

                logRequest.CommandText = "login";
                logRequest.Parameters.AddWithValue("@login", Convert.ToInt32(textBoxLogin.Text));
                logRequest.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                logRequest.Connection = sqlConnect;
                SqlDataReader sqlReader = logRequest.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    SqlCommand logRequst = new SqlCommand($"Select * from [dbo].[User] Where Login ='{textBoxLogin.Text}'");
                    logRequst.Connection = sqlConnect;

                    while (sqlReader.Read())
                    {
                        id = Convert.ToInt32(sqlReader["Id_user"].ToString());
                        role = Convert.ToInt32(sqlReader["id_role"].ToString());
                    }
                    if (pictureBoxQapcha.Visible == false)
                    {
                        if (role == 1)
                        {
                            this.Hide();

                            FormProfil profil = new FormProfil(id, role);
                            profil.ShowDialog();
                        }
                        if (role == 2 )
                        {
                            this.Hide();

                            FormProfil profil = new FormProfil(id, role);
                            profil.ShowDialog();
                        }
                        if (role == 3)
                        {
                            this.Hide();

                            FormProfil profil = new FormProfil(id, role);
                            profil.ShowDialog();
                        }
                        if (role == 4)
                        {
                            this.Hide();

                            FormProfil profil = new FormProfil(id, role);
                            profil.ShowDialog();
                        }



                    }
                    if (pictureBoxQapcha.Visible == true && Text == textBoxQapcha.Text)
                    {
                        if (role == 1)
                        {
                            this.Hide();

                            FormProfil profil = new FormProfil(id, role);
                            profil.ShowDialog();
                        }
                        if (role == 2 || role == 3)
                        {
                            this.Hide();

                            FormProfil profil = new FormProfil(id, role);
                            profil.ShowDialog(); ;
                        }
                        if (role == 3)
                        {
                            this.Hide();

                            FormProfil profil = new FormProfil(id, role);
                            profil.ShowDialog();
                        }
                        if (role == 4)
                        {
                            this.Hide();

                            FormProfil profil = new FormProfil(id, role);
                            profil.ShowDialog();
                        }

                    }
                    else
                    {
                        if (text != textBoxQapcha.Text && pictureBoxQapcha.Visible == true)
                        {
                            MessageBox.Show("Введите капчу");

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                    if (counter >= 3)
                    {
                        buttonLogin.Location = new Point(130, 215);

                        pictureBoxQapcha.Image = this.CreateImage(pictureBoxQapcha.Width, pictureBoxQapcha.Height);
                        pictureBoxQapcha.Visible = true;
                        textBoxQapcha.Visible = true;
                        buttonUpdate.Visible = true;
                        buttonLogin.Enabled = false;

                        timer.Enabled = true;
                        MessageBox.Show("Следующая попытка через 10 секунд");

                    }

                    counter++;
                }
            





            }
            catch
            {
                MessageBox.Show("Неверный логин или пароль");
                counter++;
                if (counter >= 3)
                {
                    buttonLogin.Location = new Point(130, 215);

                    pictureBoxQapcha.Image = this.CreateImage(pictureBoxQapcha.Width, pictureBoxQapcha.Height);
                    pictureBoxQapcha.Visible = true;
                    textBoxQapcha.Visible = true;
                    buttonUpdate.Visible = true;
                    buttonLogin.Enabled = false;

                    timer.Enabled = true;
                    MessageBox.Show("Следующая попытка через 10 секунд");

                }
            }
            sqlConnect.Close();

        }       
        private void timerLogin_Tick(object sender, EventArgs e)
        {
            if (gem > 0)
            {
                gem--;
                
            }
            if (gem == 0)
            {
                buttonLogin.Enabled = true;

                timer.Enabled = false;
                gem = 10;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            pictureBoxQapcha.Image = this.CreateImage(pictureBoxQapcha.Width, pictureBoxQapcha.Height);
            textBoxQapcha.Clear();
        }
    }
}
