namespace conference
{
    partial class FormСhoice
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
            this.LableText = new System.Windows.Forms.Label();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LableText
            // 
            this.LableText.AutoSize = true;
            this.LableText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableText.Location = new System.Drawing.Point(11, 9);
            this.LableText.Name = "LableText";
            this.LableText.Size = new System.Drawing.Size(184, 31);
            this.LableText.TabIndex = 17;
            this.LableText.Text = "Мой профиль";
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(26, 88);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(151, 37);
            this.buttonReg.TabIndex = 16;
            this.buttonReg.Text = "регистрация жюри/модераторов";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Visible = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(26, 58);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(151, 24);
            this.buttonChange.TabIndex = 15;
            this.buttonChange.Text = "Изменить данные";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(26, 131);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(151, 31);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormСhoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 191);
            this.Controls.Add(this.LableText);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonBack);
            this.MaximumSize = new System.Drawing.Size(223, 230);
            this.MinimumSize = new System.Drawing.Size(223, 230);
            this.Name = "FormСhoice";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormСhoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LableText;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonBack;
    }
}