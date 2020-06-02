namespace OrchardManagementApp
{
    partial class AddHarvest
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtKgHarvested = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblHoursInvested = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.txtTotalIncome = new System.Windows.Forms.TextBox();
            this.dtpHarvest = new System.Windows.Forms.DateTimePicker();
            this.txtPricePerKg = new System.Windows.Forms.TextBox();
            this.btnAddHarvest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Kg Harvested (Kg):";
            // 
            // txtKgHarvested
            // 
            this.txtKgHarvested.Location = new System.Drawing.Point(7, 20);
            this.txtKgHarvested.Name = "txtKgHarvested";
            this.txtKgHarvested.Size = new System.Drawing.Size(207, 20);
            this.txtKgHarvested.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Date Harvested:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Price per Kg ($):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Total Income ($):";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(20, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 25);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblHoursInvested
            // 
            this.lblHoursInvested.AutoSize = true;
            this.lblHoursInvested.Location = new System.Drawing.Point(19, 160);
            this.lblHoursInvested.Name = "lblHoursInvested";
            this.lblHoursInvested.Size = new System.Drawing.Size(54, 13);
            this.lblHoursInvested.TabIndex = 26;
            this.lblHoursInvested.Text = "Comment:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(7, 176);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(207, 139);
            this.txtComment.TabIndex = 24;
            this.txtComment.Text = "";
            // 
            // txtTotalIncome
            // 
            this.txtTotalIncome.Location = new System.Drawing.Point(7, 137);
            this.txtTotalIncome.Name = "txtTotalIncome";
            this.txtTotalIncome.Size = new System.Drawing.Size(207, 20);
            this.txtTotalIncome.TabIndex = 23;
            // 
            // dtpHarvest
            // 
            this.dtpHarvest.Location = new System.Drawing.Point(7, 59);
            this.dtpHarvest.Name = "dtpHarvest";
            this.dtpHarvest.Size = new System.Drawing.Size(207, 20);
            this.dtpHarvest.TabIndex = 22;
            // 
            // txtPricePerKg
            // 
            this.txtPricePerKg.Location = new System.Drawing.Point(7, 98);
            this.txtPricePerKg.Name = "txtPricePerKg";
            this.txtPricePerKg.Size = new System.Drawing.Size(207, 20);
            this.txtPricePerKg.TabIndex = 21;
            // 
            // btnAddHarvest
            // 
            this.btnAddHarvest.Location = new System.Drawing.Point(108, 321);
            this.btnAddHarvest.Name = "btnAddHarvest";
            this.btnAddHarvest.Size = new System.Drawing.Size(110, 25);
            this.btnAddHarvest.TabIndex = 33;
            this.btnAddHarvest.Text = "Add Harvest";
            this.btnAddHarvest.UseVisualStyleBackColor = true;
            this.btnAddHarvest.Click += new System.EventHandler(this.btnAddHarvest_Click);
            // 
            // AddHarvest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 349);
            this.Controls.Add(this.btnAddHarvest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKgHarvested);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblHoursInvested);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtTotalIncome);
            this.Controls.Add(this.dtpHarvest);
            this.Controls.Add(this.txtPricePerKg);
            this.Name = "AddHarvest";
            this.Text = "Add Harvest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKgHarvested;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHoursInvested;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.TextBox txtTotalIncome;
        private System.Windows.Forms.DateTimePicker dtpHarvest;
        private System.Windows.Forms.TextBox txtPricePerKg;
        private System.Windows.Forms.Button btnAddHarvest;
    }
}