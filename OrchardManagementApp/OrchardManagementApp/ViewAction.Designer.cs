namespace OrchardManagementApp
{
    partial class ViewAction
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
            this.txtActionType = new System.Windows.Forms.TextBox();
            this.dtpAction = new System.Windows.Forms.DateTimePicker();
            this.txtHoursInvested = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoursInvested = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtActionType
            // 
            this.txtActionType.Enabled = false;
            this.txtActionType.Location = new System.Drawing.Point(12, 40);
            this.txtActionType.Name = "txtActionType";
            this.txtActionType.Size = new System.Drawing.Size(238, 20);
            this.txtActionType.TabIndex = 0;
            // 
            // dtpAction
            // 
            this.dtpAction.Enabled = false;
            this.dtpAction.Location = new System.Drawing.Point(12, 66);
            this.dtpAction.Name = "dtpAction";
            this.dtpAction.Size = new System.Drawing.Size(238, 20);
            this.dtpAction.TabIndex = 1;
            // 
            // txtHoursInvested
            // 
            this.txtHoursInvested.Enabled = false;
            this.txtHoursInvested.Location = new System.Drawing.Point(12, 92);
            this.txtHoursInvested.Name = "txtHoursInvested";
            this.txtHoursInvested.Size = new System.Drawing.Size(200, 20);
            this.txtHoursInvested.TabIndex = 2;
            // 
            // txtComment
            // 
            this.txtComment.Enabled = false;
            this.txtComment.Location = new System.Drawing.Point(12, 118);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(238, 137);
            this.txtComment.TabIndex = 3;
            this.txtComment.Text = "";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(147, 261);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Action";
            // 
            // lblHoursInvested
            // 
            this.lblHoursInvested.AutoSize = true;
            this.lblHoursInvested.Location = new System.Drawing.Point(215, 95);
            this.lblHoursInvested.Name = "lblHoursInvested";
            this.lblHoursInvested.Size = new System.Drawing.Size(35, 13);
            this.lblHoursInvested.TabIndex = 6;
            this.lblHoursInvested.Text = "Hours";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(59, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ViewAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 291);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblHoursInvested);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtHoursInvested);
            this.Controls.Add(this.dtpAction);
            this.Controls.Add(this.txtActionType);
            this.Name = "ViewAction";
            this.Text = "ViewAction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActionType;
        private System.Windows.Forms.DateTimePicker dtpAction;
        private System.Windows.Forms.TextBox txtHoursInvested;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoursInvested;
        private System.Windows.Forms.Button btnCancel;
    }
}