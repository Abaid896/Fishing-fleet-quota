namespace FishingFleet
{
    partial class BoatDetails
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
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewAllBoats = new System.Windows.Forms.Button();
            this.txtSearchBoat = new System.Windows.Forms.TextBox();
            this.btnSearchBoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBoatDetails = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnManageBoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.Blue;
            this.lblEmployeeID.Location = new System.Drawing.Point(402, 105);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(74, 22);
            this.lblEmployeeID.TabIndex = 55;
            this.lblEmployeeID.Text = "Boat ID:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Blue;
            this.btnBack.Location = new System.Drawing.Point(834, 478);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewAllBoats
            // 
            this.btnViewAllBoats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAllBoats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllBoats.ForeColor = System.Drawing.Color.Blue;
            this.btnViewAllBoats.Location = new System.Drawing.Point(12, 100);
            this.btnViewAllBoats.Name = "btnViewAllBoats";
            this.btnViewAllBoats.Size = new System.Drawing.Size(95, 31);
            this.btnViewAllBoats.TabIndex = 5;
            this.btnViewAllBoats.Text = "View All";
            this.btnViewAllBoats.UseVisualStyleBackColor = true;
            this.btnViewAllBoats.Click += new System.EventHandler(this.btnViewAllBoats_Click);
            // 
            // txtSearchBoat
            // 
            this.txtSearchBoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBoat.Location = new System.Drawing.Point(482, 104);
            this.txtSearchBoat.Name = "txtSearchBoat";
            this.txtSearchBoat.Size = new System.Drawing.Size(240, 27);
            this.txtSearchBoat.TabIndex = 2;
            // 
            // btnSearchBoat
            // 
            this.btnSearchBoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBoat.ForeColor = System.Drawing.Color.Blue;
            this.btnSearchBoat.Location = new System.Drawing.Point(745, 100);
            this.btnSearchBoat.Name = "btnSearchBoat";
            this.btnSearchBoat.Size = new System.Drawing.Size(181, 34);
            this.btnSearchBoat.TabIndex = 3;
            this.btnSearchBoat.Text = "Search Boat";
            this.btnSearchBoat.UseVisualStyleBackColor = true;
            this.btnSearchBoat.Click += new System.EventHandler(this.btnSearchBoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lblBoatDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 68);
            this.panel1.TabIndex = 54;
            // 
            // lblBoatDetails
            // 
            this.lblBoatDetails.AutoSize = true;
            this.lblBoatDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoatDetails.ForeColor = System.Drawing.Color.White;
            this.lblBoatDetails.Location = new System.Drawing.Point(12, 19);
            this.lblBoatDetails.Name = "lblBoatDetails";
            this.lblBoatDetails.Size = new System.Drawing.Size(142, 26);
            this.lblBoatDetails.TabIndex = 9;
            this.lblBoatDetails.Text = "Boat Details";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.GridColor = System.Drawing.Color.Blue;
            this.dgvEmployee.Location = new System.Drawing.Point(12, 157);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(914, 300);
            this.dgvEmployee.TabIndex = 4;
            // 
            // btnManageBoat
            // 
            this.btnManageBoat.BackColor = System.Drawing.Color.Blue;
            this.btnManageBoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageBoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBoat.ForeColor = System.Drawing.Color.White;
            this.btnManageBoat.Location = new System.Drawing.Point(644, 476);
            this.btnManageBoat.Name = "btnManageBoat";
            this.btnManageBoat.Size = new System.Drawing.Size(184, 39);
            this.btnManageBoat.TabIndex = 0;
            this.btnManageBoat.Text = "Manage Boat";
            this.btnManageBoat.UseVisualStyleBackColor = false;
            this.btnManageBoat.Click += new System.EventHandler(this.btnAddBoat_Click);
            // 
            // BoatDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 528);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewAllBoats);
            this.Controls.Add(this.txtSearchBoat);
            this.Controls.Add(this.btnSearchBoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnManageBoat);
            this.Name = "BoatDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoatDetails";
            this.Load += new System.EventHandler(this.BoatDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewAllBoats;
        private System.Windows.Forms.TextBox txtSearchBoat;
        private System.Windows.Forms.Button btnSearchBoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBoatDetails;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnManageBoat;
    }
}