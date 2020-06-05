namespace InterfacePractice
{
	partial class Form2
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
			this.btnAppendListInventory = new System.Windows.Forms.Button();
			this.btnCloseForm = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.labelAppend = new System.Windows.Forms.Label();
			this.textBoxInventory = new System.Windows.Forms.TextBox();
			this.listBoxInventory = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDeleteListInventory = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.listBoxPersonalInventory = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAppendListInventory
			// 
			this.btnAppendListInventory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnAppendListInventory.Location = new System.Drawing.Point(186, 21);
			this.btnAppendListInventory.Name = "btnAppendListInventory";
			this.btnAppendListInventory.Size = new System.Drawing.Size(75, 23);
			this.btnAppendListInventory.TabIndex = 1;
			this.btnAppendListInventory.Text = "Append";
			this.btnAppendListInventory.UseVisualStyleBackColor = true;
			this.btnAppendListInventory.Click += new System.EventHandler(this.btnAppendListInventory_Click);
			// 
			// btnCloseForm
			// 
			this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCloseForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCloseForm.Location = new System.Drawing.Point(847, 12);
			this.btnCloseForm.Name = "btnCloseForm";
			this.btnCloseForm.Size = new System.Drawing.Size(75, 23);
			this.btnCloseForm.TabIndex = 4;
			this.btnCloseForm.Text = "Close";
			this.btnCloseForm.UseVisualStyleBackColor = true;
			this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(766, 12);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// labelAppend
			// 
			this.labelAppend.AutoSize = true;
			this.labelAppend.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.labelAppend.Location = new System.Drawing.Point(14, 30);
			this.labelAppend.Name = "labelAppend";
			this.labelAppend.Size = new System.Drawing.Size(60, 13);
			this.labelAppend.TabIndex = 6;
			this.labelAppend.Text = "AppendList";
			// 
			// textBoxInventory
			// 
			this.textBoxInventory.Location = new System.Drawing.Point(80, 23);
			this.textBoxInventory.Name = "textBoxInventory";
			this.textBoxInventory.Size = new System.Drawing.Size(100, 20);
			this.textBoxInventory.TabIndex = 7;
			// 
			// listBoxInventory
			// 
			this.listBoxInventory.FormattingEnabled = true;
			this.listBoxInventory.Location = new System.Drawing.Point(52, 96);
			this.listBoxInventory.Name = "listBoxInventory";
			this.listBoxInventory.Size = new System.Drawing.Size(244, 225);
			this.listBoxInventory.TabIndex = 8;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDeleteListInventory);
			this.groupBox1.Controls.Add(this.btnAppendListInventory);
			this.groupBox1.Controls.Add(this.labelAppend);
			this.groupBox1.Controls.Add(this.textBoxInventory);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.groupBox1.Location = new System.Drawing.Point(12, 359);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(344, 162);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Manually Edit List (Used for updates)";
			// 
			// btnDeleteListInventory
			// 
			this.btnDeleteListInventory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnDeleteListInventory.Location = new System.Drawing.Point(186, 50);
			this.btnDeleteListInventory.Name = "btnDeleteListInventory";
			this.btnDeleteListInventory.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteListInventory.TabIndex = 8;
			this.btnDeleteListInventory.Text = "Delete";
			this.btnDeleteListInventory.UseVisualStyleBackColor = true;
			this.btnDeleteListInventory.Click += new System.EventHandler(this.btnDeleteListInventory_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(623, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(241, 31);
			this.label1.TabIndex = 10;
			this.label1.Text = "Personal Inventory";
			// 
			// listBoxPersonalInventory
			// 
			this.listBoxPersonalInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxPersonalInventory.FormattingEnabled = true;
			this.listBoxPersonalInventory.Location = new System.Drawing.Point(620, 96);
			this.listBoxPersonalInventory.Name = "listBoxPersonalInventory";
			this.listBoxPersonalInventory.Size = new System.Drawing.Size(244, 238);
			this.listBoxPersonalInventory.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(85, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(195, 31);
			this.label2.TabIndex = 12;
			this.label2.Text = "Total Inventory";
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new System.Drawing.Point(367, 96);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(184, 229);
			this.checkedListBox1.TabIndex = 13;
			// 
			// Form2
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.CancelButton = this.btnCloseForm;
			this.ClientSize = new System.Drawing.Size(934, 561);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBoxPersonalInventory);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBoxInventory);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCloseForm);
			this.Name = "Form2";
			this.Text = "Form2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnAppendListInventory;
		private System.Windows.Forms.Button btnCloseForm;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label labelAppend;
		private System.Windows.Forms.TextBox textBoxInventory;
		private System.Windows.Forms.ListBox listBoxInventory;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBoxPersonalInventory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnDeleteListInventory;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
	}
}