namespace Sinaptik
{
    partial class Authorization
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
            this.buttonClients = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.buttonClients.Location = new System.Drawing.Point(230, 203);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(340, 45);
            this.buttonClients.TabIndex = 2;
            this.buttonClients.TabStop = false;
            this.buttonClients.Text = "Клинеты";
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClients);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClients;
    }
}