namespace FishingFleet
{
    partial class MainMenu
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUsr = new System.Windows.Forms.Label();
            this.btnQuotaReport = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnCatches = new System.Windows.Forms.Button();
            this.btnQuota = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Blue;
            this.lblTime.Location = new System.Drawing.Point(319, 26);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(108, 22);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Date & Time";
            // 
            // lblUsr
            // 
            this.lblUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsr.ForeColor = System.Drawing.Color.Blue;
            this.lblUsr.Location = new System.Drawing.Point(54, 27);
            this.lblUsr.Name = "lblUsr";
            this.lblUsr.Size = new System.Drawing.Size(78, 22);
            this.lblUsr.TabIndex = 7;
            this.lblUsr.Text = "Admin: ";
            // 
            // btnQuotaReport
            // 
            this.btnQuotaReport.BackColor = System.Drawing.Color.Blue;
            this.btnQuotaReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuotaReport.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuotaReport.ForeColor = System.Drawing.Color.White;
            this.btnQuotaReport.Location = new System.Drawing.Point(86, 162);
            this.btnQuotaReport.Name = "btnQuotaReport";
            this.btnQuotaReport.Size = new System.Drawing.Size(420, 40);
            this.btnQuotaReport.TabIndex = 3;
            this.btnQuotaReport.Text = "View Quota Report";
            this.btnQuotaReport.UseVisualStyleBackColor = false;
            this.btnQuotaReport.Click += new System.EventHandler(this.btnQuotaReport_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Blue;
            this.lblUserName.Location = new System.Drawing.Point(129, 27);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(61, 20);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User: ";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Location = new System.Drawing.Point(477, 35);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(74, 32);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(415, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fishing Fleet Management System";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAdmin);
            this.panel3.Controls.Add(this.btnCatches);
            this.panel3.Controls.Add(this.btnQuota);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Controls.Add(this.lblUsr);
            this.panel3.Controls.Add(this.btnQuotaReport);
            this.panel3.Controls.Add(this.lblUserName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 340);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Blue;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(34, 280);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(159, 39);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnCatches
            // 
            this.btnCatches.BackColor = System.Drawing.Color.Blue;
            this.btnCatches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatches.ForeColor = System.Drawing.Color.White;
            this.btnCatches.Location = new System.Drawing.Point(206, 84);
            this.btnCatches.Name = "btnCatches";
            this.btnCatches.Size = new System.Drawing.Size(159, 39);
            this.btnCatches.TabIndex = 1;
            this.btnCatches.Text = "Catches";
            this.btnCatches.UseVisualStyleBackColor = false;
            this.btnCatches.Click += new System.EventHandler(this.btnCatches_Click);
            // 
            // btnQuota
            // 
            this.btnQuota.BackColor = System.Drawing.Color.Blue;
            this.btnQuota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuota.ForeColor = System.Drawing.Color.White;
            this.btnQuota.Location = new System.Drawing.Point(377, 84);
            this.btnQuota.Name = "btnQuota";
            this.btnQuota.Size = new System.Drawing.Size(159, 39);
            this.btnQuota.TabIndex = 2;
            this.btnQuota.Text = "Quota";
            this.btnQuota.UseVisualStyleBackColor = false;
            this.btnQuota.Click += new System.EventHandler(this.btnQuota_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(34, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 39);
            this.button2.TabIndex = 0;
            this.button2.Text = "Boats";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 37);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 100);
            this.panel1.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 477);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblUsr;
        private System.Windows.Forms.Button btnQuotaReport;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnQuota;
        private System.Windows.Forms.Button btnCatches;
        private System.Windows.Forms.Button btnAdmin;
    }
}