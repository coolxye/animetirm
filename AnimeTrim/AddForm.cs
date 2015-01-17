using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AnimeTrim
{
	public partial class AddForm : Form
	{
		public AddForm()
		{
			InitializeComponent();

			InitValue();

			InitMatch();
		}

		private void InitValue()
		{
			this.cboYear.Text = DateTime.Now.Year.ToString();

			int month = DateTime.Now.Month;
			if (month < 4)
				this.cboSeason.SelectedIndex = 0;
			else if (month < 7)
				this.cboSeason.SelectedIndex = 1;
			else if (month < 10)
				this.cboSeason.SelectedIndex = 2;
			else this.cboSeason.SelectedIndex = 3;

			this.cboType.SelectedIndex = 0;
			this.cboFormat.SelectedIndex = 0;
			this.cboPublisher.SelectedIndex = 0;
			this.cboSubStyle.SelectedIndex = 0;

			this.cboGather.SelectedIndex = 0;
			this.cboView.SelectedIndex = 0;
			this.cboRate.SelectedIndex = 1;
		}

		private void InitMatch()
		{
			MatchTitle();
			MatchYear();
			MatchStoreIndex();
			MatchCase();
		}

		private Anime _anime = new Anime();
		private byte btMatch = 0xF8;

		public Anime GetAnime()
		{
			return _anime;
		}

		// edit 13/1/13 for fun3
		private void MatchTitle()
		{
			//if (this.tbTitle.Text == String.Empty)
			//{
			//	this.lblTitleWarning.Text = "Title is null";
			//	btMatch &= 0xFE;
			//	return false;
			//}
			//else
			//{
			//	this.lblTitleWarning.Text = String.Empty;
			//	btMatch |= 0x01;
			//	return true;
			//}

			if (Anime.IsMatchTitle(this.tbTitle.Text))
			{
				this.lblTitleWarning.Text = String.Empty;
				btMatch |= 0x01;
			}
			else
			{
				this.lblTitleWarning.Text = "Title is null";
				btMatch &= 0xFE;
			}
		}

		private void MatchYear()
		{
			//if (Regex.IsMatch(this.cboYear.Text, "^(?!0000)[0-9]{4}$"))
			//{
			//	this.lblYearWarning.Text = String.Empty;
			//	btMatch |= 0x02;
			//	return true;
			//}
			//else
			//{
			//	this.lblYearWarning.Text = "Year is wrong";
			//	btMatch &= 0xFD;
			//	return false;
			//}
			if (Anime.IsMatchYear(this.cboYear.Text))
			{
				this.lblYearWarning.Text = String.Empty;
				btMatch |= 0x02;
			}
			else
			{
				this.lblYearWarning.Text = "Year is wrong";
				btMatch &= 0xFD;
			}
		}

		private void MatchStoreIndex()
		{
			//if (this.tbStoreIndex.Text == String.Empty ||
			//	Regex.IsMatch(this.tbStoreIndex.Text,
			//	@"^[a-zA-Z]:(\\(?![\s\.])[^\\/:\*\?\x22<>\|]*[^\s\.\\/:\*\?\x22<>\|])+$"))
			//{
			//	this.lblStoreIndexWarning.Text = String.Empty;
			//	btMatch |= 0x04;
			//	return true;
			//}
			//else
			//{
			//	this.lblStoreIndexWarning.Text = "Path isn't match";
			//	btMatch &= 0xFB;
			//	return false;
			//}
			if (Anime.IsMatchPath(this.tbStoreIndex.Text))
			{
				this.lblStoreIndexWarning.Text = String.Empty;
				btMatch |= 0x04;
			}
			else
			{
				this.lblStoreIndexWarning.Text = "Path isn't match";
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
			//}

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
			// edit fin

			_anime.Title = this.tbTitle.Text;
			_anime.Name = this.tbName.Text;
			_anime.Year = UInt32.Parse(this.cboYear.Text);
			_anime.Season = this.cboSeason.Text;
			_anime.Type = (MediaType)Enum.Parse(typeof(MediaType), this.cboType.Text);
			_anime.Format = (MergeFormat)Enum.Parse(typeof(MergeFormat), this.cboFormat.Text);
			_anime.SubTeam = this.cboPublisher.Text;
			_anime.SubStyle = (SubStyles)Enum.Parse(typeof(SubStyles), this.cboSubStyle.Text);
			_anime.Path = this.tbStoreIndex.Text;
			_anime.Size = Anime.GetSize(_anime.Path);
			_anime.Store = (this.cboGather.SelectedIndex == 1) ? true : false;
			_anime.Enjoy = (this.cboView.SelectedIndex == 1) ? true : false;
			_anime.Grade = Int32.Parse(this.cboRate.Text);
			_anime.CreateTime = DateTime.Now;
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
