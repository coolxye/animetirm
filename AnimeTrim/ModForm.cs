using System;
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
		}

		// edit 13/1/13 for fun3
		private bool MatchTitle()
		{
			if (this.tbTitle.Text == String.Empty)
			{
				this.lblMatchTitle.Text = "Title is null";
				return false;
			}
			else
			{
				this.lblMatchTitle.Text = String.Empty;
				return true;
			}
		}

		private bool MatchYear()
		{
			if (Regex.IsMatch(this.cboYear.Text, "^(?!0000)[0-9]{4}$"))
			{
				this.lblMatchYear.Text = String.Empty;
				return true;
			}
			else
			{
				this.lblMatchYear.Text = "Year is wrong";
				return false;
			}
		}

		private bool MatchStoreIndex()
		{
			if (this.tbStoreIndex.Text == String.Empty ||
				Regex.IsMatch(this.tbStoreIndex.Text,
				@"^[a-zA-Z]:(\\(?![\s\.])[^\\/:\*\?\x22<>\|]*[^\s\.\\/:\*\?\x22<>\|])+$"))
			{
				this.lblMatchStoreIndex.Text = String.Empty;
				return true;
			}
			else
			{
				this.lblMatchStoreIndex.Text = "StoreIndex isn't match";
				return false;
			}
		}
		// edit fin

		private Anime _anime;

		private void InitModValue(ref Anime a)
		{
			this.tbTitle.Text = a.Title;
			this.tbKana.Text = a.Kana;
			this.tbEpisode.Text = a.Episode;

			this.cboYear.Text = a.Year.ToString("0000");
			this.cboSeason.Text = a.Season;

			this.tbStoreIndex.Text = a.StoreIndex;
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
			//        MessageBox.Show("The StoreIndex do not match!", "Path error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//        this.tbStoreIndex.ResetText();
			//        this.tbStoreIndex.Focus();

			//        return;
			//    }

			//    if (Directory.Exists(this.tbStoreIndex.Text))
			//        _anime.Space = AnimeSpace.GetSpace(this.tbStoreIndex.Text);
			//}
			//else _anime.Space = 0L;

			bool btitle, byear, bstoreindex;

			btitle = MatchTitle();
			byear = MatchYear();
			bstoreindex = MatchStoreIndex();

			if (!btitle)
			{
				this.tbTitle.Focus();
				return;
			}
			else if (!byear)
			{
				this.cboYear.Text = String.Empty;
				this.cboYear.Focus();
				return;
			}
			else if (!bstoreindex)
			{
				this.tbStoreIndex.Text = String.Empty;
				this.tbStoreIndex.Focus();
				return;
			}

			if (this.tbStoreIndex.Text == String.Empty)
				_anime.Space = 0L;
			else if (Directory.Exists(this.tbStoreIndex.Text))
				_anime.Space = AnimeSpace.GetSpace(this.tbStoreIndex.Text);
			// edit fin

			_anime.Title = this.tbTitle.Text;
			_anime.Year = UInt32.Parse(this.cboYear.Text);
			_anime.Season = this.cboSeason.Text;
			_anime.StoreIndex = this.tbStoreIndex.Text;

			_anime.UpdateTime = DateTime.Now;
			_anime.Kana = this.tbKana.Text;
			_anime.Episode = this.tbEpisode.Text;
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
		}

		private void cboYear_TextChanged(object sender, EventArgs e)
		{
			MatchYear();
		}

		private void tbStoreIndex_TextChanged(object sender, EventArgs e)
		{
			MatchStoreIndex();
		}
		// edit fin
	}
}
