namespace FishingFleet
{
    partial class QuotaReport
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
            this.lblSearchSpecies = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewAllBoats = new System.Windows.Forms.Button();
            this.txtSearchSpecies = new System.Windows.Forms.TextBox();
            this.btnSearchSpecies = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuatoDetails = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.rbtnkg = new System.Windows.Forms.RadioButton();
            this.rbtnTones = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchSpecies
            // 
            this.lblSearchSpecies.AutoSize = true;
            this.lblSearchSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchSpecies.ForeColor = System.Drawing.Color.Blue;
            this.lblSearchSpecies.Location = new System.Drawing.Point(341, 97);
            this.lblSearchSpecies.Name = "lblSearchSpecies";
            this.lblSearchSpecies.Size = new System.Drawing.Size(79, 22);
            this.lblSearchSpecies.TabIndex = 63;
            this.lblSearchSpecies.Text = "Species:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Blue;
            this.btnBack.Location = new System.Drawing.Point(732, 479);
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
            this.btnViewAllBoats.Location = new System.Drawing.Point(729, 132);
            this.btnViewAllBoats.Name = "btnViewAllBoats";
            this.btnViewAllBoats.Size = new System.Drawing.Size(95, 31);
            this.btnViewAllBoats.TabIndex = 61;
            this.btnViewAllBoats.Text = "View All";
            this.btnViewAllBoats.UseVisualStyleBackColor = true;
            this.btnViewAllBoats.Click += new System.EventHandler(this.btnViewAllBoats_Click);
            // 
            // txtSearchSpecies
            // 
            this.txtSearchSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSpecies.Location = new System.Drawing.Point(426, 96);
            this.txtSearchSpecies.Name = "txtSearchSpecies";
            this.txtSearchSpecies.Size = new System.Drawing.Size(240, 27);
            this.txtSearchSpecies.TabIndex = 58;
            // 
            // btnSearchSpecies
            // 
            this.btnSearchSpecies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSpecies.ForeColor = System.Drawing.Color.Blue;
            this.btnSearchSpecies.Location = new System.Drawing.Point(672, 92);
            this.btnSearchSpecies.Name = "btnSearchSpecies";
            this.btnSearchSpecies.Size = new System.Drawing.Size(152, 34);
            this.btnSearchSpecies.TabIndex = 59;
            this.btnSearchSpecies.Text = "Search Species";
            this.btnSearchSpecies.UseVisualStyleBackColor = true;
            this.btnSearchSpecies.Click += new System.EventHandler(this.btnSearchSpecies_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lblQuatoDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 68);
            this.panel1.TabIndex = 62;
            // 
            // lblQuatoDetails
            // 
            this.lblQuatoDetails.AutoSize = true;
            this.lblQuatoDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuatoDetails.ForeColor = System.Drawing.Color.White;
            this.lblQuatoDetails.Location = new System.Drawing.Point(12, 19);
            this.lblQuatoDetails.Name = "lblQuatoDetails";
            this.lblQuatoDetails.Size = new System.Drawing.Size(154, 26);
            this.lblQuatoDetails.TabIndex = 9;
            this.lblQuatoDetails.Text = "Quota Report";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.GridColor = System.Drawing.Color.Blue;
            this.dgvEmployee.Location = new System.Drawing.Point(17, 175);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(807, 274);
            this.dgvEmployee.TabIndex = 60;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // rbtnkg
            // 
            this.rbtnkg.AutoSize = true;
            this.rbtnkg.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnkg.ForeColor = System.Drawing.Color.Blue;
            this.rbtnkg.Location = new System.Drawing.Point(17, 84);
            this.rbtnkg.Name = "rbtnkg";
            this.rbtnkg.Size = new System.Drawing.Size(140, 27);
            this.rbtnkg.TabIndex = 65;
            this.rbtnkg.TabStop = true;
            this.rbtnkg.Text = "Weight in kg";
            this.rbtnkg.UseVisualStyleBackColor = true;
            this.rbtnkg.CheckedChanged += new System.EventHandler(this.rbtnkg_CheckedChanged);
            // 
            // rbtnTones
            // 
            this.rbtnTones.AutoSize = true;
            this.rbtnTones.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTones.ForeColor = System.Drawing.Color.Blue;
            this.rbtnTones.Location = new System.Drawing.Point(17, 121);
            this.rbtnTones.Name = "rbtnTones";
            this.rbtnTones.Size = new System.Drawing.Size(160, 27);
            this.rbtnTones.TabIndex = 66;
            this.rbtnTones.TabStop = true;
            this.rbtnTones.Text = "Weight in Tons";
            this.rbtnTones.UseVisualStyleBackColor = true;
            this.rbtnTones.CheckedChanged += new System.EventHandler(this.rbtnTones_CheckedChanged);
            // 
            // QuotaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 526);
            this.Controls.Add(this.rbtnTones);
            this.Controls.Add(this.rbtnkg);
            this.Controls.Add(this.lblSearchSpecies);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewAllBoats);
            this.Controls.Add(this.txtSearchSpecies);
            this.Controls.Add(this.btnSearchSpecies);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "QuotaReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuotaReport";
            this.Load += new System.EventHandler(this.QuotaReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchSpecies;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewAllBoats;
        private System.Windows.Forms.TextBox txtSearchSpecies;
        private System.Windows.Forms.Button btnSearchSpecies;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuatoDetails;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.RadioButton rbtnkg;
        private System.Windows.Forms.RadioButton rbtnTones;
    }
}