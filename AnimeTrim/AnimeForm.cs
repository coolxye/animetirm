﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using BrightIdeasSoftware;
using System.Diagnostics;

namespace AnimeTrim
{
	public partial class AnimeForm : Form
	{
		public AnimeForm()
		{
			InitializeComponent();

			//if (FastObjectListView.IsVistaOrLater)
			//    this.Font = new Font("Segoe UI", 8);

			// edit 13/1/8 for bug3
			InitAnimeData();
			// edit fin
			InitBtn();
			InitModel();
			InitAccessFile();
		}

		// FileStream for the Anime Doc
		//private FileStream _fs = null;
		private AnimeInfo _ai = new AnimeInfo();
		// Temporary AnimeInfo for the wrong read
		private AnimeInfo _aitp = new AnimeInfo();
		private List<Anime> _lani = new List<Anime>();
		// Temporary Anime lists for the wrong read
		private List<Anime> _latp = new List<Anime>();

		// Sort the list
		private static int AnimeComparer(Anime x, Anime y)
		{
			// edit 13/1/10 for fun2 Stop
			//if (x.Title == y.Title)
			//    return String.Compare(x.StoreIndex, y.StoreIndex, StringComparison.InvariantCultureIgnoreCase);
			// edit fin

			return String.Compare(x.Title, y.Title, StringComparison.InvariantCultureIgnoreCase);
		}

		// edit 13/1/8 for bug3
		// Initalize the anime datas
		private void InitAnimeData()
		{
			_ai.Path = null;
			_ai.Name = null;
			_ai.Total = 0;
			_ai.Space = 0L;
			_ai.IsNew = true;
			_ai.IsSaved = true;
		}
		// edit fin

		// Initalize the buttons
		private void InitBtn()
		{
			this.btnSave.Enabled = false;
			this.btnModify.Enabled = false;
			this.btnCopy.Enabled = false;
			this.btnPaste.Enabled = false;
			this.btnDel.Enabled = false;
		}

		// Initalize the path and name of AnimeInfo from a xml
		private void InitAccessFile()
		{
			if (!File.Exists(@".\AnimeTrim.xml"))
				return;

			XPathDocument xptdoc = new XPathDocument(@".\AnimeTrim.xml");
			XPathNavigator xptnavi = xptdoc.CreateNavigator();

			XPathNavigator xt = xptnavi.SelectSingleNode("//LastAccessName");
			if (xt != null && xt.Value != "")
				_aitp.Name = xt.Value;
			else return;

			xt = xptnavi.SelectSingleNode("//LastAccessPath");
			if (xt != null && xt.Value != "" && File.Exists(xt.Value))
				_aitp.Path = xt.Value;
			else return;

			if (ReadAnimeDoc())
				BindData();
		}

