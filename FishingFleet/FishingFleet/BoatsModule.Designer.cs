namespace FishingFleet
{
    partial class BoatsModule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBoatID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSearchBoats = new System.Windows.Forms.TextBox();
            this.btnSearchBoats = new System.Windows.Forms.Button();
            this.dgvSearchEmployee = new System.Windows.Forms.DataGridView();
            this.lblSpecies2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtLicenseNo = new System.Windows.Forms.TextBox();
            this.lblLicenceNo = new System.Windows.Forms.Label();
            this.lblSpecies1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoatId = new System.Windows.Forms.TextBox();
            this.lblBoatID1 = new System.Windows.Forms.Label();
            this.lblSpecies4 = new System.Windows.Forms.Label();
            this.lblSpecies3 = new System.Windows.Forms.Label();
            this.txtMaxLoadSize = new System.Windows.Forms.TextBox();
            this.lblMaxLoadSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSpecies4 = new System.Windows.Forms.ComboBox();
            this.cmbSpecies3 = new System.Windows.Forms.ComboBox();
            this.cmbSpecies2 = new System.Windows.Forms.ComboBox();
            this.cmbSpecies1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 68);
            this.panel1.TabIndex = 130;
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
            this.lblBoatID.Location = new System.Drawing.Point(451, 95);
            this.lblBoatID.Name = "lblBoatID";
            this.lblBoatID.Size = new System.Drawing.Size(74, 22);
            this.lblBoatID.TabIndex = 125;
            this.lblBoatID.Text = "Boat ID:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Blue;
            this.btnBack.Location = new System.Drawing.Point(796, 630);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 39);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSearchBoats
            // 
            this.txtSearchBoats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBoats.Location = new System.Drawing.Point(531, 95);
            this.txtSearchBoats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchBoats.Name = "txtSearchBoats";
            this.txtSearchBoats.Size = new System.Drawing.Size(240, 24);
            this.txtSearchBoats.TabIndex = 12;
            // 
            // btnSearchBoats
            // 
            this.btnSearchBoats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBoats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBoats.ForeColor = System.Drawing.Color.Blue;
            this.btnSearchBoats.Location = new System.Drawing.Point(783, 92);
            this.btnSearchBoats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBoats.Name = "btnSearchBoats";
            this.btnSearchBoats.Size = new System.Drawing.Size(149, 31);
            this.btnSearchBoats.TabIndex = 13;
            this.btnSearchBoats.Text = "Search Boats";
            this.btnSearchBoats.UseVisualStyleBackColor = true;
            this.btnSearchBoats.Click += new System.EventHandler(this.btnSearchBoats_Click);
            // 
            // dgvSearchEmployee
            // 
            this.dgvSearchEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchEmployee.Location = new System.Drawing.Point(29, 135);
            this.dgvSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSearchEmployee.Name = "dgvSearchEmployee";
            this.dgvSearchEmployee.RowHeadersWidth = 51;
            this.dgvSearchEmployee.RowTemplate.Height = 24;
            this.dgvSearchEmployee.Size = new System.Drawing.Size(903, 81);
            this.dgvSearchEmployee.TabIndex = 14;
            // 
            // lblSpecies2
            // 
            this.lblSpecies2.AutoSize = true;
            this.lblSpecies2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblSpecies2.ForeColor = System.Drawing.Color.Blue;
            this.lblSpecies2.Location = new System.Drawing.Point(71, 472);
            this.lblSpecies2.Name = "lblSpecies2";
            this.lblSpecies2.Size = new System.Drawing.Size(94, 22);
            this.lblSpecies2.TabIndex = 124;
            this.lblSpecies2.Text = "Species 2:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(659, 630);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 39);
            this.btnDelete.TabIndex = 10;
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
            this.btnUpdate.Location = new System.Drawing.Point(519, 630);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 39);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Blue;
            this.txtName.Location = new System.Drawing.Point(200, 286);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(697, 27);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(103, 289);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 22);
            this.lblName.TabIndex = 123;
            this.lblName.Text = "Name:";
            // 
            // txtLicenseNo
            // 
            this.txtLicenseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenseNo.ForeColor = System.Drawing.Color.Blue;
            this.txtLicenseNo.Location = new System.Drawing.Point(200, 332);
            this.txtLicenseNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLicenseNo.Name = "txtLicenseNo";
            this.txtLicenseNo.Size = new System.Drawing.Size(697, 27);
            this.txtLicenseNo.TabIndex = 2;
            // 
            // lblLicenceNo
            // 
            this.lblLicenceNo.AutoSize = true;
            this.lblLicenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblLicenceNo.ForeColor = System.Drawing.Color.Blue;
            this.lblLicenceNo.Location = new System.Drawing.Point(25, 334);
            this.lblLicenceNo.Name = "lblLicenceNo";
            this.lblLicenceNo.Size = new System.Drawing.Size(145, 22);
            this.lblLicenceNo.TabIndex = 122;
            this.lblLicenceNo.Text = "Licence Number:";
            // 
            // lblSpecies1
            // 
            this.lblSpecies1.AutoSize = true;
            this.lblSpecies1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblSpecies1.ForeColor = System.Drawing.Color.Blue;
            this.lblSpecies1.Location = new System.Drawing.Point(71, 423);
            this.lblSpecies1.Name = "lblSpecies1";
            this.lblSpecies1.Size = new System.Drawing.Size(94, 22);
            this.lblSpecies1.TabIndex = 121;
            this.lblSpecies1.Text = "Species 1:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(380, 630);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 39);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoatId
            // 
            this.txtBoatId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoatId.ForeColor = System.Drawing.Color.Blue;
            this.txtBoatId.Location = new System.Drawing.Point(200, 238);
            this.txtBoatId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoatId.Name = "txtBoatId";
            this.txtBoatId.Size = new System.Drawing.Size(697, 27);
            this.txtBoatId.TabIndex = 0;
            // 
            // lblBoatID1
            // 
            this.lblBoatID1.AutoSize = true;
            this.lblBoatID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblBoatID1.ForeColor = System.Drawing.Color.Blue;
            this.lblBoatID1.Location = new System.Drawing.Point(91, 239);
            this.lblBoatID1.Name = "lblBoatID1";
            this.lblBoatID1.Size = new System.Drawing.Size(74, 22);
            this.lblBoatID1.TabIndex = 120;
            this.lblBoatID1.Text = "Boat ID:";
            // 
            // lblSpecies4
            // 
            this.lblSpecies4.AutoSize = true;
            this.lblSpecies4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblSpecies4.ForeColor = System.Drawing.Color.Blue;
            this.lblSpecies4.Location = new System.Drawing.Point(71, 562);
            this.lblSpecies4.Name = "lblSpecies4";
            this.lblSpecies4.Size = new System.Drawing.Size(94, 22);
            this.lblSpecies4.TabIndex = 135;
            this.lblSpecies4.Text = "Species 4:";
            // 
            // lblSpecies3
            // 
            this.lblSpecies3.AutoSize = true;
            this.lblSpecies3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblSpecies3.ForeColor = System.Drawing.Color.Blue;
            this.lblSpecies3.Location = new System.Drawing.Point(71, 517);
            this.lblSpecies3.Name = "lblSpecies3";
            this.lblSpecies3.Size = new System.Drawing.Size(94, 22);
            this.lblSpecies3.TabIndex = 134;
            this.lblSpecies3.Text = "Species 3:";
            // 
            // txtMaxLoadSize
            // 
            this.txtMaxLoadSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxLoadSize.ForeColor = System.Drawing.Color.Blue;
            this.txtMaxLoadSize.Location = new System.Drawing.Point(218, 379);
            this.txtMaxLoadSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaxLoadSize.Name = "txtMaxLoadSize";
            this.txtMaxLoadSize.Size = new System.Drawing.Size(679, 27);
            this.txtMaxLoadSize.TabIndex = 3;
            // 
            // lblMaxLoadSize
            // 
            this.lblMaxLoadSize.AutoSize = true;
            this.lblMaxLoadSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblMaxLoadSize.ForeColor = System.Drawing.Color.Blue;
            this.lblMaxLoadSize.Location = new System.Drawing.Point(25, 380);
            this.lblMaxLoadSize.Name = "lblMaxLoadSize";
            this.lblMaxLoadSize.Size = new System.Drawing.Size(168, 22);
            this.lblMaxLoadSize.TabIndex = 137;
            this.lblMaxLoadSize.Text = "Max Load Size (kg):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(691, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 29);
            this.label3.TabIndex = 142;
            this.label3.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(897, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 29);
            this.label5.TabIndex = 141;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(896, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 29);
            this.label6.TabIndex = 140;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(896, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 29);
            this.label7.TabIndex = 139;
            this.label7.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(897, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 29);
            this.label4.TabIndex = 138;
            this.label4.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(691, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 29);
            this.label2.TabIndex = 143;
            this.label2.Text = "*";
            // 
            // cmbSpecies4
            // 
            this.cmbSpecies4.FormattingEnabled = true;
            this.cmbSpecies4.Location = new System.Drawing.Point(200, 564);
            this.cmbSpecies4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSpecies4.Name = "cmbSpecies4";
            this.cmbSpecies4.Size = new System.Drawing.Size(491, 24);
            this.cmbSpecies4.TabIndex = 7;
            this.cmbSpecies4.Text = "   select species";
            this.cmbSpecies4.SelectedIndexChanged += new System.EventHandler(this.cmbSpecies4_SelectedIndexChanged);
            // 
            // cmbSpecies3
            // 
            this.cmbSpecies3.FormattingEnabled = true;
            this.cmbSpecies3.Location = new System.Drawing.Point(200, 519);
            this.cmbSpecies3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSpecies3.Name = "cmbSpecies3";
            this.cmbSpecies3.Size = new System.Drawing.Size(491, 24);
            this.cmbSpecies3.TabIndex = 6;
            this.cmbSpecies3.Text = "   select species";
            this.cmbSpecies3.SelectedIndexChanged += new System.EventHandler(this.cmbSpecies3_SelectedIndexChanged);
            // 
            // cmbSpecies2
            // 
            this.cmbSpecies2.FormattingEnabled = true;
            this.cmbSpecies2.Location = new System.Drawing.Point(200, 475);
            this.cmbSpecies2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSpecies2.Name = "cmbSpecies2";
            this.cmbSpecies2.Size = new System.Drawing.Size(491, 24);
            this.cmbSpecies2.TabIndex = 5;
            this.cmbSpecies2.Text = "   select species";
            this.cmbSpecies2.SelectedIndexChanged += new System.EventHandler(this.cmbSpecies2_SelectedIndexChanged);
            // 
            // cmbSpecies1
            // 
            this.cmbSpecies1.FormattingEnabled = true;
            this.cmbSpecies1.Location = new System.Drawing.Point(200, 426);
            this.cmbSpecies1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSpecies1.Name = "cmbSpecies1";
            this.cmbSpecies1.Size = new System.Drawing.Size(491, 24);
            this.cmbSpecies1.TabIndex = 4;
            this.cmbSpecies1.Text = "   select species";
            this.cmbSpecies1.SelectedIndexChanged += new System.EventHandler(this.cmbSpecies1_SelectedIndexChanged);
            // 
            // BoatsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 690);
            this.Controls.Add(this.cmbSpecies1);
            this.Controls.Add(this.cmbSpecies2);
            this.Controls.Add(this.cmbSpecies3);
            this.Controls.Add(this.cmbSpecies4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaxLoadSize);
            this.Controls.Add(this.lblMaxLoadSize);
            this.Controls.Add(this.lblSpecies4);
            this.Controls.Add(this.lblSpecies3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBoatID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSearchBoats);
            this.Controls.Add(this.btnSearchBoats);
            this.Controls.Add(this.dgvSearchEmployee);
            this.Controls.Add(this.lblSpecies2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtLicenseNo);
            this.Controls.Add(this.lblLicenceNo);
            this.Controls.Add(this.lblSpecies1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoatId);
            this.Controls.Add(this.lblBoatID1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BoatsModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoatsModule";
            this.Load += new System.EventHandler(this.BoatsModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBoatID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSearchBoats;
        private System.Windows.Forms.Button btnSearchBoats;
        private System.Windows.Forms.DataGridView dgvSearchEmployee;
        private System.Windows.Forms.Label lblSpecies2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtLicenseNo;
        private System.Windows.Forms.Label lblLicenceNo;
        private System.Windows.Forms.Label lblSpecies1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoatId;
        private System.Windows.Forms.Label lblBoatID1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSpecies4;
        private System.Windows.Forms.Label lblSpecies3;
        private System.Windows.Forms.TextBox txtMaxLoadSize;
        private System.Windows.Forms.Label lblMaxLoadSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSpecies4;
        private System.Windows.Forms.ComboBox cmbSpecies3;
        private System.Windows.Forms.ComboBox cmbSpecies2;
        private System.Windows.Forms.ComboBox cmbSpecies1;
    }
}