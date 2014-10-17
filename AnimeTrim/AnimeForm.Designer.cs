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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimeForm));
			this.tctlAnime = new System.Windows.Forms.TabControl();
			this.tpAnime = new System.Windows.Forms.TabPage();
			this.folvAnime = new BrightIdeasSoftware.FastObjectListView();
			this.olvColTitle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColReleaseDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColPublisher = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColStoreIndex = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColSpace = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColGather = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColView = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColNote = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.hiStyle = new BrightIdeasSoftware.HotItemStyle();
			this.tpMusic = new System.Windows.Forms.TabPage();
			this.rtbAnime = new System.Windows.Forms.RichTextBox();
			this.scAnime = new System.Windows.Forms.SplitContainer();
			this.ssAnime = new System.Windows.Forms.StatusStrip();
			this.tsslSelected = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslSelSpace = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslTotal = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslSpace = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsMain = new System.Windows.Forms.ToolStrip();
			this.btnNew = new System.Windows.Forms.ToolStripButton();
			this.btnOpen = new System.Windows.Forms.ToolStripButton();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.tsSepForFile = new System.Windows.Forms.ToolStripSeparator();
			this.btnAdd = new System.Windows.Forms.ToolStripButton();
			this.btnModify = new System.Windows.Forms.ToolStripButton();
			this.tsBtnDuplicate = new System.Windows.Forms.ToolStripButton();
			this.btnDel = new System.Windows.Forms.ToolStripButton();
			this.tsSepForEdit = new System.Windows.Forms.ToolStripSeparator();
			this.tssBtnMore = new System.Windows.Forms.ToolStripSplitButton();
			this.tsMenItmFormat = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenItmBackup = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMore = new System.Windows.Forms.ToolStrip();
			this.tsDropDnBtnGroup = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsSepForGroup = new System.Windows.Forms.ToolStripSeparator();
			this.cboFilter = new System.Windows.Forms.ToolStripComboBox();
			this.tbFilter = new System.Windows.Forms.ToolStripTextBox();
			this.tctlAnime.SuspendLayout();
			this.tpAnime.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.folvAnime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scAnime)).BeginInit();
			this.scAnime.Panel1.SuspendLayout();
			this.scAnime.Panel2.SuspendLayout();
			this.scAnime.SuspendLayout();
			this.ssAnime.SuspendLayout();
			this.tsMain.SuspendLayout();
			this.tsMore.SuspendLayout();
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
			this.tctlAnime.Size = new System.Drawing.Size(868, 331);
			this.tctlAnime.TabIndex = 0;
			// 
			// tpAnime
			// 
			this.tpAnime.Controls.Add(this.folvAnime);
			this.tpAnime.Location = new System.Drawing.Point(4, 22);
			this.tpAnime.Name = "tpAnime";
			this.tpAnime.Padding = new System.Windows.Forms.Padding(3);
			this.tpAnime.Size = new System.Drawing.Size(860, 305);
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
			this.folvAnime.AllColumns.Add(this.olvColPublisher);
			this.folvAnime.AllColumns.Add(this.olvColStoreIndex);
			this.folvAnime.AllColumns.Add(this.olvColSpace);
			this.folvAnime.AllColumns.Add(this.olvColGather);
			this.folvAnime.AllColumns.Add(this.olvColView);
			this.folvAnime.AllColumns.Add(this.olvColRate);
			this.folvAnime.AllColumns.Add(this.olvColNote);
			this.folvAnime.AllowColumnReorder = true;
			this.folvAnime.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.folvAnime.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
			this.folvAnime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColTitle,
            this.olvColName,
            this.olvColReleaseDate,
            this.olvColType,
            this.olvColPublisher,
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
			this.folvAnime.Size = new System.Drawing.Size(854, 299);
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
			this.olvColTitle.MinimumWidth = 130;
			this.olvColTitle.Text = "Title";
			this.olvColTitle.UseInitialLetterForGroup = true;
			this.olvColTitle.Width = 130;
			// 
			// olvColName
			// 
			this.olvColName.AspectName = "Name";
			this.olvColName.MinimumWidth = 120;
			this.olvColName.Text = "Name";
			this.olvColName.UseInitialLetterForGroup = true;
			this.olvColName.Width = 120;
			// 
			// olvColReleaseDate
			// 
			this.olvColReleaseDate.AspectName = "ReleaseDate";
			this.olvColReleaseDate.IsEditable = false;
			this.olvColReleaseDate.MinimumWidth = 80;
			this.olvColReleaseDate.Text = "Schedule";
			this.olvColReleaseDate.Width = 80;
			// 
			// olvColType
			// 
			this.olvColType.AspectName = "Type";
			this.olvColType.MinimumWidth = 60;
			this.olvColType.Text = "Type";
			// 
			// olvColPublisher
			// 
			this.olvColPublisher.AspectName = "Publisher";
			this.olvColPublisher.MinimumWidth = 100;
			this.olvColPublisher.Text = "Subtitle";
			this.olvColPublisher.Width = 100;
			// 
			// olvColStoreIndex
			// 
			this.olvColStoreIndex.AspectName = "StoreIndex";
			this.olvColStoreIndex.Hyperlink = true;
			this.olvColStoreIndex.IsEditable = false;
			this.olvColStoreIndex.MinimumWidth = 100;
			this.olvColStoreIndex.Text = "Path";
			this.olvColStoreIndex.Width = 120;
			// 
			// olvColSpace
			// 
			this.olvColSpace.AspectName = "Space";
			this.olvColSpace.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.olvColSpace.IsEditable = false;
			this.olvColSpace.MinimumWidth = 60;
			this.olvColSpace.Text = "Size";
			this.olvColSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// olvColGather
			// 
			this.olvColGather.AspectName = "Gather";
			this.olvColGather.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColGather.MinimumWidth = 45;
			this.olvColGather.Text = "Store";
			this.olvColGather.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColGather.Width = 45;
			// 
			// olvColView
			// 
			this.olvColView.AspectName = "View";
			this.olvColView.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColView.MinimumWidth = 45;
			this.olvColView.Text = "Enjoy";
			this.olvColView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColView.Width = 45;
			// 
			// olvColRate
			// 
			this.olvColRate.AspectName = "Rate";
			this.olvColRate.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColRate.MinimumWidth = 60;
			this.olvColRate.Text = "Grade";
			this.olvColRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// olvColNote
			// 
			this.olvColNote.AspectName = "Note";
			this.olvColNote.IsEditable = false;
			this.olvColNote.MinimumWidth = 200;
			this.olvColNote.Text = "Note";
			this.olvColNote.Width = 200;
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
			this.tpMusic.Size = new System.Drawing.Size(860, 305);
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
			this.rtbAnime.Size = new System.Drawing.Size(868, 54);
			this.rtbAnime.TabIndex = 0;
			this.rtbAnime.Text = "";
			// 
			// scAnime
			// 
			this.scAnime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.scAnime.Location = new System.Drawing.Point(12, 53);
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
			this.scAnime.Size = new System.Drawing.Size(868, 389);
			this.scAnime.SplitterDistance = 331;
			this.scAnime.TabIndex = 2;
			// 
			// ssAnime
			// 
			this.ssAnime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslSelected,
            this.tsslSelSpace,
            this.tsslTotal,
            this.tsslSpace});
			this.ssAnime.Location = new System.Drawing.Point(0, 445);
			this.ssAnime.Name = "ssAnime";
			this.ssAnime.Size = new System.Drawing.Size(892, 26);
			this.ssAnime.TabIndex = 3;
			// 
			// tsslSelected
			// 
			this.tsslSelected.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.tsslSelected.Name = "tsslSelected";
			this.tsslSelected.Size = new System.Drawing.Size(373, 21);
			this.tsslSelected.Spring = true;
			this.tsslSelected.Text = "Selected: ";
			// 
			// tsslSelSpace
			// 
			this.tsslSelSpace.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.tsslSelSpace.Name = "tsslSelSpace";
			this.tsslSelSpace.Size = new System.Drawing.Size(373, 21);
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
			// tsMain
			// 
			this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.tsSepForFile,
            this.btnAdd,
            this.btnModify,
            this.tsBtnDuplicate,
            this.btnDel,
            this.tsSepForEdit,
            this.tssBtnMore});
			this.tsMain.Location = new System.Drawing.Point(0, 0);
			this.tsMain.Name = "tsMain";
			this.tsMain.Size = new System.Drawing.Size(892, 25);
			this.tsMain.TabIndex = 1;
			this.tsMain.Text = "tsMain";
			// 
			// btnNew
			// 
			this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
			this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(23, 22);
			this.btnNew.Text = "New";
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
			this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(23, 22);
			this.btnOpen.Text = "Open";
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnSave
			// 
			this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(23, 22);
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tsSepForFile
			// 
			this.tsSepForFile.Name = "tsSepForFile";
			this.tsSepForFile.Size = new System.Drawing.Size(6, 25);
			// 
			// btnAdd
			// 
			this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(23, 22);
			this.btnAdd.Text = "Add";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnModify
			// 
			this.btnModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
			this.btnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnModify.Name = "btnModify";
			this.btnModify.Size = new System.Drawing.Size(23, 22);
			this.btnModify.Text = "Modify";
			this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
			// 
			// tsBtnDuplicate
			// 
			this.tsBtnDuplicate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsBtnDuplicate.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDuplicate.Image")));
			this.tsBtnDuplicate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsBtnDuplicate.Name = "tsBtnDuplicate";
			this.tsBtnDuplicate.Size = new System.Drawing.Size(23, 22);
			this.tsBtnDuplicate.Text = "Duplicate";
			this.tsBtnDuplicate.Click += new System.EventHandler(this.tsBtnDuplicate_Click);
			// 
			// btnDel
			// 
			this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
			this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(23, 22);
			this.btnDel.Text = "Delete";
			this.btnDel.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// tsSepForEdit
			// 
			this.tsSepForEdit.Name = "tsSepForEdit";
			this.tsSepForEdit.Size = new System.Drawing.Size(6, 25);
			// 
			// tssBtnMore
			// 
			this.tssBtnMore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tssBtnMore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenItmFormat,
            this.tsMenItmBackup});
			this.tssBtnMore.Image = ((System.Drawing.Image)(resources.GetObject("tssBtnMore.Image")));
			this.tssBtnMore.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tssBtnMore.Name = "tssBtnMore";
			this.tssBtnMore.Size = new System.Drawing.Size(32, 22);
			this.tssBtnMore.Text = "More";
			// 
			// tsMenItmFormat
			// 
			this.tsMenItmFormat.Name = "tsMenItmFormat";
			this.tsMenItmFormat.Size = new System.Drawing.Size(119, 22);
			this.tsMenItmFormat.Text = "Format";
			this.tsMenItmFormat.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// tsMenItmBackup
			// 
			this.tsMenItmBackup.Name = "tsMenItmBackup";
			this.tsMenItmBackup.Size = new System.Drawing.Size(119, 22);
			this.tsMenItmBackup.Text = "Backup";
			// 
			// tsMore
			// 
			this.tsMore.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDropDnBtnGroup,
            this.tsSepForGroup,
            this.cboFilter,
            this.tbFilter});
			this.tsMore.Location = new System.Drawing.Point(0, 25);
			this.tsMore.Name = "tsMore";
			this.tsMore.Size = new System.Drawing.Size(892, 25);
			this.tsMore.TabIndex = 0;
			this.tsMore.Text = "tsMore";
			// 
			// tsDropDnBtnGroup
			// 
			this.tsDropDnBtnGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsDropDnBtnGroup.Image = ((System.Drawing.Image)(resources.GetObject("tsDropDnBtnGroup.Image")));
			this.tsDropDnBtnGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsDropDnBtnGroup.Name = "tsDropDnBtnGroup";
			this.tsDropDnBtnGroup.Size = new System.Drawing.Size(29, 22);
			this.tsDropDnBtnGroup.Text = "Group";
			this.tsDropDnBtnGroup.Click += new System.EventHandler(this.cbGroups_CheckedChanged);
			// 
			// tsSepForGroup
			// 
			this.tsSepForGroup.Name = "tsSepForGroup";
			this.tsSepForGroup.Size = new System.Drawing.Size(6, 25);
			// 
			// cboFilter
			// 
			this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFilter.Items.AddRange(new object[] {
            "Prefix",
            "Any Text",
            "Regex"});
			this.cboFilter.Name = "cboFilter";
			this.cboFilter.Size = new System.Drawing.Size(120, 25);
			this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
			// 
			// tbFilter
			// 
			this.tbFilter.Name = "tbFilter";
			this.tbFilter.Size = new System.Drawing.Size(150, 25);
			this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
			// 
			// AnimeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(892, 471);
			this.Controls.Add(this.tsMore);
			this.Controls.Add(this.tsMain);
			this.Controls.Add(this.ssAnime);
			this.Controls.Add(this.scAnime);
			this.Name = "AnimeForm";
			this.Text = "AnimeTrim";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimeForm_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnimeForm_FormClosed);
			this.tctlAnime.ResumeLayout(false);
			this.tpAnime.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.folvAnime)).EndInit();
			this.scAnime.Panel1.ResumeLayout(false);
			this.scAnime.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scAnime)).EndInit();
			this.scAnime.ResumeLayout(false);
			this.ssAnime.ResumeLayout(false);
			this.ssAnime.PerformLayout();
			this.tsMain.ResumeLayout(false);
			this.tsMain.PerformLayout();
			this.tsMore.ResumeLayout(false);
			this.tsMore.PerformLayout();
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
		private BrightIdeasSoftware.OLVColumn olvColPublisher;
		private BrightIdeasSoftware.OLVColumn olvColStoreIndex;
		private BrightIdeasSoftware.OLVColumn olvColSpace;
		private BrightIdeasSoftware.OLVColumn olvColGather;
		private BrightIdeasSoftware.OLVColumn olvColView;
		private BrightIdeasSoftware.OLVColumn olvColRate;
		private BrightIdeasSoftware.OLVColumn olvColNote;
		private System.Windows.Forms.RichTextBox rtbAnime;
		private System.Windows.Forms.SplitContainer scAnime;
		private BrightIdeasSoftware.HotItemStyle hiStyle;
		private System.Windows.Forms.StatusStrip ssAnime;
		private System.Windows.Forms.ToolStripStatusLabel tsslSelected;
		private System.Windows.Forms.ToolStripStatusLabel tsslSelSpace;
		private System.Windows.Forms.ToolStripStatusLabel tsslTotal;
		private System.Windows.Forms.ToolStripStatusLabel tsslSpace;
		private System.Windows.Forms.ToolStrip tsMain;
		private System.Windows.Forms.ToolStripButton btnNew;
		private System.Windows.Forms.ToolStripButton btnOpen;
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.ToolStripSeparator tsSepForFile;
		private System.Windows.Forms.ToolStripButton btnAdd;
		private System.Windows.Forms.ToolStripButton btnModify;
		private System.Windows.Forms.ToolStripButton btnDel;
		private System.Windows.Forms.ToolStripSeparator tsSepForEdit;
		private System.Windows.Forms.ToolStripSplitButton tssBtnMore;
		private System.Windows.Forms.ToolStripMenuItem tsMenItmFormat;
		private System.Windows.Forms.ToolStripMenuItem tsMenItmBackup;
		private System.Windows.Forms.ToolStrip tsMore;
		private System.Windows.Forms.ToolStripDropDownButton tsDropDnBtnGroup;
		private System.Windows.Forms.ToolStripSeparator tsSepForGroup;
		private System.Windows.Forms.ToolStripComboBox cboFilter;
		private System.Windows.Forms.ToolStripTextBox tbFilter;
		private System.Windows.Forms.ToolStripButton tsBtnDuplicate;

	}
}