		// Read file to initalize the list of Anime
		private bool ReadAnimeDoc()
		{
			Anime ani;
			string line;
			string[] info;
			StreamReader sr = new StreamReader(_aitp.Path);

			//_fs = new FileStream(_aitp.Path, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
			//sr = new StreamReader(_fs);

			int it;
			if (!Int32.TryParse(sr.ReadLine(), out it))
			{
				MessageBox.Show(this, "The line 1 is wrong.", "Read error",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				sr.Close();

				return false;
			}
			else _aitp.Total = it;

			long lt;
			if (!Int64.TryParse(sr.ReadLine(), out lt))
			{
				MessageBox.Show(this, "The line 2 is wrong.", "Read error",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				sr.Close();

				return false;
			}
			else _aitp.Space = lt;

			it = 2;
			try
			{
				while ((line = sr.ReadLine()) != null)
				{
					it++;
					info = line.Split('\t');

					ani = new Anime();
					ani.Title = info[0];
					ani.Name = info[1];
					ani.Year = Int32.Parse(info[2]);
					ani.Season = info[3];
					ani.Type = (MediaType)Enum.Parse(typeof(MediaType), info[4]);
					ani.Format = (MergeFormat)Enum.Parse(typeof(MergeFormat), info[5]);
					ani.Publisher = info[6];
					ani.SubStyle = (SubStyles)Enum.Parse(typeof(SubStyles), info[7]);
					ani.StoreIndex = info[8];
					ani.Space = Int64.Parse(info[9]);
					ani.Gather = Boolean.Parse(info[10]);
					ani.View = Boolean.Parse(info[11]);
					ani.Rate = Int32.Parse(info[12]);
					ani.CreateTime = DateTime.Parse(info[13]);
					ani.UpdateTime = DateTime.Parse(info[14]);
					ani.Kana = info[15];
					ani.Episode = info[16];
					ani.Note = info[17];

					_latp.Add(ani);
				}
			}
			catch (Exception)
			{
				MessageBox.Show(this, String.Format("The line {0} is wrong.", it), "Read error",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				_latp.Clear();

				return false;
			}
			finally
			{
				sr.Close();
			}

			_aitp.IsNew = false;
			_aitp.IsSaved = true;

			return true;
		}

		// Initalize the Format of the FastObjectView
		private void InitModel()
		{
			TypedObjectListView<Anime> tolv = new TypedObjectListView<Anime>(this.folvAnime);
			tolv.GenerateAspectGetters();

			// Name of Anime
			TypedColumn<Anime> tc = new TypedColumn<Anime>(this.olvColName);
			tc.AspectPutter = delegate(Anime a, object opn) { a.Name = opn.ToString(); };

			// ReleaseDate of Anime
			tc = new TypedColumn<Anime>(this.olvColReleaseDate);
			tc.GroupKeyGetter = delegate(Anime a) { return a.Year; };

			//TODO: add images to Type of Anime
			// Type of Anime
			tc = new TypedColumn<Anime>(this.olvColType);
			tc.AspectPutter = delegate(Anime a, object opt) { a.Type = (MediaType)opt; };

			// Format of Anime
			this.olvColFormat.Renderer = new MappedImageRenderer(new object[] {
				MergeFormat.MKV, Properties.Resources.MKV,
				MergeFormat.MP4, Properties.Resources.MP4,
				MergeFormat.AVI, Properties.Resources.AVI,
				MergeFormat.WMV, Properties.Resources.WMV,
				MergeFormat.M2TS, Properties.Resources.M2TS
			});
			tc = new TypedColumn<Anime>(this.olvColFormat);
			tc.AspectPutter = delegate(Anime a, object opf) { a.Format = (MergeFormat)opf; };

			// Publisher of Anime
			tc = new TypedColumn<Anime>(this.olvColPublisher);
			tc.AspectPutter = delegate(Anime a, object opp) { a.Publisher = opp.ToString(); };

			// SubStyle of Anime
			this.olvColSubStyle.Renderer = new MappedImageRenderer(new object[] {
				SubStyles.External, Properties.Resources.External,
				SubStyles.Sealed, Properties.Resources.Sealed,
				SubStyles.Embedded, Properties.Resources.Embedded
			});
			tc = new TypedColumn<Anime>(this.olvColSubStyle);
			tc.AspectPutter = delegate(Anime a, object ops) { a.SubStyle = (SubStyles)ops; };

			// Space of Anime
			this.olvColSpace.AspectToStringConverter = delegate(object ots)
			{
				long ls = (long)ots;

				if (ls >= 1000000000L)
					return String.Format("{0:#,##0.#0} G", ls / 1073741824D);
				else return String.Format("{0:#,##0.#0} M", ls / 1048576D);
			};
			this.olvColSpace.MakeGroupies(
				new long[] { 5368709120L, 10737418240L },
				new string[] { "0~5 GB", "5~10 GB", "10~ GB" }
				);

			// Gather of Anime
			tc = new TypedColumn<Anime>(this.olvColGather);
			tc.AspectPutter = delegate(Anime a, object opg) { a.Gather = (bool)opg; };
			this.olvColGather.Renderer = new MappedImageRenderer(true, Properties.Resources.Yes, false, Properties.Resources.No);

			// View of Anime
			tc = new TypedColumn<Anime>(this.olvColView);
			tc.AspectPutter = delegate(Anime a, object opv) { a.View = (bool)opv; };
			this.olvColView.Renderer = new MappedImageRenderer(true, Properties.Resources.Smile, false, Properties.Resources.Sad);

			// Rate of Anime
			tc = new TypedColumn<Anime>(this.olvColRate);
			tc.AspectPutter = delegate(Anime a, object opr)
			{
				int onr = (int)opr;
				a.Rate = onr < 10 ? 10 : onr;
			};
			this.olvColRate.Renderer = new MultiImageRenderer(Properties.Resources.Star, 3, 9, 31);
			this.olvColRate.MakeGroupies(
				new int[] { 20, 30 },
				new string[] { "Normal", "Nice", "Good" }
				);

			// Note of Anime
			this.olvColNote.AspectToStringConverter = delegate(object otn)
			{
				return otn.ToString().Replace('\u0002', '\u0020');
			};

			this.folvAnime.HotItemStyle.Overlay = new AnimeViewOverlay();
			this.folvAnime.HotItemStyle = this.folvAnime.HotItemStyle;
		}

		// Initalize the model data of Anime to the FastObjectListView
		private void BindData()
		{
			_ai = _aitp;
			_latp.ForEach(delegate(Anime a) { _lani.Add(a); });
			// edit 13/1/7 for bug2
			_latp.Clear();
			// edit fin

			//if (_sr != null)
			//	_sr.Close();

			//_sr = new StreamReader(_ai.Path);

			this.folvAnime.SetObjects(_lani);

			this.tctlAnime.SelectedTab.Text = _ai.Name;
			this.tctlAnime.SelectedTab.ToolTipText = _ai.Path;
			this.tsslTotal.Text = String.Format("Total: {0}", _ai.Total);
			this.tsslSpace.Text = String.Format("Total Space: {0:#,##0.#0} GB", _ai.Space / 1073741824D);
		}

		private void UpdateAnimeDoc()
		{
			StreamWriter sw = new StreamWriter(_ai.Path, false, Encoding.Unicode);
			//StreamWriter sw = new StreamWriter(_fs, Encoding.Unicode);

			sw.WriteLine(_ai.Total);
			sw.WriteLine(_ai.Space);

			_lani.ForEach(delegate(Anime a)
			{
				sw.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}\t{14}\t{15}\t{16}\t{17}",
					a.Title, a.Name, a.Year, a.Season, a.Type, a.Format,
					a.Publisher, a.SubStyle, a.StoreIndex, a.Space, a.Gather,
					a.View, a.Rate, a.CreateTime, a.UpdateTime, a.Kana,
					a.Episode, a.Note);
			});

			sw.Close();
		}

		private void ResetAll()
		{
			// AnimeInfo reset
			_ai.Path = null;
			_ai.Name = null;
			_ai.Total = 0;
			_ai.Space = 0L;
			_ai.IsNew = true;
			_ai.IsSaved = true;

			// List<Anime> reset
			_lani.Clear();

			// Tab reset
			switch (this.tctlAnime.SelectedIndex)
			{
				case 0: this.tpAnime.Text = "Anime"; this.tpAnime.ToolTipText = ""; break;
				case 1: this.tpMusic.Text = "Music"; break;
			}

			// FastObjectListView & RichTextBox reset
			this.folvAnime.ClearObjects();
			this.rtbAnime.ResetText();

			// Button reset
			this.btnSave.Enabled = false;
			this.btnModify.Enabled = false;
			this.btnCopy.Enabled = false;
			this.btnDel.Enabled = false;

			// StatusStrip reset
			this.tsslSelected.Text = "Selected: ";
			this.tsslSelSpace.Text = "Selected Space: ";
			this.tsslTotal.Text = "Total: ";
			this.tsslSpace.Text = "Total Space: ";
		}

		// edit 13/1/9 for bug3
		private bool SaveCheck()
		{
			if (_ai.IsSaved)
				return true;

			DialogResult dr;
			dr = MessageBox.Show(this, "Save current Anime?", "Save",
				MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

			if (dr == DialogResult.Yes)
				return SaveData();
			else if (dr == DialogResult.No)
				return true;
			else
				return false;
		}

		private bool SaveData()
		{
			if (!_ai.IsNew)
			{
				UpdateAnimeDoc();
				_ai.IsSaved = true;
				this.btnSave.Enabled = false;

				return true;
			}

			const string strFilter = "AnimeTrim Files|*.xat";
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = strFilter;

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				_ai.Path = sfd.FileName;
				_ai.Name = Path.GetFileName(_ai.Path);
				_ai.IsNew = false;
				_ai.IsSaved = true;

				UpdateAnimeDoc();
				this.btnSave.Enabled = false;

				return true;
			}
			else
				return false;
		}
		// edit fin

		private void folvAnime_SelectionChanged(object sender, EventArgs e)
		{
			Anime a = this.folvAnime.SelectedObject as Anime;

			if (a != null)
			{
				this.tsslSelected.Text = String.Format("Selected: {0}", a.Name);
				this.tsslSelSpace.Text = (a.Space >= 1000000000L) ? String.Format("Selected Space: {0:#,##0.#0} GB", a.Space / 1073741824D) :
					String.Format("Selected Space: {0:#,##0.#0} MB", a.Space / 1048576D);

				this.rtbAnime.Text = a.Remarks();
				this.btnModify.Enabled = true;
				this.btnCopy.Enabled = true;
				this.btnDel.Enabled = true;
			}
			else
			{
				this.tsslSelected.Text = String.Format("Selected: {0}", this.folvAnime.SelectedIndices.Count);

				long ls = 0L;
				foreach (Anime at in this.folvAnime.SelectedObjects)
				{
					ls += at.Space;
				}
				this.tsslSelSpace.Text = (ls >= 1000000000L) ? String.Format("Selected Space: {0:#,##0.#0} GB", ls / 1073741824D) :
					String.Format("Selected Space: {0:#,##0.#0} MB", ls / 1048576D);

				this.rtbAnime.ResetText();
				this.btnModify.Enabled = false;
				this.btnCopy.Enabled = false;
				this.btnDel.Enabled = false;
			}
		}

		private void cbGroups_CheckedChanged(object sender, EventArgs e)
		{
			if (FastObjectListView.IsVistaOrLater)
			{
				this.folvAnime.ShowGroups = !this.folvAnime.ShowGroups;
				this.folvAnime.BuildList();
			}
		}

		private void TimedFilter(FastObjectListView folv, string txt, int matchKind)
		{
			TextMatchFilter filter = null;
			if (!String.IsNullOrEmpty(txt))
			{
				switch (matchKind)
				{
					case 0:
					default:
						filter = TextMatchFilter.Prefix(folv, txt);
						break;
					case 1:
						filter = TextMatchFilter.Contains(folv, txt);
						break;
					case 2:
						filter = TextMatchFilter.Regex(folv, txt);
						break;
				}
			}
			// Setup a default renderer to draw the filter matches
			if (filter == null)
				folv.DefaultRenderer = null;
			else
				folv.DefaultRenderer = new HighlightTextRenderer(filter);

			// Some lists have renderers already installed
			HighlightTextRenderer highlightingRenderer = folv.GetColumn(0).Renderer as HighlightTextRenderer;
			if (highlightingRenderer != null)
				highlightingRenderer.Filter = filter;

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			folv.ModelFilter = filter;
			stopWatch.Stop();
		}

		private void tbFilter_TextChanged(object sender, EventArgs e)
		{
			this.TimedFilter(this.folvAnime, this.tbFilter.Text, this.cboFilter.SelectedIndex);
		}

		private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.tbFilter_TextChanged(null, null);
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			// edit 13/1/9 for bug3
			//if (!_ai.IsSaved)
			//{
			//    DialogResult dr;
			//    dr = MessageBox.Show(this, "Save current Anime?", "Save",
			//        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			//    if (dr == DialogResult.Yes)
			//        btnSave_Click(null, null);
			//}
			if (!SaveCheck())
				return;
			// edit fin

			if (!_ai.IsNew)
				ResetAll();
		}

