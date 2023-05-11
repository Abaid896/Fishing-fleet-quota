namespace FishingFleet
{
    partial class Quota
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
            this.lblFishDetails = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.txtSearchSpecies = new System.Windows.Forms.TextBox();
            this.btnSearchFish = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lblFishDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 68);
            this.panel1.TabIndex = 56;
            // 
            // lblFishDetails
            // 
            this.lblFishDetails.AutoSize = true;
            this.lblFishDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFishDetails.ForeColor = System.Drawing.Color.White;
            this.lblFishDetails.Location = new System.Drawing.Point(12, 19);
            this.lblFishDetails.Name = "lblFishDetails";
            this.lblFishDetails.Size = new System.Drawing.Size(76, 26);
            this.lblFishDetails.TabIndex = 9;
            this.lblFishDetails.Text = "Quota";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Blue;
            this.btnBack.Location = new System.Drawing.Point(628, 449);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 35);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.GridColor = System.Drawing.Color.Blue;
            this.dgvProduct.Location = new System.Drawing.Point(12, 158);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(708, 279);
            this.dgvProduct.TabIndex = 55;
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.ForeColor = System.Drawing.Color.Blue;
            this.lblSpecies.Location = new System.Drawing.Point(242, 102);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(79, 22);
            this.lblSpecies.TabIndex = 57;
            this.lblSpecies.Text = "Species:";
            // 
            // btnViewAll
            // 
            this.btnViewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.Blue;
            this.btnViewAll.Location = new System.Drawing.Point(12, 99);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(95, 31);
            this.btnViewAll.TabIndex = 54;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // txtSearchSpecies
            // 
            this.txtSearchSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSpecies.Location = new System.Drawing.Point(327, 102);
            this.txtSearchSpecies.Name = "txtSearchSpecies";
            this.txtSearchSpecies.Size = new System.Drawing.Size(240, 24);
            this.txtSearchSpecies.TabIndex = 52;
            // 
            // btnSearchFish
            // 
            this.btnSearchFish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFish.ForeColor = System.Drawing.Color.Blue;
            this.btnSearchFish.Location = new System.Drawing.Point(581, 99);
            this.btnSearchFish.Name = "btnSearchFish";
            this.btnSearchFish.Size = new System.Drawing.Size(139, 31);
            this.btnSearchFish.TabIndex = 53;
            this.btnSearchFish.Text = "Search Species";
            this.btnSearchFish.UseVisualStyleBackColor = true;
            this.btnSearchFish.Click += new System.EventHandler(this.btnSearchFish_Click);
            // 
            // Quota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.txtSearchSpecies);
            this.Controls.Add(this.btnSearchFish);
            this.Name = "Quota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quota";
            this.Load += new System.EventHandler(this.Quota_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFishDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.TextBox txtSearchSpecies;
        private System.Windows.Forms.Button btnSearchFish;
    }
}