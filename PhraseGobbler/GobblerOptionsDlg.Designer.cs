namespace PhraseGobbler
{
	partial class GobblerOptionsDlg
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
			this.btnApply = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.lblSeed = new System.Windows.Forms.Label();
			this.cboAddJunk = new System.Windows.Forms.CheckBox();
			this.txtSeed = new System.Windows.Forms.TextBox();
			this.cboPrioritizeLongWords = new System.Windows.Forms.CheckBox();
			this.lblGeneral = new System.Windows.Forms.Label();
			this.cboExclusiveParagraphs = new System.Windows.Forms.CheckBox();
			this.pnlMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnApply
			// 
			this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnApply.Enabled = false;
			this.btnApply.Location = new System.Drawing.Point(314, 147);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(75, 23);
			this.btnApply.TabIndex = 3;
			this.btnApply.Text = "Apply";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(233, 147);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.Location = new System.Drawing.Point(152, 147);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// pnlMain
			// 
			this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlMain.Controls.Add(this.cboExclusiveParagraphs);
			this.pnlMain.Controls.Add(this.lblSeed);
			this.pnlMain.Controls.Add(this.cboAddJunk);
			this.pnlMain.Controls.Add(this.txtSeed);
			this.pnlMain.Controls.Add(this.cboPrioritizeLongWords);
			this.pnlMain.Controls.Add(this.lblGeneral);
			this.pnlMain.Location = new System.Drawing.Point(12, 12);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(377, 129);
			this.pnlMain.TabIndex = 4;
			// 
			// lblSeed
			// 
			this.lblSeed.AutoSize = true;
			this.lblSeed.Location = new System.Drawing.Point(13, 97);
			this.lblSeed.Name = "lblSeed";
			this.lblSeed.Size = new System.Drawing.Size(152, 13);
			this.lblSeed.TabIndex = 5;
			this.lblSeed.Text = "Seed (leave blank for random):";
			// 
			// cboAddJunk
			// 
			this.cboAddJunk.AutoSize = true;
			this.cboAddJunk.Location = new System.Drawing.Point(16, 71);
			this.cboAddJunk.Name = "cboAddJunk";
			this.cboAddJunk.Size = new System.Drawing.Size(71, 17);
			this.cboAddJunk.TabIndex = 7;
			this.cboAddJunk.Text = "Add Junk";
			this.cboAddJunk.UseVisualStyleBackColor = true;
			this.cboAddJunk.CheckedChanged += new System.EventHandler(this.cboAddJunk_CheckedChanged);
			// 
			// txtSeed
			// 
			this.txtSeed.Location = new System.Drawing.Point(171, 94);
			this.txtSeed.Name = "txtSeed";
			this.txtSeed.Size = new System.Drawing.Size(184, 20);
			this.txtSeed.TabIndex = 8;
			this.txtSeed.TextChanged += new System.EventHandler(this.txtSeed_TextChanged);
			// 
			// cboPrioritizeLongWords
			// 
			this.cboPrioritizeLongWords.AutoSize = true;
			this.cboPrioritizeLongWords.Location = new System.Drawing.Point(16, 48);
			this.cboPrioritizeLongWords.Name = "cboPrioritizeLongWords";
			this.cboPrioritizeLongWords.Size = new System.Drawing.Size(126, 17);
			this.cboPrioritizeLongWords.TabIndex = 6;
			this.cboPrioritizeLongWords.Text = "Prioritize Long Words";
			this.cboPrioritizeLongWords.UseVisualStyleBackColor = true;
			this.cboPrioritizeLongWords.CheckedChanged += new System.EventHandler(this.cboPrioritizeLongWords_CheckedChanged);
			// 
			// lblGeneral
			// 
			this.lblGeneral.AutoSize = true;
			this.lblGeneral.Location = new System.Drawing.Point(13, 9);
			this.lblGeneral.Name = "lblGeneral";
			this.lblGeneral.Size = new System.Drawing.Size(47, 13);
			this.lblGeneral.TabIndex = 5;
			this.lblGeneral.Text = "General:";
			// 
			// cboExclusiveParagraphs
			// 
			this.cboExclusiveParagraphs.AutoSize = true;
			this.cboExclusiveParagraphs.Location = new System.Drawing.Point(16, 25);
			this.cboExclusiveParagraphs.Name = "cboExclusiveParagraphs";
			this.cboExclusiveParagraphs.Size = new System.Drawing.Size(128, 17);
			this.cboExclusiveParagraphs.TabIndex = 5;
			this.cboExclusiveParagraphs.Text = "Exclusive Paragraphs";
			this.cboExclusiveParagraphs.UseVisualStyleBackColor = true;
			this.cboExclusiveParagraphs.CheckedChanged += new System.EventHandler(this.cboExclusiveParagraphs_CheckedChanged);
			// 
			// GobblerOptionsDlg
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(401, 182);
			this.Controls.Add(this.pnlMain);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnApply);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GobblerOptionsDlg";
			this.Text = "Gobble Options";
			this.pnlMain.ResumeLayout(false);
			this.pnlMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.Label lblGeneral;
		private System.Windows.Forms.CheckBox cboPrioritizeLongWords;
		private System.Windows.Forms.CheckBox cboAddJunk;
		private System.Windows.Forms.Label lblSeed;
		private System.Windows.Forms.TextBox txtSeed;
		private System.Windows.Forms.CheckBox cboExclusiveParagraphs;
	}
}