		// TODO: delete before final
		private void btnChange_Click(object sender, EventArgs e)
		{
			const string path = @"E:\Documents\AnimeDoc.at";

			List<Anime> lani = new List<Anime>();

			StreamReader sr = new StreamReader(path);
			int total = Int32.Parse(sr.ReadLine());
			long dspace = (Int64)(Double.Parse(sr.ReadLine()) * 1073741824D + 0.5D);

			string title;
			string name;
			int year;
			string season;
			MediaType type;
			MergeFormat format;
			string publisher;
			SubStyles subStyle;
			string storeIndex;
			long space;
			bool gather;
			bool view;
			int rate;
			DateTime createTime;
			DateTime updateTime;
			string kana;
			string episode;
			string note;

			string line;
			string[] info;
			string[] date;
			int i = 10;

			while ((line = sr.ReadLine()) != null)
			{
				info = line.Split('\t');

				title = info[0]; name = info[1];
				date = info[2].Split('.');
				year = Int32.Parse(date[0]);
				season = date[1];

				switch (info[3])
				{
					case "BDRip": type = MediaType.BDRip; break;
					case "DVDRip": type = MediaType.DVDRip; break;
					case "BDRAW": type = MediaType.BDRAW; break;
					case "DVDRAW": type = MediaType.DVDRAW; break;
					case "BDMV": type = MediaType.BDMV; break;
					case "TVRip": type = MediaType.TVRip; break;
					default: type = MediaType.DVDRip; break;
				}

				switch (info[4])
				{
					case "MKV": format = MergeFormat.MKV; break;
					case "MP4": format = MergeFormat.MP4; break;
					case "M2TS": format = MergeFormat.M2TS; break;
					case "WMV": format = MergeFormat.WMV; break;
					case "AVI": format = MergeFormat.AVI; break;
					default: format = MergeFormat.MKV; break;
				}

				publisher = info[5];

				switch (info[6])
				{
					case "External": subStyle = SubStyles.External; break;
					case "Sealed": subStyle = SubStyles.Sealed; break;
					case "Embedded": subStyle = SubStyles.Embedded; break;
					default: subStyle = SubStyles.External; break;
				}

				storeIndex = info[7];

				space = (Int64)(Double.Parse(info[8]) * 1073741824D + 0.5D);

				gather = (info[9] == "Fin.") ? true : false;

				view = (info[10] == "^-^") ? true : false;

				rate = i++;

				if (i > 40) i = 10;

				createTime = DateTime.Now;

				updateTime = DateTime.Now;

				kana = info[11];

				episode = "12";

				note = info[12];

				lani.Add(new Anime(title, name, year, season, type, format,
					publisher, subStyle, storeIndex, space, gather, view,
					rate, createTime, updateTime, kana, episode, note));
			}

			sr.Close();

			StreamWriter sw = new StreamWriter(@"AnimeDoc.txt", false, Encoding.Unicode);
			sw.WriteLine(total); sw.WriteLine(dspace);

			foreach (Anime ani in lani)
			{
				sw.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}\t{14}\t{15}\t{16}\t{17}",
					ani.Title, ani.Name, ani.Year, ani.Season, ani.Type, ani.Format,
					ani.Publisher, ani.SubStyle, ani.StoreIndex, ani.Space, ani.Gather,
					ani.View, ani.Rate, ani.CreateTime, ani.UpdateTime, ani.Kana,
					ani.Episode, ani.Note);
			}

