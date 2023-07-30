namespace Uppgift3._2DesktopTrådning
{
	partial class Form3
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			pbxAsteroid2 = new PictureBox();
			pbxAsteroid1 = new PictureBox();
			pbxLaser1 = new PictureBox();
			btnHealth = new Button();
			btnKills = new Button();
			btnStartGame = new Button();
			pbxLucasArts = new PictureBox();
			pbxJet = new PictureBox();
			pbxBackground = new PictureBox();
			GameTimer = new System.Windows.Forms.Timer(components);
			timer1 = new System.Windows.Forms.Timer(components);
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbxAsteroid2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbxAsteroid1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbxLaser1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbxLucasArts).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbxJet).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbxBackground).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(pbxAsteroid2);
			panel1.Controls.Add(pbxAsteroid1);
			panel1.Controls.Add(pbxLaser1);
			panel1.Controls.Add(btnHealth);
			panel1.Controls.Add(btnKills);
			panel1.Controls.Add(btnStartGame);
			panel1.Controls.Add(pbxLucasArts);
			panel1.Controls.Add(pbxJet);
			panel1.Controls.Add(pbxBackground);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1417, 898);
			panel1.TabIndex = 11;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(966, -166);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(176, 166);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 32;
			pictureBox1.TabStop = false;
			// 
			// pbxAsteroid2
			// 
			pbxAsteroid2.BackColor = Color.Transparent;
			pbxAsteroid2.Image = (Image)resources.GetObject("pbxAsteroid2.Image");
			pbxAsteroid2.Location = new Point(552, -258);
			pbxAsteroid2.Name = "pbxAsteroid2";
			pbxAsteroid2.Size = new Size(267, 257);
			pbxAsteroid2.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxAsteroid2.TabIndex = 31;
			pbxAsteroid2.TabStop = false;
			// 
			// pbxAsteroid1
			// 
			pbxAsteroid1.BackColor = Color.Transparent;
			pbxAsteroid1.Image = (Image)resources.GetObject("pbxAsteroid1.Image");
			pbxAsteroid1.Location = new Point(277, -84);
			pbxAsteroid1.Name = "pbxAsteroid1";
			pbxAsteroid1.Size = new Size(89, 83);
			pbxAsteroid1.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxAsteroid1.TabIndex = 29;
			pbxAsteroid1.TabStop = false;
			// 
			// pbxLaser1
			// 
			pbxLaser1.BackColor = Color.Yellow;
			pbxLaser1.Location = new Point(724, 636);
			pbxLaser1.Name = "pbxLaser1";
			pbxLaser1.Size = new Size(16, 59);
			pbxLaser1.TabIndex = 20;
			pbxLaser1.TabStop = false;
			// 
			// btnHealth
			// 
			btnHealth.FlatAppearance.BorderSize = 0;
			btnHealth.FlatStyle = FlatStyle.Popup;
			btnHealth.Font = new Font("ROG Fonts", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
			btnHealth.Location = new Point(1160, 26);
			btnHealth.Name = "btnHealth";
			btnHealth.Size = new Size(257, 46);
			btnHealth.TabIndex = 18;
			btnHealth.Text = "Health: 100%";
			btnHealth.UseVisualStyleBackColor = true;
			// 
			// btnKills
			// 
			btnKills.FlatAppearance.BorderSize = 0;
			btnKills.FlatStyle = FlatStyle.Flat;
			btnKills.Font = new Font("ROG Fonts", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
			btnKills.Location = new Point(3, 26);
			btnKills.Name = "btnKills";
			btnKills.Size = new Size(172, 46);
			btnKills.TabIndex = 17;
			btnKills.Text = "KILLS: 0";
			btnKills.UseVisualStyleBackColor = true;
			// 
			// btnStartGame
			// 
			btnStartGame.AutoSize = true;
			btnStartGame.Location = new Point(657, 497);
			btnStartGame.Name = "btnStartGame";
			btnStartGame.Size = new Size(150, 46);
			btnStartGame.TabIndex = 12;
			btnStartGame.Text = "Start Game";
			btnStartGame.UseVisualStyleBackColor = true;
			btnStartGame.Click += btnStartGame_Click;
			// 
			// pbxLucasArts
			// 
			pbxLucasArts.Image = (Image)resources.GetObject("pbxLucasArts.Image");
			pbxLucasArts.Location = new Point(331, 89);
			pbxLucasArts.Name = "pbxLucasArts";
			pbxLucasArts.Size = new Size(802, 329);
			pbxLucasArts.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxLucasArts.TabIndex = 11;
			pbxLucasArts.TabStop = false;
			// 
			// pbxJet
			// 
			pbxJet.Image = Properties.Resources.StarWarsJetFight;
			pbxJet.Location = new Point(598, 636);
			pbxJet.Name = "pbxJet";
			pbxJet.Size = new Size(266, 250);
			pbxJet.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxJet.TabIndex = 14;
			pbxJet.TabStop = false;
			// 
			// pbxBackground
			// 
			pbxBackground.Dock = DockStyle.Fill;
			pbxBackground.Image = (Image)resources.GetObject("pbxBackground.Image");
			pbxBackground.Location = new Point(0, 0);
			pbxBackground.Name = "pbxBackground";
			pbxBackground.Size = new Size(1417, 898);
			pbxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxBackground.TabIndex = 13;
			pbxBackground.TabStop = false;
			// 
			// GameTimer
			// 
			GameTimer.Interval = 20;
			GameTimer.Tick += MainGameTimer;
			// 
			// timer1
			// 
			timer1.Interval = 9000;
			timer1.Tick += timer1_Tick;
			// 
			// Form3
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightCoral;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1417, 898);
			Controls.Add(panel1);
			KeyPreview = true;
			Name = "Form3";
			Text = "Star Wars";
			FormClosed += Form3_FormClosed;
			Load += Form3_Load;
			SizeChanged += Form3_SizeChanged;
			KeyDown += KeyIsDown;
			KeyUp += KeyIsUp;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pbxAsteroid2).EndInit();
			((System.ComponentModel.ISupportInitialize)pbxAsteroid1).EndInit();
			((System.ComponentModel.ISupportInitialize)pbxLaser1).EndInit();
			((System.ComponentModel.ISupportInitialize)pbxLucasArts).EndInit();
			((System.ComponentModel.ISupportInitialize)pbxJet).EndInit();
			((System.ComponentModel.ISupportInitialize)pbxBackground).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Panel panel1;
		private Button btnStartGame;
		private PictureBox pbxLucasArts;
		private PictureBox pbxBackground;
		private PictureBox pbxJet;
		private Button btnHealth;
		private Button btnKills;
		private System.Windows.Forms.Timer GameTimer;
		private PictureBox pbxLaser1;
		private PictureBox pbxAsteroid2;
		private PictureBox pbxAsteroid1;
		private System.Windows.Forms.Timer timer1;
		private PictureBox pictureBox1;
	}
}