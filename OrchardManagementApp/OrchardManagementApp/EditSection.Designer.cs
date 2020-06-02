namespace OrchardManagementApp
{
    partial class EditSection
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHoursInvested = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.txtTreeType = new System.Windows.Forms.TextBox();
            this.dtpDatePlanted = new System.Windows.Forms.DateTimePicker();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 20);
            this.txtName.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tree Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date Planted:";
            // 
            // lblHoursInvested
            // 
            this.lblHoursInvested.AutoSize = true;
            this.lblHoursInvested.Location = new System.Drawing.Point(24, 200);
            this.lblHoursInvested.Name = "lblHoursInvested";
            this.lblHoursInvested.Size = new System.Drawing.Size(54, 13);
            this.lblHoursInvested.TabIndex = 27;
            this.lblHoursInvested.Text = "Comment:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Edit Section";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(149, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 25);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(12, 216);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(238, 139);
            this.txtComment.TabIndex = 24;
            this.txtComment.Text = "";
            // 
            // txtTreeType
            // 
            this.txtTreeType.Location = new System.Drawing.Point(12, 99);
            this.txtTreeType.Name = "txtTreeType";
            this.txtTreeType.Size = new System.Drawing.Size(238, 20);
            this.txtTreeType.TabIndex = 23;
            // 
            // dtpDatePlanted
            // 
            this.dtpDatePlanted.Location = new System.Drawing.Point(12, 177);
            this.dtpDatePlanted.Name = "dtpDatePlanted";
            this.dtpDatePlanted.Size = new System.Drawing.Size(238, 20);
            this.dtpDatePlanted.TabIndex = 22;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(12, 138);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(238, 20);
            this.txtSize.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(61, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 25);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 393);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblHoursInvested);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtTreeType);
            this.Controls.Add(this.dtpDatePlanted);
            this.Controls.Add(this.txtSize);
            this.Name = "EditSection";
            this.Text = "Edit Section";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHoursInvested;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.TextBox txtTreeType;
        private System.Windows.Forms.DateTimePicker dtpDatePlanted;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnCancel;
    }
}