			sw.Close();
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			// edit 13/1/9 for bug3
			//if (!_ai.IsSaved)
			//{
			//    DialogResult dr;
			//    dr = MessageBox.Show(this, "Save current Anime?", "Save",
			//        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

			//    if (dr == DialogResult.Yes)
			//        btnSave_Click(null, null);
			//    else if (dr == DialogResult.Cancel)
			//        return;
			//}
			if (!SaveCheck())
				return;
			// edit fin

			const string strFilter = "AnimeTrim Files|*.xat";
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = strFilter;

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				if (_ai.Path == ofd.FileName)
					return;

				_aitp.Path = ofd.FileName;
				_aitp.Name = ofd.SafeFileName;

				if (ReadAnimeDoc())
				{
					if (!_ai.IsNew)
						ResetAll();

					BindData();
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// edit 13/1/9 for bug3
			//if (!_ai.IsNew)
			//{
			//    UpdateAnimeDoc();
			//    _ai.IsSaved = true;
			//    this.btnSave.Enabled = false;

			//    return;
			//}

			//const string strFilter = "AnimeTrim Files|*.xat";
			//SaveFileDialog sfd = new SaveFileDialog();
			//sfd.Filter = strFilter;

			//if (sfd.ShowDialog() == DialogResult.OK)
			//{
			//    _ai.Path = sfd.FileName;
			//    _ai.Name = Path.GetFileName(_ai.Path);
			//    _ai.IsNew = false;
			//    _ai.IsSaved = true;

			//    UpdateAnimeDoc();
			//    this.btnSave.Enabled = false;
			//}
			SaveData();
			// edit fin
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			AddForm af = new AddForm();
			af.StartPosition = FormStartPosition.CenterParent;
			af.MaximizeBox = false;

			if (af.ShowDialog(this) == DialogResult.OK)
			{
				Anime a = af.GetAnime();
				_ai.Space += a.Space;
				_ai.Total++;
				_ai.IsSaved = false;
				_lani.Add(a);
				_lani.Sort(AnimeComparer);

				this.folvAnime.AddObject(a);
				this.folvAnime.Sort(0);
				this.folvAnime.Unsort();

				this.folvAnime.SelectedObject = a;
				this.folvAnime.SelectedItem.EnsureVisible();
				// TODO: 需修正工具栏
				this.folvAnime.Focus();
				this.tsslTotal.Text = String.Format("Total: {0}", _ai.Total);
				this.tsslSpace.Text = String.Format("Total Space: {0:#,##0.#0} GB", _ai.Space / 1073741824D);
				this.btnSave.Enabled = true;
			}
		}

