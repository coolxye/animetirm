namespace AnimeTrim
{
	partial class AnimeForm
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
			this.tctlAnime = new System.Windows.Forms.TabControl();
			this.tpAnime = new System.Windows.Forms.TabPage();
			this.folvAnime = new BrightIdeasSoftware.FastObjectListView();
			this.olvColTitle = new BrightIdeasSoftware.OLVColumn();
			this.olvColName = new BrightIdeasSoftware.OLVColumn();
			this.olvColReleaseDate = new BrightIdeasSoftware.OLVColumn();
			this.olvColType = new BrightIdeasSoftware.OLVColumn();
			this.olvColFormat = new BrightIdeasSoftware.OLVColumn();
			this.olvColPublisher = new BrightIdeasSoftware.OLVColumn();
			this.olvColSubStyle = new BrightIdeasSoftware.OLVColumn();
			this.olvColStoreIndex = new BrightIdeasSoftware.OLVColumn();
			this.olvColSpace = new BrightIdeasSoftware.OLVColumn();
			this.olvColGather = new BrightIdeasSoftware.OLVColumn();
			this.olvColView = new BrightIdeasSoftware.OLVColumn();
			this.olvColRate = new BrightIdeasSoftware.OLVColumn();
			this.olvColNote = new BrightIdeasSoftware.OLVColumn();
			this.hiStyle = new BrightIdeasSoftware.HotItemStyle();
			this.tpMusic = new System.Windows.Forms.TabPage();
			this.rtbAnime = new System.Windows.Forms.RichTextBox();
			this.cbGroups = new System.Windows.Forms.CheckBox();
			this.tbFilter = new System.Windows.Forms.TextBox();
			this.pnlTools = new System.Windows.Forms.Panel();
			this.cboFilter = new System.Windows.Forms.ComboBox();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnPaste = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.btnModify = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnChange = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.scAnime = new System.Windows.Forms.SplitContainer();
			this.ssAnime = new System.Windows.Forms.StatusStrip();
			this.tsslSelected = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslSelSpace = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslTotal = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslSpace = new System.Windows.Forms.ToolStripStatusLabel();
			this.tctlAnime.SuspendLayout();
			this.tpAnime.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.folvAnime)).BeginInit();
			this.pnlTools.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scAnime)).BeginInit();
			this.scAnime.Panel1.SuspendLayout();
			this.scAnime.Panel2.SuspendLayout();
			this.scAnime.SuspendLayout();
			this.ssAnime.SuspendLayout();
			this.SuspendLayout();
			// 
			// tctlAnime
			// 
			this.tctlAnime.Controls.Add(this.tpAnime);
			this.tctlAnime.Controls.Add(this.tpMusic);
			this.tctlAnime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tctlAnime.Location = new System.Drawing.Point(0, 0);
			this.tctlAnime.Name = "tctlAnime";
			this.tctlAnime.SelectedIndex = 0;
			this.tctlAnime.ShowToolTips = true;
			this.tctlAnime.Size = new System.Drawing.Size(860, 343);
			this.tctlAnime.TabIndex = 0;
			// 
			// tpAnime
			// 
			this.tpAnime.Controls.Add(this.folvAnime);
			this.tpAnime.Location = new System.Drawing.Point(4, 22);
			this.tpAnime.Name = "tpAnime";
			this.tpAnime.Padding = new System.Windows.Forms.Padding(3);
			this.tpAnime.Size = new System.Drawing.Size(852, 317);
			this.tpAnime.TabIndex = 0;
			this.tpAnime.Text = "Anime";
			this.tpAnime.UseVisualStyleBackColor = true;
			// 
			// folvAnime
			// 
			this.folvAnime.AllColumns.Add(this.olvColTitle);
			this.folvAnime.AllColumns.Add(this.olvColName);
			this.folvAnime.AllColumns.Add(this.olvColReleaseDate);
			this.folvAnime.AllColumns.Add(this.olvColType);
			this.folvAnime.AllColumns.Add(this.olvColFormat);
			this.folvAnime.AllColumns.Add(this.olvColPublisher);
			this.folvAnime.AllColumns.Add(this.olvColSubStyle);
			this.folvAnime.AllColumns.Add(this.olvColStoreIndex);
			this.folvAnime.AllColumns.Add(this.olvColSpace);
			this.folvAnime.AllColumns.Add(this.olvColGather);
			this.folvAnime.AllColumns.Add(this.olvColView);
			this.folvAnime.AllColumns.Add(this.olvColRate);
			this.folvAnime.AllColumns.Add(this.olvColNote);
			this.folvAnime.AllowColumnReorder = true;
			this.folvAnime.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.folvAnime.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
			this.folvAnime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColTitle,
            this.olvColName,
            this.olvColReleaseDate,
            this.olvColType,
            this.olvColFormat,
            this.olvColPublisher,
            this.olvColSubStyle,
            this.olvColStoreIndex,
            this.olvColSpace,
            this.olvColGather,
            this.olvColView,
            this.olvColRate,
            this.olvColNote});
			this.folvAnime.Cursor = System.Windows.Forms.Cursors.Default;
			this.folvAnime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.folvAnime.EmptyListMsg = "アニメがない...";
			this.folvAnime.FullRowSelect = true;
			this.folvAnime.GroupWithItemCountSingularFormat = "{0} [{1} items]";
			this.folvAnime.HideSelection = false;
			this.folvAnime.HotItemStyle = this.hiStyle;
			this.folvAnime.Location = new System.Drawing.Point(3, 3);
			this.folvAnime.Name = "folvAnime";
			this.folvAnime.OwnerDraw = true;
			this.folvAnime.ShowCommandMenuOnRightClick = true;
			this.folvAnime.ShowGroups = false;
			this.folvAnime.ShowItemCountOnGroups = true;
			this.folvAnime.ShowItemToolTips = true;
			this.folvAnime.Size = new System.Drawing.Size(846, 311);
			this.folvAnime.TabIndex = 0;
			this.folvAnime.TintSortColumn = true;
			this.folvAnime.UseAlternatingBackColors = true;
			this.folvAnime.UseCompatibleStateImageBehavior = false;
			this.folvAnime.UseFiltering = true;
			this.folvAnime.UseHotItem = true;
			this.folvAnime.UseHyperlinks = true;
			this.folvAnime.View = System.Windows.Forms.View.Details;
			this.folvAnime.VirtualMode = true;
			this.folvAnime.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.folvAnime_CellEditFinishing);
			this.folvAnime.IsHyperlink += new System.EventHandler<BrightIdeasSoftware.IsHyperlinkEventArgs>(this.folvAnime_IsHyperlink);
			this.folvAnime.SelectionChanged += new System.EventHandler(this.folvAnime_SelectionChanged);
			// 
			// olvColTitle
			// 
			this.olvColTitle.AspectName = "Title";
			this.olvColTitle.Text = "Title";
			this.olvColTitle.UseInitialLetterForGroup = true;
			this.olvColTitle.Width = 110;
			// 
			// olvColName
			// 
			this.olvColName.AspectName = "Name";
			this.olvColName.MinimumWidth = 100;
			this.olvColName.Text = "Name";
			this.olvColName.UseInitialLetterForGroup = true;
			this.olvColName.Width = 100;
			// 
			// olvColReleaseDate
			// 
			this.olvColReleaseDate.AspectName = "ReleaseDate";
			this.olvColReleaseDate.IsEditable = false;
			this.olvColReleaseDate.MinimumWidth = 80;
			this.olvColReleaseDate.Text = "ReleaseDate";
			this.olvColReleaseDate.Width = 80;
			// 
			// olvColType
			// 
			this.olvColType.AspectName = "Type";
			this.olvColType.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColType.MinimumWidth = 48;
			this.olvColType.Text = "Type";
			this.olvColType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColType.Width = 48;
			// 
			// olvColFormat
			// 
			this.olvColFormat.AspectName = "Format";
			this.olvColFormat.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColFormat.MinimumWidth = 30;
			this.olvColFormat.Text = "Format";
			this.olvColFormat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColFormat.Width = 30;
			// 
			// olvColPublisher
			// 
			this.olvColPublisher.AspectName = "Publisher";
			this.olvColPublisher.MinimumWidth = 80;
			this.olvColPublisher.Text = "Publisher";
			this.olvColPublisher.Width = 80;
			// 
			// olvColSubStyle
			// 
			this.olvColSubStyle.AspectName = "SubStyle";
			this.olvColSubStyle.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColSubStyle.MinimumWidth = 45;
			this.olvColSubStyle.Text = "SubStyle";
			this.olvColSubStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColSubStyle.Width = 45;
			// 
			// olvColStoreIndex
			// 
			this.olvColStoreIndex.AspectName = "StoreIndex";
			this.olvColStoreIndex.Hyperlink = true;
			this.olvColStoreIndex.IsEditable = false;
			this.olvColStoreIndex.MinimumWidth = 100;
			this.olvColStoreIndex.Text = "StoreIndex";
			this.olvColStoreIndex.Width = 120;
			// 
			// olvColSpace
			// 
			this.olvColSpace.AspectName = "Space";
			this.olvColSpace.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.olvColSpace.IsEditable = false;
			this.olvColSpace.MinimumWidth = 60;
			this.olvColSpace.Text = "Space";
			this.olvColSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// olvColGather
			// 
			this.olvColGather.AspectName = "Gather";
			this.olvColGather.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColGather.MinimumWidth = 45;
			this.olvColGather.Text = "Gather";
			this.olvColGather.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColGather.Width = 45;
			// 
			// olvColView
			// 
			this.olvColView.AspectName = "View";
			this.olvColView.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColView.MinimumWidth = 45;
			this.olvColView.Text = "View";
			this.olvColView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColView.Width = 45;
			// 
			// olvColRate
			// 
			this.olvColRate.AspectName = "Rate";
			this.olvColRate.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColRate.MinimumWidth = 60;
			this.olvColRate.Text = "Rate";
			this.olvColRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// olvColNote
			// 
			this.olvColNote.AspectName = "Note";
			this.olvColNote.IsEditable = false;
			this.olvColNote.MinimumWidth = 130;
			this.olvColNote.Text = "Note";
			this.olvColNote.Width = 150;
			// 
			// hiStyle
			// 
			this.hiStyle.BackColor = System.Drawing.Color.PeachPuff;
			this.hiStyle.ForeColor = System.Drawing.Color.MediumBlue;
			// 
			// tpMusic
			// 
			this.tpMusic.Location = new System.Drawing.Point(4, 22);
			this.tpMusic.Name = "tpMusic";
			this.tpMusic.Padding = new System.Windows.Forms.Padding(3);
			this.tpMusic.Size = new System.Drawing.Size(852, 317);
			this.tpMusic.TabIndex = 1;
			this.tpMusic.Text = "Music";
			this.tpMusic.UseVisualStyleBackColor = true;
			// 
			// rtbAnime
			// 
			this.rtbAnime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbAnime.Location = new System.Drawing.Point(0, 0);
			this.rtbAnime.Name = "rtbAnime";
			this.rtbAnime.ReadOnly = true;
			this.rtbAnime.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtbAnime.Size = new System.Drawing.Size(860, 55);
			this.rtbAnime.TabIndex = 0;
			this.rtbAnime.Text = "";
			// 
			// cbGroups
			// 
			this.cbGroups.AutoSize = true;
			this.cbGroups.Location = new System.Drawing.Point(574, 7);
			this.cbGroups.Name = "cbGroups";
			this.cbGroups.Size = new System.Drawing.Size(78, 16);
			this.cbGroups.TabIndex = 9;
			this.cbGroups.Text = "To Groups";
			this.cbGroups.UseVisualStyleBackColor = true;
			this.cbGroups.CheckedChanged += new System.EventHandler(this.cbGroups_CheckedChanged);
			// 
			// tbFilter
			// 
			this.tbFilter.Location = new System.Drawing.Point(658, 5);
			this.tbFilter.Name = "tbFilter";
			this.tbFilter.Size = new System.Drawing.Size(100, 21);
			this.tbFilter.TabIndex = 0;
			this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
			// 
			// pnlTools
			// 
			this.pnlTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlTools.Controls.Add(this.cboFilter);
			this.pnlTools.Controls.Add(this.btnRemove);
			this.pnlTools.Controls.Add(this.btnPaste);
			this.pnlTools.Controls.Add(this.btnCopy);
			this.pnlTools.Controls.Add(this.btnModify);
			this.pnlTools.Controls.Add(this.btnAdd);
			this.pnlTools.Controls.Add(this.btnSave);
			this.pnlTools.Controls.Add(this.btnOpen);
			this.pnlTools.Controls.Add(this.btnChange);
			this.pnlTools.Controls.Add(this.btnNew);
			this.pnlTools.Controls.Add(this.cbGroups);
			this.pnlTools.Controls.Add(this.tbFilter);
			this.pnlTools.Location = new System.Drawing.Point(12, 0);
			this.pnlTools.Name = "pnlTools";
			this.pnlTools.Size = new System.Drawing.Size(860, 30);
			this.pnlTools.TabIndex = 0;
			// 
			// cboFilter
			// 
			this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFilter.FormattingEnabled = true;
			this.cboFilter.Items.AddRange(new object[] {
            "Prefix",
            "Any Text",
            "Regex"});
			this.cboFilter.Location = new System.Drawing.Point(764, 5);
			this.cboFilter.Name = "cboFilter";
			this.cboFilter.Size = new System.Drawing.Size(90, 20);
			this.cboFilter.TabIndex = 11;
			this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(395, 4);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(50, 23);
			this.btnRemove.TabIndex = 8;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnPaste
			// 
			this.btnPaste.Location = new System.Drawing.Point(339, 4);
			this.btnPaste.Name = "btnPaste";
			this.btnPaste.Size = new System.Drawing.Size(50, 23);
			this.btnPaste.TabIndex = 7;
			this.btnPaste.Text = "Paste";
			this.btnPaste.UseVisualStyleBackColor = true;
			this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
			// 
			// btnCopy
			// 
			this.btnCopy.Location = new System.Drawing.Point(283, 4);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(50, 23);
			this.btnCopy.TabIndex = 6;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// btnModify
			// 
			this.btnModify.Location = new System.Drawing.Point(227, 4);
			this.btnModify.Name = "btnModify";
			this.btnModify.Size = new System.Drawing.Size(50, 23);
			this.btnModify.TabIndex = 5;
			this.btnModify.Text = "Modify";
			this.btnModify.UseVisualStyleBackColor = true;
			this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(171, 4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(50, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(115, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(50, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(59, 4);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(50, 23);
			this.btnOpen.TabIndex = 2;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnChange
			// 
			this.btnChange.Location = new System.Drawing.Point(493, 4);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(75, 23);
			this.btnChange.TabIndex = 10;
			this.btnChange.Text = "Exchange";
			this.btnChange.UseVisualStyleBackColor = true;
			this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(3, 4);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(50, 23);
			this.btnNew.TabIndex = 1;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// scAnime
			// 
			this.scAnime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.scAnime.Location = new System.Drawing.Point(12, 36);
			this.scAnime.Name = "scAnime";
			this.scAnime.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scAnime.Panel1
			// 
			this.scAnime.Panel1.Controls.Add(this.tctlAnime);
			// 
			// scAnime.Panel2
			// 
			this.scAnime.Panel2.Controls.Add(this.rtbAnime);
			this.scAnime.Size = new System.Drawing.Size(860, 402);
			this.scAnime.SplitterDistance = 343;
			this.scAnime.TabIndex = 1;
			// 
			// ssAnime
			// 
			this.ssAnime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslSelected,
            this.tsslSelSpace,
            this.tsslTotal,
            this.tsslSpace});
			this.ssAnime.Location = new System.Drawing.Point(0, 441);
			this.ssAnime.Name = "ssAnime";
			this.ssAnime.Size = new System.Drawing.Size(884, 26);
			this.ssAnime.TabIndex = 2;
			// 
			// tsslSelected
			// 
			this.tsslSelected.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.tsslSelected.Name = "tsslSelected";
			this.tsslSelected.Size = new System.Drawing.Size(369, 21);
			this.tsslSelected.Spring = true;
			this.tsslSelected.Text = "Selected: ";
			// 
			// tsslSelSpace
			// 
			this.tsslSelSpace.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.tsslSelSpace.Name = "tsslSelSpace";
			this.tsslSelSpace.Size = new System.Drawing.Size(369, 21);
			this.tsslSelSpace.Spring = true;
			this.tsslSelSpace.Text = "Selected Space: ";
			// 
			// tsslTotal
			// 
			this.tsslTotal.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.tsslTotal.Name = "tsslTotal";
			this.tsslTotal.Size = new System.Drawing.Size(48, 21);
			this.tsslTotal.Text = "Total: ";
			// 
			// tsslSpace
			// 
			this.tsslSpace.Name = "tsslSpace";
			this.tsslSpace.Size = new System.Drawing.Size(83, 21);
			this.tsslSpace.Text = "Total Space: ";
			// 
			// AnimeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 467);
			this.Controls.Add(this.ssAnime);
			this.Controls.Add(this.scAnime);
			this.Controls.Add(this.pnlTools);
			this.Name = "AnimeForm";
			this.Text = "AnimeTrim";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimeForm_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnimeForm_FormClosed);
			this.tctlAnime.ResumeLayout(false);
			this.tpAnime.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.folvAnime)).EndInit();
			this.pnlTools.ResumeLayout(false);
			this.pnlTools.PerformLayout();
			this.scAnime.Panel1.ResumeLayout(false);
			this.scAnime.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scAnime)).EndInit();
			this.scAnime.ResumeLayout(false);
			this.ssAnime.ResumeLayout(false);
			this.ssAnime.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tctlAnime;
		private System.Windows.Forms.TabPage tpAnime;
		private System.Windows.Forms.TabPage tpMusic;
		private BrightIdeasSoftware.FastObjectListView folvAnime;
		private BrightIdeasSoftware.OLVColumn olvColTitle;
		private BrightIdeasSoftware.OLVColumn olvColName;
		private BrightIdeasSoftware.OLVColumn olvColReleaseDate;
		private BrightIdeasSoftware.OLVColumn olvColType;
		private BrightIdeasSoftware.OLVColumn olvColFormat;
		private BrightIdeasSoftware.OLVColumn olvColPublisher;
		private BrightIdeasSoftware.OLVColumn olvColSubStyle;
		private BrightIdeasSoftware.OLVColumn olvColStoreIndex;
		private BrightIdeasSoftware.OLVColumn olvColSpace;
		private BrightIdeasSoftware.OLVColumn olvColGather;
		private BrightIdeasSoftware.OLVColumn olvColView;
		private BrightIdeasSoftware.OLVColumn olvColRate;
		private BrightIdeasSoftware.OLVColumn olvColNote;
		private System.Windows.Forms.RichTextBox rtbAnime;
		private System.Windows.Forms.CheckBox cbGroups;
		private System.Windows.Forms.TextBox tbFilter;
		private System.Windows.Forms.Panel pnlTools;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.SplitContainer scAnime;
		private BrightIdeasSoftware.HotItemStyle hiStyle;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnModify;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Button btnPaste;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.ComboBox cboFilter;
		private System.Windows.Forms.StatusStrip ssAnime;
		private System.Windows.Forms.ToolStripStatusLabel tsslSelected;
		private System.Windows.Forms.ToolStripStatusLabel tsslSelSpace;
		private System.Windows.Forms.ToolStripStatusLabel tsslTotal;
		private System.Windows.Forms.ToolStripStatusLabel tsslSpace;

	}
}

