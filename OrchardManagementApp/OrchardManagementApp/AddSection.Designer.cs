namespace OrchardManagementApp
{
    partial class AddSection
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblTimePlanted = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.datePlanted = new System.Windows.Forms.DateTimePicker();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(110, 319);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(102, 23);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "Add Section";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(22, 56);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(38, 13);
            this.lblType.TabIndex = 34;
            this.lblType.Text = "Type:*";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(12, 72);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(200, 20);
            this.txtType.TabIndex = 33;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(12, 219);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(200, 94);
            this.txtComments.TabIndex = 32;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(22, 203);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(59, 13);
            this.lblComments.TabIndex = 31;
            this.lblComments.Text = "Comments:";
            // 
            // lblTimePlanted
            // 
            this.lblTimePlanted.AutoSize = true;
            this.lblTimePlanted.Location = new System.Drawing.Point(22, 153);
            this.lblTimePlanted.Name = "lblTimePlanted";
            this.lblTimePlanted.Size = new System.Drawing.Size(76, 13);
            this.lblTimePlanted.TabIndex = 30;
            this.lblTimePlanted.Text = "Time Planted:*";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(22, 105);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(55, 13);
            this.lblSize.TabIndex = 29;
            this.lblSize.Text = "Size (ha):*";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 13);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Name:*";
            // 
            // datePlanted
            // 
            this.datePlanted.Location = new System.Drawing.Point(12, 169);
            this.datePlanted.Name = "datePlanted";
            this.datePlanted.Size = new System.Drawing.Size(200, 20);
            this.datePlanted.TabIndex = 27;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(12, 121);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(200, 20);
            this.txtSize.TabIndex = 26;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 25;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(29, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 349);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblTimePlanted);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.datePlanted);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtName);
            this.Name = "AddSection";
            this.Text = "AddSection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblTimePlanted;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker datePlanted;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancel;
    }
}