		private void btnModify_Click(object sender, EventArgs e)
		{
			Anime a = this.folvAnime.SelectedObject as Anime;

			if (a == null)
				return;

			ModForm mf = new ModForm(a);
			mf.StartPosition = FormStartPosition.CenterParent;
			mf.MaximizeBox = false;

			if (mf.ShowDialog(this) == DialogResult.OK)
			{
				_ai.Space -= a.Space;
				a.eCopy(mf.GetAnime());
				_ai.Space += a.Space;
				_ai.IsSaved = false;

				this.folvAnime_SelectionChanged(null, null);
				// TODO: 需修正工具栏
				this.folvAnime.Focus();
				this.tsslSpace.Text = String.Format("Total Space: {0:#,##0.#0} GB", _ai.Space / 1073741824D);
				this.btnSave.Enabled = true;
			}
		}

		private Anime _aCopy;

		private void btnCopy_Click(object sender, EventArgs e)
		{
			Anime a = this.folvAnime.SelectedObject as Anime;

			if (a == null)
				return;
			else
			{
				_aCopy = new Anime(a);
				this.btnPaste.Enabled = true;
			}
		}

		private void btnPaste_Click(object sender, EventArgs e)
		{
			_ai.Space += _aCopy.Space;
			_ai.Total++;
			_ai.IsSaved = false;
			_lani.Add(_aCopy);

			this.folvAnime.AddObject(_aCopy);
			this.folvAnime.SelectedObject = _aCopy;
			this.folvAnime.SelectedItem.EnsureVisible();
			// TODO: 需修正工具栏
			this.folvAnime.Focus();
			this.tsslTotal.Text = String.Format("Total: {0}", _ai.Total);
			this.tsslSpace.Text = String.Format("Total Space: {0:#,##0.#0} GB", _ai.Space / 1073741824D);
			this.btnSave.Enabled = true;
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			int isel;

			if (this.folvAnime.SelectedIndices.Count != 0)
				isel = this.folvAnime.SelectedIndices[0];
			else return;

			_ai.IsSaved = false;

			foreach (Anime a in this.folvAnime.SelectedObjects)
			{
				_ai.Space -= a.Space;
				_ai.Total--;

				_lani.Remove(a);
			}

			this.folvAnime.RemoveObjects(this.folvAnime.SelectedObjects);

			if (isel < this.folvAnime.Items.Count)
				this.folvAnime.SelectedIndex = isel;
			else this.folvAnime.SelectedIndex = isel - 1;

			this.folvAnime.SelectedItem.EnsureVisible();
			// TODO: 需修正工具栏
			this.folvAnime.Focus();
			this.tsslTotal.Text = String.Format("Total: {0}", _ai.Total);
			this.tsslSpace.Text = String.Format("Total Space: {0:#,##0.#0} GB", _ai.Space / 1073741824D);
			this.btnSave.Enabled = true;
		}

