namespace Sinaptik
{
    partial class FormAdvertisingCamp
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WebSite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Strategy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Budget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Place = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Consumption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxUserWeb = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxStrategy = new System.Windows.Forms.ComboBox();
            this.comboBoxBudget = new System.Windows.Forms.ComboBox();
            this.comboBoxPlace = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(399, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "  Рекламные кампании  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSettings.FlatAppearance.BorderSize = 2;
            this.buttonSettings.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Calibri", 14F);
            this.buttonSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonSettings.Location = new System.Drawing.Point(12, 510);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(211, 39);
            this.buttonSettings.TabIndex = 8;
            this.buttonSettings.Text = "Вернуться назад";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Type,
            this.WebSite,
            this.Status,
            this.Strategy,
            this.Budget,
            this.Place,
            this.Consumption});
            this.listView1.Font = new System.Drawing.Font("Calibri", 14F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(223, 95);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1149, 409);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 40;
            // 
            // Type
            // 
            this.Type.Text = "Тип";
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Type.Width = 100;
            // 
            // WebSite
            // 
            this.WebSite.Text = "Вебсайт";
            this.WebSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WebSite.Width = 200;
            // 
            // Status
            // 
            this.Status.Text = "Статус";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Status.Width = 150;
            // 
            // Strategy
            // 
            this.Strategy.Text = "Стратегия";
            this.Strategy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Strategy.Width = 150;
            // 
            // Budget
            // 
            this.Budget.Text = "Бюджет";
            this.Budget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Budget.Width = 150;
            // 
            // Place
            // 
            this.Place.Text = "Места показов";
            this.Place.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Place.Width = 200;
            // 
            // Consumption
            // 
            this.Consumption.Text = "Расход";
            this.Consumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Consumption.Width = 150;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 14F);
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonAdd.Location = new System.Drawing.Point(305, 510);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(211, 39);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.FlatAppearance.BorderSize = 2;
            this.buttonEdit.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 14F);
            this.buttonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonEdit.Location = new System.Drawing.Point(522, 510);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(211, 39);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.FlatAppearance.BorderSize = 2;
            this.buttonDelete.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 14F);
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonDelete.Location = new System.Drawing.Point(739, 510);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(211, 39);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Calibri", 14F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Имиджевая",
            "Продуктовая",
            "Торговая"});
            this.comboBoxType.Location = new System.Drawing.Point(57, 95);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(148, 31);
            this.comboBoxType.TabIndex = 10;
            // 
            // comboBoxUserWeb
            // 
            this.comboBoxUserWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.comboBoxUserWeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserWeb.Font = new System.Drawing.Font("Calibri", 14F);
            this.comboBoxUserWeb.FormattingEnabled = true;
            this.comboBoxUserWeb.Location = new System.Drawing.Point(57, 148);
            this.comboBoxUserWeb.Name = "comboBoxUserWeb";
            this.comboBoxUserWeb.Size = new System.Drawing.Size(148, 31);
            this.comboBoxUserWeb.TabIndex = 11;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Calibri", 14F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Запущен",
            "Приостановлен",
            "Отсутствует"});
            this.comboBoxStatus.Location = new System.Drawing.Point(57, 201);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(148, 31);
            this.comboBoxStatus.TabIndex = 12;
            // 
            // comboBoxStrategy
            // 
            this.comboBoxStrategy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.comboBoxStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStrategy.Font = new System.Drawing.Font("Calibri", 14F);
            this.comboBoxStrategy.FormattingEnabled = true;
            this.comboBoxStrategy.Items.AddRange(new object[] {
            "Последовательное постоянное",
            "Импульсное",
            "Сезонное",
            "Флайтовое"});
            this.comboBoxStrategy.Location = new System.Drawing.Point(57, 254);
            this.comboBoxStrategy.Name = "comboBoxStrategy";
            this.comboBoxStrategy.Size = new System.Drawing.Size(148, 31);
            this.comboBoxStrategy.TabIndex = 13;
            // 
            // comboBoxBudget
            // 
            this.comboBoxBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.comboBoxBudget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBudget.Font = new System.Drawing.Font("Calibri", 14F);
            this.comboBoxBudget.FormattingEnabled = true;
            this.comboBoxBudget.Location = new System.Drawing.Point(57, 307);
            this.comboBoxBudget.Name = "comboBoxBudget";
            this.comboBoxBudget.Size = new System.Drawing.Size(148, 31);
            this.comboBoxBudget.TabIndex = 14;
            // 
            // comboBoxPlace
            // 
            this.comboBoxPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.comboBoxPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlace.Font = new System.Drawing.Font("Calibri", 14F);
            this.comboBoxPlace.FormattingEnabled = true;
            this.comboBoxPlace.Items.AddRange(new object[] {
            "Баннеры",
            "На поиске",
            "На сайте",
            "Преролл к видео",
            "Всплывающее окно"});
            this.comboBoxPlace.Location = new System.Drawing.Point(57, 360);
            this.comboBoxPlace.Name = "comboBoxPlace";
            this.comboBoxPlace.Size = new System.Drawing.Size(148, 31);
            this.comboBoxPlace.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14F);
            this.textBox1.Location = new System.Drawing.Point(57, 413);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 31);
            this.textBox1.TabIndex = 16;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // FormAdvertisingCamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1384, 561);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxPlace);
            this.Controls.Add(this.comboBoxBudget);
            this.Controls.Add(this.comboBoxStrategy);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxUserWeb);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 600);
            this.MinimumSize = new System.Drawing.Size(1400, 600);
            this.Name = "FormAdvertisingCamp";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Рекламные кампании";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdvertisingCamp_FormClosed);
            this.Load += new System.EventHandler(this.FormAdvertisingCamp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader WebSite;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Strategy;
        private System.Windows.Forms.ColumnHeader Budget;
        private System.Windows.Forms.ColumnHeader Place;
        private System.Windows.Forms.ColumnHeader Consumption;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxUserWeb;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxStrategy;
        private System.Windows.Forms.ComboBox comboBoxBudget;
        private System.Windows.Forms.ComboBox comboBoxPlace;
        private System.Windows.Forms.TextBox textBox1;
    }
}