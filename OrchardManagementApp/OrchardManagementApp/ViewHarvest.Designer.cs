namespace OrchardManagementApp
{
    partial class ViewHarvest
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblHoursInvested = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.txtTotalIncome = new System.Windows.Forms.TextBox();
            this.dtpHarvest = new System.Windows.Forms.DateTimePicker();
            this.txtPricePerKg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKgHarvested = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(61, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 25);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblHoursInvested
            // 
            this.lblHoursInvested.AutoSize = true;
            this.lblHoursInvested.Location = new System.Drawing.Point(24, 201);
            this.lblHoursInvested.Name = "lblHoursInvested";
            this.lblHoursInvested.Size = new System.Drawing.Size(54, 13);
            this.lblHoursInvested.TabIndex = 14;
            this.lblHoursInvested.Text = "Comment:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Harvest";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(149, 360);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 25);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtComment
            // 
            this.txtComment.Enabled = false;
            this.txtComment.Location = new System.Drawing.Point(12, 217);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(238, 139);
            this.txtComment.TabIndex = 11;
            this.txtComment.Text = "";
            // 
            // txtTotalIncome
            // 
            this.txtTotalIncome.Enabled = false;
            this.txtTotalIncome.Location = new System.Drawing.Point(12, 178);
            this.txtTotalIncome.Name = "txtTotalIncome";
            this.txtTotalIncome.Size = new System.Drawing.Size(238, 20);
            this.txtTotalIncome.TabIndex = 10;
            // 
            // dtpHarvest
            // 
            this.dtpHarvest.Enabled = false;
            this.dtpHarvest.Location = new System.Drawing.Point(12, 100);
            this.dtpHarvest.Name = "dtpHarvest";
            this.dtpHarvest.Size = new System.Drawing.Size(238, 20);
            this.dtpHarvest.TabIndex = 9;
            // 
            // txtPricePerKg
            // 
            this.txtPricePerKg.Enabled = false;
            this.txtPricePerKg.Location = new System.Drawing.Point(12, 139);
            this.txtPricePerKg.Name = "txtPricePerKg";
            this.txtPricePerKg.Size = new System.Drawing.Size(238, 20);
            this.txtPricePerKg.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total Income ($):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Price per Kg ($):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date Harvested:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kg Harvested (Kg):";
            // 
            // txtKgHarvested
            // 
            this.txtKgHarvested.Enabled = false;
            this.txtKgHarvested.Location = new System.Drawing.Point(12, 61);
            this.txtKgHarvested.Name = "txtKgHarvested";
            this.txtKgHarvested.Size = new System.Drawing.Size(238, 20);
            this.txtKgHarvested.TabIndex = 19;
            // 
            // ViewHarvest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 393);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKgHarvested);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblHoursInvested);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtTotalIncome);
            this.Controls.Add(this.dtpHarvest);
            this.Controls.Add(this.txtPricePerKg);
            this.Name = "ViewHarvest";
            this.Text = "ViewHarvest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHoursInvested;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.TextBox txtTotalIncome;
        private System.Windows.Forms.DateTimePicker dtpHarvest;
        private System.Windows.Forms.TextBox txtPricePerKg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKgHarvested;
    }
}