		private void folvAnime_IsHyperlink(object sender, IsHyperlinkEventArgs e)
		{
			e.Url = e.Text;
		}

		private void folvAnime_CellEditFinishing(object sender, CellEditEventArgs e)
		{
			// edit 13/1/7 for bug1
			if (e.Value.ToString() == e.NewValue.ToString())
				return;

			Anime a = e.RowObject as Anime;

			a.UpdateTime = DateTime.Now;

			this.rtbAnime.Text = a.Remarks();
			// edit fin

			this.btnSave.Enabled = true;
		}

		private void AnimeForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			XmlWriterSettings xwSet = new XmlWriterSettings();
			xwSet.Indent = true;
			xwSet.IndentChars = "\t";

			XmlWriter xWriter = XmlWriter.Create(@".\AnimeTrim.xml", xwSet);
			xWriter.WriteStartElement("AnimeTrim");
			xWriter.WriteStartElement("Settings");
			xWriter.WriteElementString("LastAccessName", _ai.Name);
			xWriter.WriteElementString("LastAccessPath", _ai.Path);
			xWriter.WriteEndElement();
			xWriter.WriteEndElement();
			xWriter.Flush();
			xWriter.Close();

			//_fs.Close();
		}

		private void AnimeForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			// edit 13/1/9 for bug3
			//if (!_ai.IsSaved)
			//{
			//    DialogResult dr;
			//    dr = MessageBox.Show(this, "Save current Anime?", "Save",
			//        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

			//    if (dr == DialogResult.Yes)
			//        btnSave_Click(null, null);
			//    else if (dr == DialogResult.Cancel)
			//        e.Cancel = true;
			//}
			if (!SaveCheck())
				e.Cancel = true;
			// edit fin
		}

	}
}