namespace conference
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewInformation = new System.Windows.Forms.DataGridView();
            this.ColumnLogo = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxEvent = new System.Windows.Forms.ComboBox();
            this.comboBoxData = new System.Windows.Forms.ComboBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformation)).BeginInit();
            this.panelDataGrid.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInformation
            // 
            this.dataGridViewInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewInformation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLogo,
            this.ColumnEvent,
            this.ColumnActivity,
            this.ColumnDate});
            this.dataGridViewInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInformation.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInformation.Name = "dataGridViewInformation";
            this.dataGridViewInformation.Size = new System.Drawing.Size(754, 552);
            this.dataGridViewInformation.TabIndex = 0;
            // 
            // ColumnLogo
            // 
            this.ColumnLogo.FillWeight = 50F;
            this.ColumnLogo.HeaderText = "Логотип";
            this.ColumnLogo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnLogo.Name = "ColumnLogo";
            this.ColumnLogo.ReadOnly = true;
            this.ColumnLogo.Width = 55;
            // 
            // ColumnEvent
            // 
            this.ColumnEvent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEvent.HeaderText = "название мероприятия";
            this.ColumnEvent.Name = "ColumnEvent";
            this.ColumnEvent.ReadOnly = true;
            this.ColumnEvent.Width = 150;
            // 
            // ColumnActivity
            // 
            this.ColumnActivity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnActivity.HeaderText = "направление мероприятия";
            this.ColumnActivity.Name = "ColumnActivity";
            this.ColumnActivity.ReadOnly = true;
            this.ColumnActivity.Width = 168;
            // 
            // ColumnDate
            // 
            this.ColumnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDate.HeaderText = "дата";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Width = 55;
            // 
            // comboBoxEvent
            // 
            this.comboBoxEvent.FormattingEnabled = true;
            this.comboBoxEvent.Location = new System.Drawing.Point(23, 12);
            this.comboBoxEvent.Name = "comboBoxEvent";
            this.comboBoxEvent.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEvent.TabIndex = 1;
            this.comboBoxEvent.SelectedIndexChanged += new System.EventHandler(this.comboBoxEvent_SelectedIndexChanged);
            // 
            // comboBoxData
            // 
            this.comboBoxData.FormattingEnabled = true;
            this.comboBoxData.Location = new System.Drawing.Point(151, 12);
            this.comboBoxData.Name = "comboBoxData";
            this.comboBoxData.Size = new System.Drawing.Size(121, 21);
            this.comboBoxData.TabIndex = 2;
            this.comboBoxData.SelectedIndexChanged += new System.EventHandler(this.comboBoxData_SelectedIndexChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(294, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Controls.Add(this.dataGridViewInformation);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 0);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(754, 552);
            this.panelDataGrid.TabIndex = 4;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.comboBoxEvent);
            this.panelButton.Controls.Add(this.buttonLogin);
            this.panelButton.Controls.Add(this.comboBoxData);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(754, 40);
            this.panelButton.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 552);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelDataGrid);
            this.MaximumSize = new System.Drawing.Size(770, 591);
            this.MinimumSize = new System.Drawing.Size(770, 591);
            this.Name = "FormMain";
            this.Text = "9";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformation)).EndInit();
            this.panelDataGrid.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInformation;
        private System.Windows.Forms.ComboBox comboBoxEvent;
        private System.Windows.Forms.ComboBox comboBoxData;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.DataGridViewImageColumn ColumnLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
    }
}

