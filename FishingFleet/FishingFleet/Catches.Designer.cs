namespace FishingFleet
{
    partial class Catches
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
            this.cmbSpecies = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblMaxLoadSize = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBoatID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSearchBoats = new System.Windows.Forms.TextBox();
            this.btnSearchBoats = new System.Windows.Forms.Button();
            this.dgvSearchEmployee = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblSpecies1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBoatID1 = new System.Windows.Forms.Label();
            this.lblLicenceNo = new System.Windows.Forms.Label();
            this.cmbBoatId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpeciesS = new System.Windows.Forms.TextBox();
            this.btnSearchSpecies = new System.Windows.Forms.Button();
            this.dateCatch = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Location = new System.Drawing.Point(202, 315);
            this.cmbSpecies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(491, 24);
            this.cmbSpecies.TabIndex = 1;
            this.cmbSpecies.Text = "   select species";
            this.cmbSpecies.SelectedIndexChanged += new System.EventHandler(this.cmbSpecies_SelectedIndexChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.ForeColor = System.Drawing.Color.Blue;
            this.txtWeight.Location = new System.Drawing.Point(200, 362);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(493, 27);
            this.txtWeight.TabIndex = 2;
            // 
            // lblMaxLoadSize
            // 
            this.lblMaxLoadSize.AutoSize = true;
            this.lblMaxLoadSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblMaxLoadSize.ForeColor = System.Drawing.Color.Blue;
            this.lblMaxLoadSize.Location = new System.Drawing.Point(87, 363);
            this.lblMaxLoadSize.Name = "lblMaxLoadSize";
            this.lblMaxLoadSize.Size = new System.Drawing.Size(107, 22);
            this.lblMaxLoadSize.TabIndex = 168;
            this.lblMaxLoadSize.Text = "Weight (kg):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 68);
            this.panel1.TabIndex = 165;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Boat Module";
            // 
            // lblBoatID
            // 
            this.lblBoatID.AutoSize = true;
            this.lblBoatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblBoatID.ForeColor = System.Drawing.Color.Blue;
            this.lblBoatID.Location = new System.Drawing.Point(211, 87);
            this.lblBoatID.Name = "lblBoatID";
            this.lblBoatID.Size = new System.Drawing.Size(74, 22);
            this.lblBoatID.TabIndex = 164;
            this.lblBoatID.Text = "Boat ID:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Blue;
            this.btnBack.Location = new System.Drawing.Point(590, 465);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 39);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSearchBoats
            // 
            this.txtSearchBoats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBoats.Location = new System.Drawing.Point(291, 87);
            this.txtSearchBoats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchBoats.Name = "txtSearchBoats";
            this.txtSearchBoats.Size = new System.Drawing.Size(240, 24);
            this.txtSearchBoats.TabIndex = 7;
            // 
            // btnSearchBoats
            // 
            this.btnSearchBoats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBoats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBoats.ForeColor = System.Drawing.Color.Blue;
            this.btnSearchBoats.Location = new System.Drawing.Point(543, 84);
            this.btnSearchBoats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBoats.Name = "btnSearchBoats";
            this.btnSearchBoats.Size = new System.Drawing.Size(149, 31);
            this.btnSearchBoats.TabIndex = 8;
            this.btnSearchBoats.Text = "Search Boats";
            this.btnSearchBoats.UseVisualStyleBackColor = true;
            this.btnSearchBoats.Click += new System.EventHandler(this.btnSearchBoats_Click);
            // 
            // dgvSearchEmployee
            // 
            this.dgvSearchEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchEmployee.Location = new System.Drawing.Point(29, 173);
            this.dgvSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSearchEmployee.Name = "dgvSearchEmployee";
            this.dgvSearchEmployee.RowHeadersWidth = 51;
            this.dgvSearchEmployee.RowTemplate.Height = 24;
            this.dgvSearchEmployee.Size = new System.Drawing.Size(664, 81);
            this.dgvSearchEmployee.TabIndex = 158;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(29, 465);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 39);
            this.btnDelete.TabIndex = 154;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(475, 465);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 39);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblSpecies1
            // 
            this.lblSpecies1.AutoSize = true;
            this.lblSpecies1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblSpecies1.ForeColor = System.Drawing.Color.Blue;
            this.lblSpecies1.Location = new System.Drawing.Point(115, 313);
            this.lblSpecies1.Name = "lblSpecies1";
            this.lblSpecies1.Size = new System.Drawing.Size(79, 22);
            this.lblSpecies1.TabIndex = 160;
            this.lblSpecies1.Text = "Species:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(360, 465);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBoatID1
            // 
            this.lblBoatID1.AutoSize = true;
            this.lblBoatID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblBoatID1.ForeColor = System.Drawing.Color.Blue;
            this.lblBoatID1.Location = new System.Drawing.Point(120, 267);
            this.lblBoatID1.Name = "lblBoatID1";
            this.lblBoatID1.Size = new System.Drawing.Size(74, 22);
            this.lblBoatID1.TabIndex = 159;
            this.lblBoatID1.Text = "Boat ID:";
            // 
            // lblLicenceNo
            // 
            this.lblLicenceNo.AutoSize = true;
            this.lblLicenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblLicenceNo.ForeColor = System.Drawing.Color.Blue;
            this.lblLicenceNo.Location = new System.Drawing.Point(89, 408);
            this.lblLicenceNo.Name = "lblLicenceNo";
            this.lblLicenceNo.Size = new System.Drawing.Size(105, 22);
            this.lblLicenceNo.TabIndex = 176;
            this.lblLicenceNo.Text = "Catch Date:";
            // 
            // cmbBoatId
            // 
            this.cmbBoatId.FormattingEnabled = true;
            this.cmbBoatId.Location = new System.Drawing.Point(202, 269);
            this.cmbBoatId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoatId.Name = "cmbBoatId";
            this.cmbBoatId.Size = new System.Drawing.Size(491, 24);
            this.cmbBoatId.TabIndex = 0;
            this.cmbBoatId.Text = "   select boat";
            this.cmbBoatId.SelectedIndexChanged += new System.EventHandler(this.cmbBoatId_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(206, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 180;
            this.label2.Text = "Species:";
            // 
            // txtSpeciesS
            // 
            this.txtSpeciesS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpeciesS.Location = new System.Drawing.Point(291, 130);
            this.txtSpeciesS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpeciesS.Name = "txtSpeciesS";
            this.txtSpeciesS.Size = new System.Drawing.Size(240, 24);
            this.txtSpeciesS.TabIndex = 9;
            // 
            // btnSearchSpecies
            // 
            this.btnSearchSpecies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSpecies.ForeColor = System.Drawing.Color.Blue;
            this.btnSearchSpecies.Location = new System.Drawing.Point(543, 127);
            this.btnSearchSpecies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchSpecies.Name = "btnSearchSpecies";
            this.btnSearchSpecies.Size = new System.Drawing.Size(149, 31);
            this.btnSearchSpecies.TabIndex = 10;
            this.btnSearchSpecies.Text = "Search Species";
            this.btnSearchSpecies.UseVisualStyleBackColor = true;
            this.btnSearchSpecies.Click += new System.EventHandler(this.btnSearchSpecies_Click);
            // 
            // dateCatch
            // 
            this.dateCatch.Location = new System.Drawing.Point(200, 407);
            this.dateCatch.Name = "dateCatch";
            this.dateCatch.Size = new System.Drawing.Size(492, 22);
            this.dateCatch.TabIndex = 3;
            // 
            // Catches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 521);
            this.Controls.Add(this.dateCatch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSpeciesS);
            this.Controls.Add(this.btnSearchSpecies);
            this.Controls.Add(this.cmbBoatId);
            this.Controls.Add(this.lblLicenceNo);
            this.Controls.Add(this.cmbSpecies);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblMaxLoadSize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBoatID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSearchBoats);
            this.Controls.Add(this.btnSearchBoats);
            this.Controls.Add(this.dgvSearchEmployee);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblSpecies1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblBoatID1);
            this.Name = "Catches";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catches";
            this.Load += new System.EventHandler(this.Catches_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblMaxLoadSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBoatID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSearchBoats;
        private System.Windows.Forms.Button btnSearchBoats;
        private System.Windows.Forms.DataGridView dgvSearchEmployee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblSpecies1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBoatID1;
        private System.Windows.Forms.Label lblLicenceNo;
        private System.Windows.Forms.ComboBox cmbBoatId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpeciesS;
        private System.Windows.Forms.Button btnSearchSpecies;
        private System.Windows.Forms.DateTimePicker dateCatch;
    }
}