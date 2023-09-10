namespace Quickly_Helper
{
	// Token: 0x02000002 RID: 2
	public partial class About_us : global::System.Windows.Forms.Form
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0000252C File Offset: 0x0000072C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000255C File Offset: 0x0000075C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Quickly_Helper.About_us));
			this.Discord = new global::System.Windows.Forms.PictureBox();
			this.YouTube_Button = new global::System.Windows.Forms.PictureBox();
			this.instagram = new global::System.Windows.Forms.PictureBox();
			this.FaceBook = new global::System.Windows.Forms.PictureBox();
			this.Close = new global::System.Windows.Forms.PictureBox();
			this.Contact = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.Discord).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.YouTube_Button).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.instagram).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FaceBook).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Close).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.Discord.BackColor = global::System.Drawing.Color.Transparent;
			this.Discord.BackgroundImage = global::Quickly_Helper.Properties.Resources.DS2;
			this.Discord.Location = new global::System.Drawing.Point(12, 114);
			this.Discord.Name = "Discord";
			this.Discord.Size = new global::System.Drawing.Size(50, 50);
			this.Discord.TabIndex = 0;
			this.Discord.TabStop = false;
			this.Discord.Click += new global::System.EventHandler(this.Discord_Click);
			this.YouTube_Button.BackColor = global::System.Drawing.Color.Transparent;
			this.YouTube_Button.BackgroundImage = global::Quickly_Helper.Properties.Resources.YT2;
			this.YouTube_Button.Location = new global::System.Drawing.Point(68, 114);
			this.YouTube_Button.Name = "YouTube_Button";
			this.YouTube_Button.Size = new global::System.Drawing.Size(50, 50);
			this.YouTube_Button.TabIndex = 0;
			this.YouTube_Button.TabStop = false;
			this.YouTube_Button.Click += new global::System.EventHandler(this.YouTube_Button_Click);
			this.instagram.BackColor = global::System.Drawing.Color.Transparent;
			this.instagram.BackgroundImage = global::Quickly_Helper.Properties.Resources.Insta2;
			this.instagram.Location = new global::System.Drawing.Point(205, 114);
			this.instagram.Name = "instagram";
			this.instagram.Size = new global::System.Drawing.Size(50, 50);
			this.instagram.TabIndex = 0;
			this.instagram.TabStop = false;
			this.instagram.Click += new global::System.EventHandler(this.instagram_Click);
			this.FaceBook.BackColor = global::System.Drawing.Color.Transparent;
			this.FaceBook.BackgroundImage = global::Quickly_Helper.Properties.Resources.FC2;
			this.FaceBook.Location = new global::System.Drawing.Point(137, 114);
			this.FaceBook.Name = "FaceBook";
			this.FaceBook.Size = new global::System.Drawing.Size(50, 50);
			this.FaceBook.TabIndex = 0;
			this.FaceBook.TabStop = false;
			this.FaceBook.Click += new global::System.EventHandler(this.FaceBook_Click);
			this.Close.BackColor = global::System.Drawing.Color.Transparent;
			this.Close.BackgroundImage = global::Quickly_Helper.Properties.Resources.Close;
			this.Close.Location = new global::System.Drawing.Point(292, 2);
			this.Close.Name = "Close";
			this.Close.Size = new global::System.Drawing.Size(30, 30);
			this.Close.TabIndex = 1;
			this.Close.TabStop = false;
			this.Close.Click += new global::System.EventHandler(this.Close_Click);
			this.Contact.AutoSize = true;
			this.Contact.BackColor = global::System.Drawing.Color.Transparent;
			this.Contact.Font = new global::System.Drawing.Font("Buxton Sketch", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Contact.ForeColor = global::System.Drawing.Color.Black;
			this.Contact.Location = new global::System.Drawing.Point(25, 18);
			this.Contact.Name = "Contact";
			this.Contact.Size = new global::System.Drawing.Size(136, 36);
			this.Contact.TabIndex = 2;
			this.Contact.Text = "Contact us";
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = global::Quickly_Helper.Properties.Resources.Pubg;
			this.pictureBox1.Location = new global::System.Drawing.Point(261, 114);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(50, 50);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Quickly_Helper.Properties.Resources.About_usBox;
			base.ClientSize = new global::System.Drawing.Size(323, 176);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.Contact);
			base.Controls.Add(this.Close);
			base.Controls.Add(this.FaceBook);
			base.Controls.Add(this.instagram);
			base.Controls.Add(this.YouTube_Button);
			base.Controls.Add(this.Discord);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "About_us";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "تواصل معنا";
			base.TransparencyKey = global::System.Drawing.SystemColors.ScrollBar;
			((global::System.ComponentModel.ISupportInitialize)this.Discord).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.YouTube_Button).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.instagram).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FaceBook).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Close).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.PictureBox Discord;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.PictureBox YouTube_Button;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.PictureBox instagram;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.PictureBox FaceBook;

		// Token: 0x04000007 RID: 7
		private new global::System.Windows.Forms.PictureBox Close;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label Contact;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
