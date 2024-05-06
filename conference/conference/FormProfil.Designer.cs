namespace conference
{
    partial class FormProfil
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonProfil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMP = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.labelHallo = new System.Windows.Forms.Label();
            this.buttonPL = new System.Windows.Forms.Button();
            this.labelPersonName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonProfil);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.buttonMP);
            this.panelMain.Controls.Add(this.buttonJ);
            this.panelMain.Controls.Add(this.labelHallo);
            this.panelMain.Controls.Add(this.buttonPL);
            this.panelMain.Controls.Add(this.labelPersonName);
            this.panelMain.Location = new System.Drawing.Point(12, 67);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(541, 337);
            this.panelMain.TabIndex = 12;
            // 
            // buttonProfil
            // 
            this.buttonProfil.Location = new System.Drawing.Point(39, 189);
            this.buttonProfil.Name = "buttonProfil";
            this.buttonProfil.Size = new System.Drawing.Size(110, 38);
            this.buttonProfil.TabIndex = 7;
            this.buttonProfil.Text = "Мой профиль";
            this.buttonProfil.UseVisualStyleBackColor = true;
            this.buttonProfil.Click += new System.EventHandler(this.buttonProfil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 106);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMP
            // 
            this.buttonMP.Location = new System.Drawing.Point(248, 93);
            this.buttonMP.Name = "buttonMP";
            this.buttonMP.Size = new System.Drawing.Size(94, 46);
            this.buttonMP.TabIndex = 3;
            this.buttonMP.Text = "Мероприятия";
            this.buttonMP.UseVisualStyleBackColor = true;
            this.buttonMP.Click += new System.EventHandler(this.buttonMP_Click);
            // 
            // buttonJ
            // 
            this.buttonJ.Location = new System.Drawing.Point(248, 189);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(94, 38);
            this.buttonJ.TabIndex = 5;
            this.buttonJ.Text = "Жюри";
            this.buttonJ.UseVisualStyleBackColor = true;
            this.buttonJ.Click += new System.EventHandler(this.buttonJ_Click);
            // 
            // labelHallo
            // 
            this.labelHallo.AutoSize = true;
            this.labelHallo.Location = new System.Drawing.Point(273, 24);
            this.labelHallo.Name = "labelHallo";
            this.labelHallo.Size = new System.Drawing.Size(35, 13);
            this.labelHallo.TabIndex = 1;
            this.labelHallo.Text = "label2";
            this.labelHallo.Visible = false;
            // 
            // buttonPL
            // 
            this.buttonPL.Location = new System.Drawing.Point(248, 145);
            this.buttonPL.Name = "buttonPL";
            this.buttonPL.Size = new System.Drawing.Size(94, 38);
            this.buttonPL.TabIndex = 4;
            this.buttonPL.Text = "Участники";
            this.buttonPL.UseVisualStyleBackColor = true;
            this.buttonPL.Click += new System.EventHandler(this.buttonPL_Click);
            // 
            // labelPersonName
            // 
            this.labelPersonName.AutoSize = true;
            this.labelPersonName.Location = new System.Drawing.Point(273, 77);
            this.labelPersonName.Name = "labelPersonName";
            this.labelPersonName.Size = new System.Drawing.Size(35, 13);
            this.labelPersonName.TabIndex = 2;
            this.labelPersonName.Text = "label3";
            this.labelPersonName.UseMnemonic = false;
            this.labelPersonName.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(193, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(221, 46);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Окно Жури";
            // 
            // FormProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 414);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.labelName);
            this.MaximumSize = new System.Drawing.Size(584, 453);
            this.MinimumSize = new System.Drawing.Size(584, 453);
            this.Name = "FormProfil";
            this.Text = "FormProfil";
            this.Load += new System.EventHandler(this.FormProfil_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonProfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMP;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Label labelHallo;
        private System.Windows.Forms.Button buttonPL;
        private System.Windows.Forms.Label labelPersonName;
        private System.Windows.Forms.Label labelName;
    }
}