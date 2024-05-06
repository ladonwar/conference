namespace conference
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxMP = new System.Windows.Forms.ComboBox();
            this.comboBoxNAPRV = new System.Windows.Forms.ComboBox();
            this.comboBoxROL = new System.Windows.Forms.ComboBox();
            this.comboBoxPOL = new System.Windows.Forms.ComboBox();
            this.buttonback = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.checkBoxVP = new System.Windows.Forms.CheckBox();
            this.labelPPW = new System.Windows.Forms.Label();
            this.labelPW = new System.Windows.Forms.Label();
            this.labelMP = new System.Windows.Forms.Label();
            this.labelNaprav = new System.Windows.Forms.Label();
            this.labelPHONE = new System.Windows.Forms.Label();
            this.labelEMAIL = new System.Windows.Forms.Label();
            this.labelROL = new System.Windows.Forms.Label();
            this.labelPOL = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.textBoxPPW = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxMP = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxPHONE = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEMAIL = new System.Windows.Forms.TextBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMP
            // 
            this.comboBoxMP.FormattingEnabled = true;
            this.comboBoxMP.Items.AddRange(new object[] {
            "IT в бизнесе",
            "Разработка приложений",
            "IT-инфраструктура",
            "Стартапы",
            "Информационная безопасность"});
            this.comboBoxMP.Location = new System.Drawing.Point(97, 297);
            this.comboBoxMP.Name = "comboBoxMP";
            this.comboBoxMP.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMP.TabIndex = 61;
            this.comboBoxMP.Visible = false;
            // 
            // comboBoxNAPRV
            // 
            this.comboBoxNAPRV.FormattingEnabled = true;
            this.comboBoxNAPRV.Items.AddRange(new object[] {
            "ИТ",
            "Биг Дата",
            "Дизайн",
            "Аналитика",
            "Информационная безопасность"});
            this.comboBoxNAPRV.Location = new System.Drawing.Point(106, 231);
            this.comboBoxNAPRV.Name = "comboBoxNAPRV";
            this.comboBoxNAPRV.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNAPRV.TabIndex = 60;
            // 
            // comboBoxROL
            // 
            this.comboBoxROL.FormattingEnabled = true;
            this.comboBoxROL.Location = new System.Drawing.Point(106, 150);
            this.comboBoxROL.Name = "comboBoxROL";
            this.comboBoxROL.Size = new System.Drawing.Size(121, 21);
            this.comboBoxROL.TabIndex = 59;
            // 
            // comboBoxPOL
            // 
            this.comboBoxPOL.FormattingEnabled = true;
            this.comboBoxPOL.Items.AddRange(new object[] {
            "Мужчины  ",
            "Женчины   "});
            this.comboBoxPOL.Location = new System.Drawing.Point(106, 121);
            this.comboBoxPOL.Name = "comboBoxPOL";
            this.comboBoxPOL.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPOL.TabIndex = 58;
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(447, 321);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(75, 23);
            this.buttonback.TabIndex = 57;
            this.buttonback.Text = "Отмена";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(366, 321);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 56;
            this.buttonOK.Text = "Ок";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // checkBoxVP
            // 
            this.checkBoxVP.AutoSize = true;
            this.checkBoxVP.Location = new System.Drawing.Point(366, 285);
            this.checkBoxVP.Name = "checkBoxVP";
            this.checkBoxVP.Size = new System.Drawing.Size(112, 17);
            this.checkBoxVP.TabIndex = 55;
            this.checkBoxVP.Text = "Видимый пароль";
            this.checkBoxVP.UseVisualStyleBackColor = true;
            // 
            // labelPPW
            // 
            this.labelPPW.AutoSize = true;
            this.labelPPW.Location = new System.Drawing.Point(276, 259);
            this.labelPPW.Name = "labelPPW";
            this.labelPPW.Size = new System.Drawing.Size(86, 13);
            this.labelPPW.TabIndex = 54;
            this.labelPPW.Text = "Повтор пароля:";
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.Location = new System.Drawing.Point(301, 220);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(48, 13);
            this.labelPW.TabIndex = 53;
            this.labelPW.Text = "Пароль:";
            // 
            // labelMP
            // 
            this.labelMP.AutoSize = true;
            this.labelMP.Location = new System.Drawing.Point(13, 297);
            this.labelMP.Name = "labelMP";
            this.labelMP.Size = new System.Drawing.Size(78, 13);
            this.labelMP.TabIndex = 52;
            this.labelMP.Text = "Мереприятие:";
            // 
            // labelNaprav
            // 
            this.labelNaprav.AutoSize = true;
            this.labelNaprav.Location = new System.Drawing.Point(11, 234);
            this.labelNaprav.Name = "labelNaprav";
            this.labelNaprav.Size = new System.Drawing.Size(78, 13);
            this.labelNaprav.TabIndex = 51;
            this.labelNaprav.Text = "Направление:";
            // 
            // labelPHONE
            // 
            this.labelPHONE.AutoSize = true;
            this.labelPHONE.Location = new System.Drawing.Point(11, 204);
            this.labelPHONE.Name = "labelPHONE";
            this.labelPHONE.Size = new System.Drawing.Size(55, 13);
            this.labelPHONE.TabIndex = 50;
            this.labelPHONE.Text = "Телефон:";
            // 
            // labelEMAIL
            // 
            this.labelEMAIL.AutoSize = true;
            this.labelEMAIL.Location = new System.Drawing.Point(11, 180);
            this.labelEMAIL.Name = "labelEMAIL";
            this.labelEMAIL.Size = new System.Drawing.Size(35, 13);
            this.labelEMAIL.TabIndex = 49;
            this.labelEMAIL.Text = "Email:";
            // 
            // labelROL
            // 
            this.labelROL.AutoSize = true;
            this.labelROL.Location = new System.Drawing.Point(11, 149);
            this.labelROL.Name = "labelROL";
            this.labelROL.Size = new System.Drawing.Size(35, 13);
            this.labelROL.TabIndex = 48;
            this.labelROL.Text = "Роль:";
            // 
            // labelPOL
            // 
            this.labelPOL.AutoSize = true;
            this.labelPOL.Location = new System.Drawing.Point(11, 121);
            this.labelPOL.Name = "labelPOL";
            this.labelPOL.Size = new System.Drawing.Size(30, 13);
            this.labelPOL.TabIndex = 47;
            this.labelPOL.Text = "Пол:";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(11, 98);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(37, 13);
            this.labelFIO.TabIndex = 46;
            this.labelFIO.Text = "ФИО:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(11, 68);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(56, 13);
            this.labelID.TabIndex = 45;
            this.labelID.Text = "Id Number";
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.Location = new System.Drawing.Point(101, 25);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(312, 25);
            this.labelMain.TabIndex = 44;
            this.labelMain.Text = "Регистрация жюри/модератора";
            // 
            // textBoxPPW
            // 
            this.textBoxPPW.Location = new System.Drawing.Point(366, 256);
            this.textBoxPPW.Name = "textBoxPPW";
            this.textBoxPPW.Size = new System.Drawing.Size(100, 20);
            this.textBoxPPW.TabIndex = 43;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(366, 217);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(369, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 102);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxMP
            // 
            this.checkBoxMP.AutoSize = true;
            this.checkBoxMP.Location = new System.Drawing.Point(106, 258);
            this.checkBoxMP.Name = "checkBoxMP";
            this.checkBoxMP.Size = new System.Drawing.Size(168, 17);
            this.checkBoxMP.TabIndex = 40;
            this.checkBoxMP.Text = "Прикрепить к мероприятию";
            this.checkBoxMP.UseVisualStyleBackColor = true;
            this.checkBoxMP.CheckedChanged += new System.EventHandler(this.checkBoxMP_CheckedChanged);
            // 
            // maskedTextBoxPHONE
            // 
            this.maskedTextBoxPHONE.Location = new System.Drawing.Point(106, 204);
            this.maskedTextBoxPHONE.Mask = "+7(999)-000-00-00";
            this.maskedTextBoxPHONE.Name = "maskedTextBoxPHONE";
            this.maskedTextBoxPHONE.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPHONE.TabIndex = 39;
            // 
            // textBoxEMAIL
            // 
            this.textBoxEMAIL.Location = new System.Drawing.Point(106, 177);
            this.textBoxEMAIL.Name = "textBoxEMAIL";
            this.textBoxEMAIL.Size = new System.Drawing.Size(100, 20);
            this.textBoxEMAIL.TabIndex = 38;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(106, 95);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(100, 20);
            this.textBoxFIO.TabIndex = 37;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(106, 68);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 36;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 380);
            this.Controls.Add(this.comboBoxMP);
            this.Controls.Add(this.comboBoxNAPRV);
            this.Controls.Add(this.comboBoxROL);
            this.Controls.Add(this.comboBoxPOL);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkBoxVP);
            this.Controls.Add(this.labelPPW);
            this.Controls.Add(this.labelPW);
            this.Controls.Add(this.labelMP);
            this.Controls.Add(this.labelNaprav);
            this.Controls.Add(this.labelPHONE);
            this.Controls.Add(this.labelEMAIL);
            this.Controls.Add(this.labelROL);
            this.Controls.Add(this.labelPOL);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.textBoxPPW);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxMP);
            this.Controls.Add(this.maskedTextBoxPHONE);
            this.Controls.Add(this.textBoxEMAIL);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.textBoxID);
            this.MaximumSize = new System.Drawing.Size(564, 419);
            this.MinimumSize = new System.Drawing.Size(564, 419);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.ComboBox comboBoxMP;
        private System.Windows.Forms.ComboBox comboBoxNAPRV;
        private System.Windows.Forms.ComboBox comboBoxROL;
        private System.Windows.Forms.ComboBox comboBoxPOL;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.CheckBox checkBoxVP;
        private System.Windows.Forms.Label labelPPW;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.Label labelMP;
        private System.Windows.Forms.Label labelNaprav;
        private System.Windows.Forms.Label labelPHONE;
        private System.Windows.Forms.Label labelEMAIL;
        private System.Windows.Forms.Label labelROL;
        private System.Windows.Forms.Label labelPOL;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.TextBox textBoxPPW;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxMP;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPHONE;
        private System.Windows.Forms.TextBox textBoxEMAIL;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxID;
    }
}