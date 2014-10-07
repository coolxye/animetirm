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
			this.lblStoreIndex = new System.Windows.Forms.Label();
			this.lblReleaseDate = new System.Windows.Forms.Label();
			this.lblKana = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblEpisode = new System.Windows.Forms.Label();
			this.lblMatchTitle = new System.Windows.Forms.Label();
			this.lblMatchYear = new System.Windows.Forms.Label();
			this.lblMatchStoreIndex = new System.Windows.Forms.Label();
			this.gbNote.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbEpisode
			// 
			this.tbEpisode.Location = new System.Drawing.Point(342, 39);
			this.tbEpisode.Name = "tbEpisode";
			this.tbEpisode.Size = new System.Drawing.Size(120, 21);
			this.tbEpisode.TabIndex = 4;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(456, 207);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 8;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(537, 207);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnBrowser
			// 
			this.btnBrowser.Location = new System.Drawing.Point(395, 63);
			this.btnBrowser.Name = "btnBrowser";
			this.btnBrowser.Size = new System.Drawing.Size(75, 23);
			this.btnBrowser.TabIndex = 6;
			this.btnBrowser.UseVisualStyleBackColor = true;
			this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
			// 
			// tbStoreIndex
			// 
			this.tbStoreIndex.Location = new System.Drawing.Point(89, 65);
			this.tbStoreIndex.Name = "tbStoreIndex";
			this.tbStoreIndex.Size = new System.Drawing.Size(300, 21);
			this.tbStoreIndex.TabIndex = 5;
			this.tbStoreIndex.TextChanged += new System.EventHandler(this.tbStoreIndex_TextChanged);
			// 
			// cboSeason
			// 
			this.cboSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSeason.FormattingEnabled = true;
			this.cboSeason.Items.AddRange(new object[] {
            "Winter",
            "Spring",
            "Summer",
            "Fall"});
			this.cboSeason.Location = new System.Drawing.Point(145, 39);
			this.cboSeason.Name = "cboSeason";
			this.cboSeason.Size = new System.Drawing.Size(65, 20);
			this.cboSeason.TabIndex = 3;
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
			this.cboYear.Location = new System.Drawing.Point(89, 39);
			this.cboYear.Name = "cboYear";
			this.cboYear.Size = new System.Drawing.Size(50, 20);
			this.cboYear.TabIndex = 2;
			this.cboYear.TextChanged += new System.EventHandler(this.cboYear_TextChanged);
			// 
			// tbKana
			// 
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
			this.gbNote.Location = new System.Drawing.Point(12, 92);
			this.gbNote.Name = "gbNote";
			this.gbNote.Size = new System.Drawing.Size(600, 109);
			this.gbNote.TabIndex = 7;
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
			// lblStoreIndex
			// 
			this.lblStoreIndex.AutoSize = true;
			this.lblStoreIndex.Location = new System.Drawing.Point(12, 68);
			this.lblStoreIndex.Name = "lblStoreIndex";
			this.lblStoreIndex.Size = new System.Drawing.Size(65, 12);
			this.lblStoreIndex.TabIndex = 14;
			this.lblStoreIndex.Text = "StoreIndex";
			// 
			// lblReleaseDate
			// 
			this.lblReleaseDate.AutoSize = true;
			this.lblReleaseDate.Location = new System.Drawing.Point(12, 42);
			this.lblReleaseDate.Name = "lblReleaseDate";
			this.lblReleaseDate.Size = new System.Drawing.Size(71, 12);
			this.lblReleaseDate.TabIndex = 12;
			this.lblReleaseDate.Text = "ReleaseDate";
			// 
			// lblKana
			// 
			this.lblKana.AutoSize = true;
			this.lblKana.Location = new System.Drawing.Point(289, 15);
			this.lblKana.Name = "lblKana";
			this.lblKana.Size = new System.Drawing.Size(29, 12);
			this.lblKana.TabIndex = 11;
			this.lblKana.Text = "Kana";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(12, 15);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(35, 12);
			this.lblTitle.TabIndex = 10;
			this.lblTitle.Text = "Title";
			// 
			// lblEpisode
			// 
			this.lblEpisode.AutoSize = true;
			this.lblEpisode.Location = new System.Drawing.Point(289, 42);
			this.lblEpisode.Name = "lblEpisode";
			this.lblEpisode.Size = new System.Drawing.Size(47, 12);
			this.lblEpisode.TabIndex = 13;
			this.lblEpisode.Text = "Episode";
			// 
			// lblMatchTitle
			// 
			this.lblMatchTitle.AutoSize = true;
			this.lblMatchTitle.Location = new System.Drawing.Point(490, 39);
			this.lblMatchTitle.Name = "lblMatchTitle";
			this.lblMatchTitle.Size = new System.Drawing.Size(41, 12);
			this.lblMatchTitle.TabIndex = 15;
			this.lblMatchTitle.Text = "label1";
			// 
			// lblMatchYear
			// 
			this.lblMatchYear.AutoSize = true;
			this.lblMatchYear.Location = new System.Drawing.Point(490, 55);
			this.lblMatchYear.Name = "lblMatchYear";
			this.lblMatchYear.Size = new System.Drawing.Size(41, 12);
			this.lblMatchYear.TabIndex = 16;
			this.lblMatchYear.Text = "label2";
			// 
			// lblMatchStoreIndex
			// 
			this.lblMatchStoreIndex.AutoSize = true;
			this.lblMatchStoreIndex.Location = new System.Drawing.Point(490, 71);
			this.lblMatchStoreIndex.Name = "lblMatchStoreIndex";
			this.lblMatchStoreIndex.Size = new System.Drawing.Size(41, 12);
			this.lblMatchStoreIndex.TabIndex = 17;
			this.lblMatchStoreIndex.Text = "label3";
			// 
			// ModForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(624, 242);
			this.Controls.Add(this.lblMatchStoreIndex);
			this.Controls.Add(this.lblMatchYear);
			this.Controls.Add(this.lblMatchTitle);
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
			this.Controls.Add(this.lblStoreIndex);
			this.Controls.Add(this.lblReleaseDate);
			this.Controls.Add(this.lblKana);
			this.Controls.Add(this.lblTitle);
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
		private System.Windows.Forms.Label lblStoreIndex;
		private System.Windows.Forms.Label lblReleaseDate;
		private System.Windows.Forms.Label lblKana;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblEpisode;
		private System.Windows.Forms.Label lblMatchTitle;
		private System.Windows.Forms.Label lblMatchYear;
		private System.Windows.Forms.Label lblMatchStoreIndex;
	}
}