namespace Sinaptik
{
    partial class FormMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonDayRes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelby = new System.Windows.Forms.Label();
            this.labelver = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 60F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(274, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 127);
            this.label1.TabIndex = 0;
            this.label1.Text = "  Синаптик  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.Color.DimGray;
            this.buttonClients.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonClients.FlatAppearance.BorderSize = 2;
            this.buttonClients.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClients.Font = new System.Drawing.Font("Calibri", 20F);
            this.buttonClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonClients.Location = new System.Drawing.Point(322, 214);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(340, 50);
            this.buttonClients.TabIndex = 1;
            this.buttonClients.TabStop = false;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.DimGray;
            this.buttonPay.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPay.FlatAppearance.BorderSize = 2;
            this.buttonPay.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.Font = new System.Drawing.Font("Calibri", 20F);
            this.buttonPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonPay.Location = new System.Drawing.Point(322, 270);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(340, 50);
            this.buttonPay.TabIndex = 4;
            this.buttonPay.TabStop = false;
            this.buttonPay.Text = "Бюджеты";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonDayRes
            // 
            this.buttonDayRes.BackColor = System.Drawing.Color.DimGray;
            this.buttonDayRes.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDayRes.FlatAppearance.BorderSize = 2;
            this.buttonDayRes.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonDayRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDayRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDayRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDayRes.Font = new System.Drawing.Font("Calibri", 20F);
            this.buttonDayRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonDayRes.Location = new System.Drawing.Point(322, 326);
            this.buttonDayRes.Name = "buttonDayRes";
            this.buttonDayRes.Size = new System.Drawing.Size(340, 50);
            this.buttonDayRes.TabIndex = 5;
            this.buttonDayRes.TabStop = false;
            this.buttonDayRes.Text = "Cтатистика";
            this.buttonDayRes.UseVisualStyleBackColor = false;
            this.buttonDayRes.Click += new System.EventHandler(this.buttonDayRes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.25F);
            this.label2.Location = new System.Drawing.Point(324, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Управление контекстной рекламой";
            // 
            // labelby
            // 
            this.labelby.AutoSize = true;
            this.labelby.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.labelby.Location = new System.Drawing.Point(706, 531);
            this.labelby.Name = "labelby";
            this.labelby.Size = new System.Drawing.Size(271, 23);
            this.labelby.TabIndex = 8;
            this.labelby.Text = "Разработано Страшко Артемием";
            // 
            // labelver
            // 
            this.labelver.AutoSize = true;
            this.labelver.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.labelver.Location = new System.Drawing.Point(7, 531);
            this.labelver.Name = "labelver";
            this.labelver.Size = new System.Drawing.Size(95, 23);
            this.labelver.TabIndex = 9;
            this.labelver.Text = "Версия 1.0";
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.DimGray;
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSettings.FlatAppearance.BorderSize = 2;
            this.buttonSettings.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Calibri", 20F);
            this.buttonSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonSettings.Location = new System.Drawing.Point(322, 382);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(340, 50);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.TabStop = false;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImage = global::Sinaptik.Properties.Resources.rebut3;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 20F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button1.Location = new System.Drawing.Point(668, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonDayRes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelver);
            this.Controls.Add(this.labelby);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormMenu";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonDayRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelby;
        private System.Windows.Forms.Label labelver;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button button1;
    }
}

