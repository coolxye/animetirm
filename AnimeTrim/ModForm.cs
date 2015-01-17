﻿using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace AnimeTrim
{
	public partial class ModForm : Form
	{
		public ModForm(ref Anime a)
		{
			InitializeComponent();

			InitModValue(ref a);

			InitMatch();
		}

		private void InitMatch()
		{
			MatchTitle();
			MatchYear();
			MatchStoreIndex();
			MatchCase();
		}

		private byte btMatch = 0xF8;

		// edit 13/1/13 for fun3
		private void MatchTitle()
		{
			//if (this.tbTitle.Text == String.Empty)
			//{
			//	this.lblMatchTitle.Text = "Title is null";
			//	return false;
			//}
			//else
			//{
			//	this.lblMatchTitle.Text = String.Empty;
			//	return true;
			//}

			if (Anime.IsMatchTitle(this.tbTitle.Text))
			{
				this.lblMatchTitle.Text = String.Empty;
				btMatch |= 0x01;
			}
			else
			{
				this.lblMatchTitle.Text = "Title is null";
				btMatch &= 0xFE;
			}
		}

		private void MatchYear()
		{
			//if (Regex.IsMatch(this.cboYear.Text, "^(?!0000)[0-9]{4}$"))
			//{
			//	this.lblMatchYear.Text = String.Empty;
			//	return true;
			//}
			//else
			//{
			//	this.lblMatchYear.Text = "Year is wrong";
			//	return false;
			//}
			if (Anime.IsMatchYear(this.cboYear.Text))
			{
				this.lblMatchYear.Text = String.Empty;
				btMatch |= 0x02;
			}
			else
			{
				this.lblMatchYear.Text = "Year is wrong";
				btMatch &= 0xFD;
			}
		}

		private void MatchStoreIndex()
		{
			//if (this.tbStoreIndex.Text == String.Empty ||
			//	Regex.IsMatch(this.tbStoreIndex.Text,
			//	@"^[a-zA-Z]:(\\(?![\s\.])[^\\/:\*\?\x22<>\|]*[^\s\.\\/:\*\?\x22<>\|])+$"))
			//{
			//	this.lblMatchStoreIndex.Text = String.Empty;
			//	return true;
			//}
			//else
			//{
			//	this.lblMatchStoreIndex.Text = "Path isn't match";
			//	return false;
			//}
			if (Anime.IsMatchPath(this.tbStoreIndex.Text))
			{
				this.lblMatchStoreIndex.Text = String.Empty;
				btMatch |= 0x04;
			}
			else
			{
				this.lblMatchStoreIndex.Text = "Path isn't match";
				btMatch &= 0xFB;
			}
		}
		// edit fin

		private void MatchCase()
		{
			if ((btMatch & 0xFF) == 0xFF)
				this.btnOK.Enabled = true;
			else
				this.btnOK.Enabled = false;
		}

		private Anime _anime;

		private void InitModValue(ref Anime a)
		{
			this.tbTitle.Text = a.Title;
			this.tbKana.Text = a.Kana;
			this.tbEpisode.Text = a.Episode;
			this.tbInc.Text = a.Inc;

			this.cboYear.Text = a.Year.ToString("0000");
			this.cboSeason.Text = a.Season;

			this.cboFormat.Text = a.Format.ToString();
			this.cboSubStyle.Text = a.SubStyle.ToString();

			this.tbStoreIndex.Text = a.Path;
			this.rtbNote.Text = a.Note.Replace('\u0002', '\n');

			_anime = a;
		}

		public Anime GetAnime()
		{
			return _anime;
		}

		private void btnBrowser_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();

			if (fbd.ShowDialog(this) == DialogResult.OK)
				this.tbStoreIndex.Text = fbd.SelectedPath;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			// edit 13/1/13 for fun3
			//if (this.tbTitle.Text == "")
			//{
			//    MessageBox.Show("The title is a null value!", "Title error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//    this.tbTitle.Focus();

			//    return;
			//}

			//Regex rx = new Regex(@"^(?!0000)[0-9]{4}$");

			//if (!rx.IsMatch(this.cboYear.Text))
			//{
			//    MessageBox.Show("The Year is wrong!", "Year error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//    this.cboYear.ResetText();
			//    this.cboYear.Focus();

			//    return;
			//}

			//if (this.tbStoreIndex.Text != "")
			//{
			//    rx = new Regex(@"^[a-zA-Z]:(\\[^\s\.\\/:\*\?\x22<>\|][^\\/:\*\?\x22<>\|]*[^\s\.\\/:\*\?\x22<>\|])+$");

			//    if (!rx.IsMatch(this.tbStoreIndex.Text))
			//    {
			//        MessageBox.Show("The Path do not match!", "Path error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//        this.tbStoreIndex.ResetText();
			//        this.tbStoreIndex.Focus();

			//        return;
			//    }

			//    if (Directory.Exists(this.tbStoreIndex.Text))
			//        _anime.Size = AnimeSpace.GetSpace(this.tbStoreIndex.Text);
			//}
			//else _anime.Size = 0L;

			//bool btitle, byear, bstoreindex;

			//btitle = MatchTitle();
			//byear = MatchYear();
			//bstoreindex = MatchStoreIndex();

			//if (!btitle)
			//{
			//	this.tbTitle.Focus();
			//	return;
			//}
			//else if (!byear)
			//{
			//	this.cboYear.Text = String.Empty;
			//	this.cboYear.Focus();
			//	return;
			//}
			//else if (!bstoreindex)
			//{
			//	this.tbStoreIndex.Text = String.Empty;
			//	this.tbStoreIndex.Focus();
			//	return;
			//}

			if (this.tbStoreIndex.Text == String.Empty)
				_anime.Size = 0L;
			else if (Directory.Exists(this.tbStoreIndex.Text))
				_anime.Size = Anime.GetSize(this.tbStoreIndex.Text);
			// edit fin

			_anime.Title = this.tbTitle.Text;
			_anime.Year = UInt32.Parse(this.cboYear.Text);
			_anime.Season = this.cboSeason.Text;
			_anime.Path = this.tbStoreIndex.Text;

			_anime.Format = (MergeFormat)Enum.Parse(typeof(MergeFormat), this.cboFormat.Text);
			_anime.SubStyle = (SubStyles)Enum.Parse(typeof(SubStyles), this.cboSubStyle.Text);

			_anime.UpdateTime = DateTime.Now;
			_anime.Kana = this.tbKana.Text;
			_anime.Episode = this.tbEpisode.Text;
			_anime.Inc = this.tbInc.Text;
			_anime.Note = this.rtbNote.Text.Replace('\n', '\u0002');

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void rtbNote_Enter(object sender, EventArgs e)
		{
			this.AcceptButton = null;
		}

		private void rtbNote_Leave(object sender, EventArgs e)
		{
			this.AcceptButton = this.btnOK;
		}

		// edit 13/1/13 for fun3
		private void tbTitle_TextChanged(object sender, EventArgs e)
		{
			MatchTitle();
			MatchCase();
		}

		private void cboYear_TextChanged(object sender, EventArgs e)
		{
			MatchYear();
			MatchCase();
		}

		private void tbStoreIndex_TextChanged(object sender, EventArgs e)
		{
			MatchStoreIndex();
			MatchCase();
		}
		// edit fin
	}
}
