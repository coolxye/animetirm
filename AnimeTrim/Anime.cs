using System;
using System.IO;
using BrightIdeasSoftware;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace AnimeTrim
{
	public enum MediaType
	{
		BDRip, DVDRip, BDRAW, DVDRAW, BDMV, TVRip
	}

	public enum MergeFormat
	{
		MKV, MP4, AVI, WMV, M2TS
	}

	public enum SubStyles
	{
		External, Sealed, Embedded
	}

	public class Anime
	{
		public String Title
		{ get; set; }

		public String Name
		{ get; set; }

		public Int32 Year
		{ get; set; }

		public String Season
		{ get; set; }

		public String ReleaseDate()
		{
			return String.Format("{0}.{1}", Year, Season);
		}

		public MediaType Type
		{ get; set; }

		public MergeFormat Format
		{ get; set; }

		public String Publisher
		{ get; set; }

		public SubStyles SubStyle
		{ get; set; }

		public String StoreIndex
		{ get; set; }

		public Int64 Space
		{ get; set; }

		public Boolean Gather
		{ get; set; }

		public Boolean View
		{ get; set; }

		public Int32 Rate
		{ get; set; }

		public DateTime CreateTime
		{ get; set; }

		public DateTime UpdateTime
		{ get; set; }

		public String Kana
		{ get; set; }

		// 动漫话数
		public String Episode
		{ get; set; }

		public String Note
		{ get; set; }

		// 作为固定形式时类中适合，以后更新时框架中方法适合
		private const String _format =
			"Creation Time: {0}, Update Time: {1}\n\n{2}";

		private const String _picfmt =
			"Original Name: {0}\nEpisode: {1}\n";

		public String Remarks()
		{
			return String.Format(_format, CreateTime, UpdateTime, Note.Replace('\u0002', '\n'));
		}

		public String PicRmks()
		{
			return String.Format(_picfmt, Kana, Episode);
		}

		public Anime()
		{ }

		public Anime(String title)
		{
			this.Title = title;
		}

		public Anime(String title, String name, Int32 year, String season, MediaType type,
			MergeFormat format, String publisher, SubStyles subStyle, String storeIndex,
			Int64 space, Boolean gather, Boolean view, Int32 rate, DateTime createTime,
			DateTime updateTime, String kana, String episode, String note)
		{
			this.Title = title;
			this.Name = name;
			this.Year = year;
			this.Season = season;
			this.Type = type;
			this.Format = format;
			this.Publisher = publisher;
			this.SubStyle = subStyle;
			this.StoreIndex = storeIndex;
			this.Space = space;
			this.Gather = gather;
			this.View = view;
			this.Rate = rate;
			this.CreateTime = createTime;
			this.UpdateTime = updateTime;
			this.Kana = kana;
			this.Episode = episode;
			this.Note = note;
		}

		public Anime(Anime other)
		{
			this.Title = other.Title;
			this.Name = other.Name;
			this.Year = other.Year;
			this.Season = other.Season;
			this.Type = other.Type;
			this.Format = other.Format;
			this.Publisher = other.Publisher;
			this.SubStyle = other.SubStyle;
			this.StoreIndex = other.StoreIndex;
			this.Space = other.Space;
			this.Gather = other.Gather;
			this.View = other.View;
			this.Rate = other.Rate;
			this.CreateTime = other.CreateTime;
			this.UpdateTime = other.UpdateTime;
			this.Kana = other.Kana;
			this.Episode = other.Episode;
			this.Note = other.Note;
		}

		public void eCopy(Anime edit)
		{
			this.Title = edit.Title;
			this.Year = edit.Year;
			this.Season = edit.Season;
			this.StoreIndex = edit.StoreIndex;
			this.Space = edit.Space;
			this.UpdateTime = edit.UpdateTime;
			this.Kana = edit.Kana;
			this.Episode = edit.Episode;
			this.Note = edit.Note;
		}
	}

	public struct AnimeInfo
	{
		public String Path
		{ get; set; }

		public String Name
		{ get; set; }

		public Int32 Total
		{ get; set; }

		public Int64 Space
		{ get; set; }

		public Boolean IsNew
		{ get; set; }

		public Boolean IsSaved
		{ get; set; }
	}

	public class AnimeSpace
	{
		public static Int64 GetSpace(String path)
		{
			if (!Directory.Exists(path))
				return 0L;

			long lSpace = 0L;
			DirectoryInfo dirInfo = new DirectoryInfo(path);

			foreach (FileInfo fInfo in dirInfo.GetFiles())
			{
				lSpace += fInfo.Length;
			}

			DirectoryInfo[] dirInfos = dirInfo.GetDirectories();

			if (dirInfos.Length > 0)
				for (int i = 0; i < dirInfos.Length; i++)
					lSpace += GetSpace(dirInfos[i].FullName);

			return lSpace;
		}
	}

	internal class AnimeViewOverlay : AbstractOverlay
	{
		public AnimeViewOverlay()
		{
			this.Transparency = 224;
		}

		public override void Draw(ObjectListView olv, Graphics g, Rectangle r)
		{
			if (olv.HotRowIndex < 0)
				return;

			Anime a = olv.GetModelObject(olv.HotRowIndex) as Anime;
			if (a == null)
				return;

			this.AnimeViewDraw(g, r, a);
		}

		private Pen BorderPen = new Pen(Color.DarkBlue, 2);//new Pen(Color.FromArgb(0x33, 0x33, 0x33));
		private Brush BackBrush = Brushes.LemonChiffon;
		private Brush TextBrush = new SolidBrush(Color.FromArgb(0x22, 0x22, 0x22));
		private Brush HeaderTextBrush = Brushes.Chocolate;//Brushes.AliceBlue;
		private Brush HeaderBackBrush = Brushes.DarkBlue;//new SolidBrush(Color.FromArgb(0x33, 0x33, 0x33));

		private void AnimeViewDraw(Graphics g, Rectangle r, Anime av)
		{
			const int spacing = 8;
			const int iw = 250;
			const int ih = 120;
			Size sView = new Size(iw, ih);
			Rectangle rView = new Rectangle(r.Right - sView.Width - spacing, r.Bottom - sView.Height - spacing,
				sView.Width, sView.Height);

			// Allow a border around the card
			rView.Inflate(-2, -2);

			// Draw card background
			const float rounding = 20F;
			GraphicsPath path = this.GetRoundedRect(rView, rounding);
			g.FillPath(this.BackBrush, path);
			g.DrawPath(this.BorderPen, path);

			g.Clip = new Region(rView);

			// Draw the photo
			Rectangle photoRect = rView;
			photoRect.Inflate(-spacing, -spacing);
			photoRect.Width = 80;
			string photoFile = String.Format(@".\Anime\{0}.png", av.Title);
			if (File.Exists(photoFile))
			{
				Image photo = Image.FromFile(photoFile);
				if (photo.Width > photoRect.Width)
					photoRect.Height = (int)(photo.Height * ((float)photoRect.Width / photo.Width));
				else
					photoRect.Height = photo.Height;
				g.DrawImage(photo, photoRect);
			}
			else
			{
				g.DrawRectangle(Pens.DarkGray, photoRect);
			}

			// Now draw the text portion
			RectangleF textBoxRect = photoRect;
			textBoxRect.X += (photoRect.Width + spacing);
			textBoxRect.Width = rView.Right - textBoxRect.X - spacing;

			StringFormat fmt = new StringFormat(StringFormatFlags.NoWrap);
			fmt.Trimming = StringTrimming.EllipsisCharacter;
			fmt.Alignment = StringAlignment.Center;
			fmt.LineAlignment = StringAlignment.Far;
			String txt = av.Name;

			using (Font font = new Font("Tahoma", 10))
			{
				// Measure the height of the title
				StringBuilder sbName = new StringBuilder(txt);
				int i = 2;
				while (g.MeasureString(txt, font).Width > textBoxRect.Width)
				{
					txt = sbName.ToString(0, (sbName.Length + i - 1) / i);
					i++;
				}
				i--;
				for (int j = 1; j < i; j++)
					sbName = sbName.Insert((sbName.Length - (i - 1)) / i * j, "\n");
				txt = sbName.ToString();
				//sbName = sbName.Insert(

				SizeF size = g.MeasureString(txt, font);//g.MeasureString(txt, font, (int)textBoxRect.Width, fmt);
				//int ilstr = txt.Length;
				//while (size.Width > textBoxRect.Width)
				//{
				//    size = g.MeasureString(txt.Remove(--ilstr), font);
				//}
				//string sntxt = txt.Remove(ilstr) + "\n";

				// Draw the title
				RectangleF r3 = textBoxRect;
				r3.Height = size.Height + 3F;
				path = this.GetRoundedRect(r3, 15);
				g.FillPath(this.HeaderBackBrush, path);
				//textBoxRect.Y += 1F;
				g.DrawString(txt, font, this.HeaderTextBrush, r3, fmt);
				textBoxRect.Y += size.Height + spacing;
			}

			// Draw the other bits of information
			using (Font font = new Font("Tahoma", 8))
			{
				txt = av.Kana;
				SizeF size = g.MeasureString(txt, font, rView.Width, fmt);
				textBoxRect.Height = size.Height;
				fmt.Alignment = StringAlignment.Near;
				g.DrawString(txt, font, this.TextBrush, textBoxRect, fmt);
				textBoxRect.Y += size.Height;
				txt = av.Episode;
				g.DrawString(txt, font, this.TextBrush, textBoxRect, fmt);
				textBoxRect.Y += size.Height;
			}
		}

		private GraphicsPath GetRoundedRect(RectangleF rect, float diameter)
		{
			GraphicsPath path = new GraphicsPath();

			RectangleF arc = new RectangleF(rect.X, rect.Y, diameter, diameter);
			path.AddArc(arc, 180, 90);
			arc.X = rect.Right - diameter;
			path.AddArc(arc, 270, 90);
			arc.Y = rect.Bottom - diameter;
			path.AddArc(arc, 0, 90);
			arc.X = rect.Left;
			path.AddArc(arc, 90, 90);
			path.CloseFigure();

			return path;
		}
	}
}
