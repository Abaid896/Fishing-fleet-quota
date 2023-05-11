namespace FishingFleet
{
    partial class CatchesDetails
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewAllBoats = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBoatDetails = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnManageBoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpeciesS = new System.Windows.Forms.TextBox();
            this.btnSearchSpecies = new System.Windows.Forms.Button();
            this.lblBoatID = new System.Windows.Forms.Label();
            this.txtSearchBoats = new System.Windows.Forms.TextBox();
            this.btnSearchBoats = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Blue;
            this.btnBack.Location = new System.Drawing.Point(741, 492);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 35);
            this.btnBack.TabIndex = 57;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewAllBoats
            // 
            this.btnViewAllBoats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAllBoats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllBoats.ForeColor = System.Drawing.Color.Blue;
            this.btnViewAllBoats.Location = new System.Drawing.Point(26, 111);
            this.btnViewAllBoats.Name = "btnViewAllBoats";
            this.btnViewAllBoats.Size = new System.Drawing.Size(95, 31);
            this.btnViewAllBoats.TabIndex = 61;
            this.btnViewAllBoats.Text = "View All";
            this.btnViewAllBoats.UseVisualStyleBackColor = true;
            this.btnViewAllBoats.Click += new System.EventHandler(this.btnViewAllBoats_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lblBoatDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 68);
            this.panel1.TabIndex = 62;
            // 
            // lblBoatDetails
            // 
            this.lblBoatDetails.AutoSize = true;
            this.lblBoatDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoatDetails.ForeColor = System.Drawing.Color.White;
            this.lblBoatDetails.Location = new System.Drawing.Point(12, 19);
            this.lblBoatDetails.Name = "lblBoatDetails";
            this.lblBoatDetails.Size = new System.Drawing.Size(180, 26);
            this.lblBoatDetails.TabIndex = 9;
            this.lblBoatDetails.Text = "Catches Details";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.GridColor = System.Drawing.Color.Blue;
            this.dgvEmployee.Location = new System.Drawing.Point(17, 181);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(816, 289);
            this.dgvEmployee.TabIndex = 60;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // btnManageBoat
            // 
            this.btnManageBoat.BackColor = System.Drawing.Color.Blue;
            this.btnManageBoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageBoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBoat.ForeColor = System.Drawing.Color.White;
            this.btnManageBoat.Location = new System.Drawing.Point(551, 490);
            this.btnManageBoat.Name = "btnManageBoat";
            this.btnManageBoat.Size = new System.Drawing.Size(184, 39);
            this.btnManageBoat.TabIndex = 56;
            this.btnManageBoat.Text = "Manage Boat";
            this.btnManageBoat.UseVisualStyleBackColor = false;
            this.btnManageBoat.Click += new System.EventHandler(this.btnManageBoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(348, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 186;
            this.label2.Text = "Species:";
            // 
            // txtSpeciesS
            // 
            this.txtSpeciesS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpeciesS.Location = new System.Drawing.Point(433, 133);
            this.txtSpeciesS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpeciesS.Name = "txtSpeciesS";
            this.txtSpeciesS.Size = new System.Drawing.Size(240, 24);
            this.txtSpeciesS.TabIndex = 184;
            // 
            // btnSearchSpecies
            // 
            this.btnSearchSpecies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSpecies.ForeColor = System.Drawing.Color.Blue;
            this.btnSearchSpecies.Location = new System.Drawing.Point(685, 130);
            this.btnSearchSpecies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchSpecies.Name = "btnSearchSpecies";
            this.btnSearchSpecies.Size = new System.Drawing.Size(149, 31);
            this.btnSearchSpecies.TabIndex = 185;
            this.btnSearchSpecies.Text = "Search Species";
            this.btnSearchSpecies.UseVisualStyleBackColor = true;
            this.btnSearchSpecies.Click += new System.EventHandler(this.btnSearchSpecies_Click);
            // 
            // lblBoatID
            // 
            this.lblBoatID.AutoSize = true;
            this.lblBoatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblBoatID.ForeColor = System.Drawing.Color.Blue;
            this.lblBoatID.Location = new System.Drawing.Point(353, 90);
            this.lblBoatID.Name = "lblBoatID";
            this.lblBoatID.Size = new System.Drawing.Size(74, 22);
            this.lblBoatID.TabIndex = 183;
            this.lblBoatID.Text = "Boat ID:";
            // 
            // txtSearchBoats
            // 
            this.txtSearchBoats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBoats.Location = new System.Drawing.Point(433, 90);
            this.txtSearchBoats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchBoats.Name = "txtSearchBoats";
            this.txtSearchBoats.Size = new System.Drawing.Size(240, 24);
            this.txtSearchBoats.TabIndex = 181;
            // 
            // btnSearchBoats
            // 
            this.btnSearchBoats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBoats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBoats.ForeColor = System.Drawing.Color.Blue;
            this.btnSearchBoats.Location = new System.Drawing.Point(685, 87);
            this.btnSearchBoats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBoats.Name = "btnSearchBoats";
            this.btnSearchBoats.Size = new System.Drawing.Size(149, 31);
            this.btnSearchBoats.TabIndex = 182;
            this.btnSearchBoats.Text = "Search Boats";
            this.btnSearchBoats.UseVisualStyleBackColor = true;
            this.btnSearchBoats.Click += new System.EventHandler(this.btnSearchBoats_Click);
            // 
            // CatchesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSpeciesS);
            this.Controls.Add(this.btnSearchSpecies);
            this.Controls.Add(this.lblBoatID);
            this.Controls.Add(this.txtSearchBoats);
            this.Controls.Add(this.btnSearchBoats);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewAllBoats);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnManageBoat);
            this.Name = "CatchesDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatchesDetails";
            this.Load += new System.EventHandler(this.CatchesDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewAllBoats;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBoatDetails;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnManageBoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpeciesS;
        private System.Windows.Forms.Button btnSearchSpecies;
        private System.Windows.Forms.Label lblBoatID;
        private System.Windows.Forms.TextBox txtSearchBoats;
        private System.Windows.Forms.Button btnSearchBoats;
    }
}