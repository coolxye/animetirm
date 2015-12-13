﻿namespace AnimeTrim
{
	partial class ModForm
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
			this.tbEpisode = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnBrowser = new System.Windows.Forms.Button();
			this.tbStoreIndex = new System.Windows.Forms.TextBox();
			this.cboSeason = new System.Windows.Forms.ComboBox();
			this.cboYear = new System.Windows.Forms.ComboBox();
			this.tbKana = new System.Windows.Forms.TextBox();
			this.tbTitle = new System.Windows.Forms.TextBox();
			this.gbNote = new System.Windows.Forms.GroupBox();
			this.rtbNote = new System.Windows.Forms.RichTextBox();
			this.lblPath = new System.Windows.Forms.Label();
			this.lblSchedule = new System.Windows.Forms.Label();
			this.lblKana = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblEpisode = new System.Windows.Forms.Label();
			this.tbInc = new System.Windows.Forms.TextBox();
			this.lblInc = new System.Windows.Forms.Label();
			this.cboFormat = new System.Windows.Forms.ComboBox();
			this.lblMergeFormat = new System.Windows.Forms.Label();
			this.cboSubStyle = new System.Windows.Forms.ComboBox();
			this.lblSubStyle = new System.Windows.Forms.Label();
			this.gbNote.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbEpisode
			// 
			this.tbEpisode.Location = new System.Drawing.Point(342, 39);
			this.tbEpisode.Name = "tbEpisode";
			this.tbEpisode.Size = new System.Drawing.Size(120, 21);
			this.tbEpisode.TabIndex = 3;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(456, 235);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 11;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(537, 235);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnBrowser
			// 
			this.btnBrowser.Location = new System.Drawing.Point(359, 91);
			this.btnBrowser.Name = "btnBrowser";
			this.btnBrowser.Size = new System.Drawing.Size(75, 23);
			this.btnBrowser.TabIndex = 9;
			this.btnBrowser.UseVisualStyleBackColor = true;
			this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
			// 
			// tbStoreIndex
			// 
			this.tbStoreIndex.Location = new System.Drawing.Point(53, 92);
			this.tbStoreIndex.Name = "tbStoreIndex";
			this.tbStoreIndex.Size = new System.Drawing.Size(300, 21);
			this.tbStoreIndex.TabIndex = 8;
			this.tbStoreIndex.TextChanged += new System.EventHandler(this.tbStoreIndex_TextChanged);
			// 
			// cboSeason
			// 
			this.cboSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSeason.FormattingEnabled = true;
			this.cboSeason.Location = new System.Drawing.Point(128, 66);
			this.cboSeason.Name = "cboSeason";
			this.cboSeason.Size = new System.Drawing.Size(65, 20);
			this.cboSeason.TabIndex = 5;
			// 
			// cboYear
			// 
			this.cboYear.FormattingEnabled = true;
			this.cboYear.Items.AddRange(new object[] {
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012"});
			this.cboYear.Location = new System.Drawing.Point(72, 66);
			this.cboYear.Name = "cboYear";
			this.cboYear.Size = new System.Drawing.Size(50, 20);
			this.cboYear.TabIndex = 4;
			this.cboYear.TextChanged += new System.EventHandler(this.cboYear_TextChanged);
			// 
			// tbKana
			// 
			this.tbKana.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbKana.Location = new System.Drawing.Point(342, 12);
			this.tbKana.Name = "tbKana";
			this.tbKana.Size = new System.Drawing.Size(220, 21);
			this.tbKana.TabIndex = 1;
			// 
			// tbTitle
			// 
			this.tbTitle.Location = new System.Drawing.Point(53, 12);
			this.tbTitle.Name = "tbTitle";
			this.tbTitle.Size = new System.Drawing.Size(220, 21);
			this.tbTitle.TabIndex = 0;
			this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
			// 
			// gbNote
			// 
			this.gbNote.Controls.Add(this.rtbNote);
			this.gbNote.Location = new System.Drawing.Point(12, 120);
			this.gbNote.Name = "gbNote";
			this.gbNote.Size = new System.Drawing.Size(600, 109);
			this.gbNote.TabIndex = 10;
			this.gbNote.TabStop = false;
			this.gbNote.Text = "Note";
			// 
			// rtbNote
			// 
			this.rtbNote.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbNote.Location = new System.Drawing.Point(3, 17);
			this.rtbNote.Name = "rtbNote";
			this.rtbNote.Size = new System.Drawing.Size(594, 89);
			this.rtbNote.TabIndex = 0;
			this.rtbNote.Text = "";
			this.rtbNote.Enter += new System.EventHandler(this.rtbNote_Enter);
			this.rtbNote.Leave += new System.EventHandler(this.rtbNote_Leave);
			// 
			// lblPath
			// 
			this.lblPath.AutoSize = true;
			this.lblPath.Location = new System.Drawing.Point(13, 95);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(29, 12);
			this.lblPath.TabIndex = 20;
			this.lblPath.Text = "Path";
			// 
			// lblSchedule
			// 
			this.lblSchedule.AutoSize = true;
			this.lblSchedule.Location = new System.Drawing.Point(13, 69);
			this.lblSchedule.Name = "lblSchedule";
			this.lblSchedule.Size = new System.Drawing.Size(53, 12);
			this.lblSchedule.TabIndex = 17;
			this.lblSchedule.Text = "Schedule";
			// 
			// lblKana
			// 
			this.lblKana.AutoSize = true;
			this.lblKana.Location = new System.Drawing.Point(289, 15);
			this.lblKana.Name = "lblKana";
			this.lblKana.Size = new System.Drawing.Size(29, 12);
			this.lblKana.TabIndex = 14;
			this.lblKana.Text = "Kana";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(12, 15);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(35, 12);
			this.lblTitle.TabIndex = 13;
			this.lblTitle.Text = "Title";
			// 
			// lblEpisode
			// 
			this.lblEpisode.AutoSize = true;
			this.lblEpisode.Location = new System.Drawing.Point(289, 42);
			this.lblEpisode.Name = "lblEpisode";
			this.lblEpisode.Size = new System.Drawing.Size(47, 12);
			this.lblEpisode.TabIndex = 16;
			this.lblEpisode.Text = "Episode";
			// 
			// tbInc
			// 
			this.tbInc.Location = new System.Drawing.Point(53, 39);
			this.tbInc.Name = "tbInc";
			this.tbInc.Size = new System.Drawing.Size(180, 21);
			this.tbInc.TabIndex = 2;
			// 
			// lblInc
			// 
			this.lblInc.AutoSize = true;
			this.lblInc.Location = new System.Drawing.Point(13, 45);
			this.lblInc.Name = "lblInc";
			this.lblInc.Size = new System.Drawing.Size(23, 12);
			this.lblInc.TabIndex = 15;
			this.lblInc.Text = "Inc";
			// 
			// cboFormat
			// 
			this.cboFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFormat.FormattingEnabled = true;
			this.cboFormat.Location = new System.Drawing.Point(301, 66);
			this.cboFormat.Name = "cboFormat";
			this.cboFormat.Size = new System.Drawing.Size(65, 20);
			this.cboFormat.TabIndex = 6;
			// 
			// lblMergeFormat
			// 
			this.lblMergeFormat.AutoSize = true;
			this.lblMergeFormat.Location = new System.Drawing.Point(224, 69);
			this.lblMergeFormat.Name = "lblMergeFormat";
			this.lblMergeFormat.Size = new System.Drawing.Size(71, 12);
			this.lblMergeFormat.TabIndex = 18;
			this.lblMergeFormat.Text = "MergeFormat";
			// 
			// cboSubStyle
			// 
			this.cboSubStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSubStyle.FormattingEnabled = true;
			this.cboSubStyle.Location = new System.Drawing.Point(452, 66);
			this.cboSubStyle.Name = "cboSubStyle";
			this.cboSubStyle.Size = new System.Drawing.Size(80, 20);
			this.cboSubStyle.TabIndex = 7;
			// 
			// lblSubStyle
			// 
			this.lblSubStyle.AutoSize = true;
			this.lblSubStyle.Location = new System.Drawing.Point(393, 69);
			this.lblSubStyle.Name = "lblSubStyle";
			this.lblSubStyle.Size = new System.Drawing.Size(53, 12);
			this.lblSubStyle.TabIndex = 19;
			this.lblSubStyle.Text = "SubStyle";
			// 
			// ModForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(624, 270);
			this.Controls.Add(this.cboSubStyle);
			this.Controls.Add(this.lblSubStyle);
			this.Controls.Add(this.cboFormat);
			this.Controls.Add(this.lblMergeFormat);
			this.Controls.Add(this.tbInc);
			this.Controls.Add(this.lblInc);
			this.Controls.Add(this.lblEpisode);
			this.Controls.Add(this.tbEpisode);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnBrowser);
			this.Controls.Add(this.tbStoreIndex);
			this.Controls.Add(this.cboSeason);
			this.Controls.Add(this.cboYear);
			this.Controls.Add(this.tbKana);
			this.Controls.Add(this.tbTitle);
			this.Controls.Add(this.gbNote);
			this.Controls.Add(this.lblPath);
			this.Controls.Add(this.lblSchedule);
			this.Controls.Add(this.lblKana);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ModForm";
			this.Text = "Modify a Anime";
			this.gbNote.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbEpisode;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnBrowser;
		private System.Windows.Forms.TextBox tbStoreIndex;
		private System.Windows.Forms.ComboBox cboSeason;
		private System.Windows.Forms.ComboBox cboYear;
		private System.Windows.Forms.TextBox tbKana;
		private System.Windows.Forms.TextBox tbTitle;
		private System.Windows.Forms.GroupBox gbNote;
		private System.Windows.Forms.RichTextBox rtbNote;
		private System.Windows.Forms.Label lblPath;
		private System.Windows.Forms.Label lblSchedule;
		private System.Windows.Forms.Label lblKana;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblEpisode;
		private System.Windows.Forms.TextBox tbInc;
		private System.Windows.Forms.Label lblInc;
		private System.Windows.Forms.ComboBox cboFormat;
		private System.Windows.Forms.Label lblMergeFormat;
		private System.Windows.Forms.ComboBox cboSubStyle;
		private System.Windows.Forms.Label lblSubStyle;
	}
}