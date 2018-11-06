namespace PhraseGobbler
{
	partial class MainForm
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
			this.stsMain = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnProcess = new System.Windows.Forms.Button();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.lblInput = new System.Windows.Forms.Label();
			this.lblOutput = new System.Windows.Forms.Label();
			this.btnOptions = new System.Windows.Forms.Button();
			this.stsMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// stsMain
			// 
			this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.stsMain.Location = new System.Drawing.Point(0, 453);
			this.stsMain.Name = "stsMain";
			this.stsMain.Size = new System.Drawing.Size(811, 22);
			this.stsMain.TabIndex = 0;
			this.stsMain.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(39, 17);
			this.lblStatus.Text = "Ready";
			// 
			// txtInput
			// 
			this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtInput.Location = new System.Drawing.Point(12, 25);
			this.txtInput.Multiline = true;
			this.txtInput.Name = "txtInput";
			this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtInput.Size = new System.Drawing.Size(363, 425);
			this.txtInput.TabIndex = 1;
			// 
			// btnProcess
			// 
			this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnProcess.Location = new System.Drawing.Point(381, 25);
			this.btnProcess.Name = "btnProcess";
			this.btnProcess.Size = new System.Drawing.Size(33, 425);
			this.btnProcess.TabIndex = 2;
			this.btnProcess.Text = "->";
			this.btnProcess.UseVisualStyleBackColor = true;
			this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
			// 
			// txtOutput
			// 
			this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtOutput.Location = new System.Drawing.Point(420, 25);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ReadOnly = true;
			this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtOutput.Size = new System.Drawing.Size(379, 425);
			this.txtOutput.TabIndex = 3;
			// 
			// lblInput
			// 
			this.lblInput.AutoSize = true;
			this.lblInput.Location = new System.Drawing.Point(12, 9);
			this.lblInput.Name = "lblInput";
			this.lblInput.Size = new System.Drawing.Size(34, 13);
			this.lblInput.TabIndex = 4;
			this.lblInput.Text = "Input:";
			// 
			// lblOutput
			// 
			this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblOutput.AutoSize = true;
			this.lblOutput.Location = new System.Drawing.Point(420, 9);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(42, 13);
			this.lblOutput.TabIndex = 5;
			this.lblOutput.Text = "Output:";
			// 
			// btnOptions
			// 
			this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOptions.Location = new System.Drawing.Point(381, 5);
			this.btnOptions.Name = "btnOptions";
			this.btnOptions.Size = new System.Drawing.Size(33, 19);
			this.btnOptions.TabIndex = 6;
			this.btnOptions.Text = "...";
			this.btnOptions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnOptions.UseVisualStyleBackColor = true;
			this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(811, 475);
			this.Controls.Add(this.btnOptions);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.lblInput);
			this.Controls.Add(this.txtOutput);
			this.Controls.Add(this.btnProcess);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.stsMain);
			this.Name = "MainForm";
			this.Text = "Microsoft Phrase Gobbler 2018 Professional";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.stsMain.ResumeLayout(false);
			this.stsMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip stsMain;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Button btnProcess;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Label lblInput;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.Button btnOptions;
	}
}

