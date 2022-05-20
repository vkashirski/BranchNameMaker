namespace BranchMaker {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.labelID = new System.Windows.Forms.Label();
			this.labelType = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.textBoxFinal = new System.Windows.Forms.TextBox();
			this.labelFinal = new System.Windows.Forms.Label();
			this.buttonMakeGitBranch = new System.Windows.Forms.Button();
			this.buttonCopyToClipboard = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelID.Location = new System.Drawing.Point(97, 8);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(20, 16);
			this.labelID.TabIndex = 0;
			this.labelID.Text = "ID";
			// 
			// labelType
			// 
			this.labelType.AutoSize = true;
			this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelType.Location = new System.Drawing.Point(9, 8);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(39, 16);
			this.labelType.TabIndex = 1;
			this.labelType.Text = "Type";
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDescription.Location = new System.Drawing.Point(166, 8);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(75, 16);
			this.labelDescription.TabIndex = 2;
			this.labelDescription.Text = "Description";
			// 
			// comboBoxType
			// 
			this.comboBoxType.FormattingEnabled = true;
			this.comboBoxType.Items.AddRange(new object[] {
            "feature",
            "fix",
            "chore"});
			this.comboBoxType.Location = new System.Drawing.Point(12, 27);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new System.Drawing.Size(82, 21);
			this.comboBoxType.TabIndex = 3;
			// 
			// textBoxID
			// 
			this.textBoxID.Location = new System.Drawing.Point(100, 27);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.Size = new System.Drawing.Size(63, 20);
			this.textBoxID.TabIndex = 4;
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(169, 27);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(465, 20);
			this.textBoxDescription.TabIndex = 5;
			// 
			// textBoxFinal
			// 
			this.textBoxFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxFinal.Location = new System.Drawing.Point(12, 103);
			this.textBoxFinal.Name = "textBoxFinal";
			this.textBoxFinal.Size = new System.Drawing.Size(487, 24);
			this.textBoxFinal.TabIndex = 6;
			// 
			// labelFinal
			// 
			this.labelFinal.AutoSize = true;
			this.labelFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFinal.Location = new System.Drawing.Point(9, 84);
			this.labelFinal.Name = "labelFinal";
			this.labelFinal.Size = new System.Drawing.Size(68, 16);
			this.labelFinal.TabIndex = 7;
			this.labelFinal.Text = "Git Branch";
			// 
			// buttonMakeGitBranch
			// 
			this.buttonMakeGitBranch.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.buttonMakeGitBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMakeGitBranch.Location = new System.Drawing.Point(12, 54);
			this.buttonMakeGitBranch.Name = "buttonMakeGitBranch";
			this.buttonMakeGitBranch.Size = new System.Drawing.Size(622, 27);
			this.buttonMakeGitBranch.TabIndex = 8;
			this.buttonMakeGitBranch.Text = "Make Git Branch";
			this.buttonMakeGitBranch.UseVisualStyleBackColor = false;
			this.buttonMakeGitBranch.Click += new System.EventHandler(this.buttonMakeGitBranch_Click);
			// 
			// buttonCopyToClipboard
			// 
			this.buttonCopyToClipboard.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.buttonCopyToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCopyToClipboard.Location = new System.Drawing.Point(505, 103);
			this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
			this.buttonCopyToClipboard.Size = new System.Drawing.Size(129, 24);
			this.buttonCopyToClipboard.TabIndex = 9;
			this.buttonCopyToClipboard.Text = "Copy to Clipboard";
			this.buttonCopyToClipboard.UseVisualStyleBackColor = false;
			this.buttonCopyToClipboard.Click += new System.EventHandler(this.buttonCopyToClipboard_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 141);
			this.Controls.Add(this.buttonCopyToClipboard);
			this.Controls.Add(this.buttonMakeGitBranch);
			this.Controls.Add(this.labelFinal);
			this.Controls.Add(this.textBoxFinal);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.textBoxID);
			this.Controls.Add(this.comboBoxType);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.labelType);
			this.Controls.Add(this.labelID);
			this.MaximumSize = new System.Drawing.Size(661, 180);
			this.MinimumSize = new System.Drawing.Size(661, 180);
			this.Name = "Form1";
			this.Text = "Git Branch Maker";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Label labelType;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.ComboBox comboBoxType;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.TextBox textBoxFinal;
		private System.Windows.Forms.Label labelFinal;
		private System.Windows.Forms.Button buttonMakeGitBranch;
		private System.Windows.Forms.Button buttonCopyToClipboard;
	}
}

