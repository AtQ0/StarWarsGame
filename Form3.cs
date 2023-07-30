using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Numerics;

namespace Uppgift3._2DesktopTrådning
{
	public partial class Form3 : Form
	{
		//Variables used for resizing the start button
		private Rectangle btnStartOriginalRectSize;
		private Rectangle btnKillsOriginalRectSize;
		private Rectangle btnHealthOriginalRectSize;
		private Rectangle originalFormSize;

		//Variable used for turning on and off the music
		SoundPlayer mySuperPlayer;
		SoundPlayer laserPlayer;

		//
		int counterForFirstTime = 0;


		//gameplay variables
		bool goLeft, goRight, goUp, goDown, shooting, gameOver;
		int kills;
		int playerSpeed = 20;
		int asteroidSpeed;
		int laserSpeed;
		int playerHealth = 100;


		Random rnd = new Random();

		//Constructor of Form3
		public Form3()
		{
			InitializeComponent();


			//Put on music on load
			mySuperPlayer = new SoundPlayer(@"C:\Users\mail\OneDrive - AtQo Inc\Dokument\GitHub\StarWarsGame\Media\Audio\StarWarsIntro.WAV");
			mySuperPlayer.PlayLooping();

			//Set background color of pbxHeader to transparent
			pbxLucasArts.BackColor = Color.Transparent;

			//Set pbxBackground as the parent of the pbxLucasArts
			//That way lucasArts can stay transparent while overlapping the background pbx
			//Note that pbxLucasArts has a property set to transparent, just above


			pbxLucasArts.Parent = pbxBackground;



			pbxJet.Visible = false;
			btnKills.Visible = false;
			btnHealth.Visible = false;
			pbxLaser1.Visible = false;

			pbxAsteroid1.Visible = false;
			pbxAsteroid2.Visible = false;
			pictureBox1.Visible = false;

			//Style lblKills and lblHealth
			btnKills.FlatStyle = FlatStyle.Flat;
			btnHealth.FlatStyle = FlatStyle.Flat;
			btnKills.ForeColor = Color.White;
			btnHealth.ForeColor = Color.White;
			btnKills.BackColor = Color.Transparent;
			btnHealth.BackColor = Color.Transparent;


		}


		private void Form3_Load(object sender, EventArgs e)
		{
			//Caputre the current starting point (X,Y) of the form, and its width and height
			originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);

			//Capture the current starting point (X,Y) of the start button, and its width and height  
			btnStartOriginalRectSize = new Rectangle(btnStartGame.Location.X, btnStartGame.Location.Y, btnStartGame.Width, btnStartGame.Height);

			//Capture starting point (X,Y) och the labels lblKills and lblHealth, and their width and height
			btnKillsOriginalRectSize = new Rectangle(btnKills.Location.X, btnKills.Location.Y, btnKills.Width, btnKills.Height);
			btnHealthOriginalRectSize = new Rectangle(btnHealth.Location.X, btnHealth.Location.Y, btnHealth.Width, btnHealth.Height);


		}



		//Method which resizes buttons labels, and all other controls in the window
		private void ResizeControls(Rectangle r, Control c)
		{

			//====== Resizing and re-positioning of the start button ======//

			//Calculate ratio that the buttons size has in relation to the window
			float xRatioOfStartBtn = (float)(this.Width) / (float)(originalFormSize.Width);
			float yRationOfStartBtn = (float)(this.Height) / (float)(originalFormSize.Height);

			//Calculate new coordinates in relation to the new size of the window
			int newBtnX = (int)(r.Location.X * xRatioOfStartBtn);
			int newBtnY = (int)(r.Location.Y * yRationOfStartBtn);

			//Calculate how much larger the new button has to be
			int newBtnWidth = (int)(r.Width * xRatioOfStartBtn);
			int newBtnHeight = (int)(r.Height * yRationOfStartBtn);

			//Change the location and the size of the button
			c.Location = new Point(newBtnX, newBtnY);
			c.Size = new Size(newBtnWidth, newBtnHeight);



			//====== Resizing and re-positioning of the kills and health labels ======//

			//Calculate ratio that the labels size has in relation to the window
			float xRatioOfLblKills = (float)(this.Width) / (float)(originalFormSize.Width);
			float yRatioOfLblKills = (float)(this.Height) / (float)(originalFormSize.Height);
			float xRatioOfLblHealth = (float)(this.Width) / (float)(originalFormSize.Width);
			float yRatioOfLblHealth = (float)(this.Height) / (float)(originalFormSize.Height);


			//Calculate new coordinates in relation to the new size of window
			int newLblKillsX = (int)(r.Location.X * xRatioOfLblKills);
			int newLblKillsY = (int)(r.Location.Y * yRatioOfLblKills);
			int newLblHealthX = (int)(r.Location.X * xRatioOfLblHealth);
			int newLblHealthY = (int)(r.Location.Y * yRatioOfLblHealth);

			//Calculate how much larger the new labels have to be
			int newLblKillsWidth = (int)(r.Width * xRatioOfLblKills);
			int newLblKillsHeight = (int)(r.Height * yRatioOfLblKills);
			int newLblHeightWidth = (int)(r.Width * xRatioOfLblHealth);
			int newLblHeightHeight = (int)(r.Height * yRatioOfLblHealth);

			//Change the location and the size of the labels
			c.Location = new Point(newLblKillsX, newLblKillsY);
			c.Size = new Size(newLblKillsWidth, newLblKillsHeight);
			c.Location = new Point(newLblHealthX, newLblHealthY);
			c.Size = new Size(newLblHeightWidth, newLblHeightHeight);

		}



		private void Form3_SizeChanged(object sender, EventArgs e)
		{
			//=== Start button resizing and repositioning ===//
			ResizeControls(btnStartOriginalRectSize, btnStartGame);

			ResizeControls(btnKillsOriginalRectSize, btnKills);
			ResizeControls(btnHealthOriginalRectSize, btnHealth);

			//== Lucas Arts Logo repositioninig ===//
			pbxLucasArts.Left = (Width / 2) - 390;
		}

		private void btnStartGame_Click(object sender, EventArgs e)
		{
			mySuperPlayer.Stop();
			SoundPlayer secondPlayer = new SoundPlayer(@"C:\Users\mail\OneDrive - AtQo Inc\Dokument\GitHub\StarWarsGame\Media\Audio\StarWarsThemeSong.WAV");
			secondPlayer.Play();

			pbxBackground.ImageLocation = @"C:\Users\mail\OneDrive - AtQo Inc\Dokument\GitHub\StarWarsGame\Media\Pictures\SpaceBackGroundImageB.JPG";
			pbxLucasArts.ImageLocation = @"C:\Users\mail\OneDrive - AtQo Inc\Dokument\GitHub\StarWarsGame\Media\Pictures\StarWarsLogo.PNG";

			//Delete lucas arts logo
			btnStartGame.Visible = false;

			if (counterForFirstTime <= 0)
			{
				timer1.Start();
			}

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			pbxLucasArts.Visible = false;

			pbxJet.Location = new Point(ClientSize.Width / 2 - pbxJet.Width / 2, (ClientSize.Height / 4) * 3);
			pbxJet.BackColor = Color.Transparent;
			pbxJet.Visible = true;
			btnKills.Visible = true;
			btnHealth.Visible = true;
			btnKills.Enabled = false;
			btnHealth.Enabled = false;

			pbxAsteroid1.Visible = true;
			pbxAsteroid2.Visible = true;
			pictureBox1.Visible = true;



			counterForFirstTime++;

			timer1.Dispose();
			timer1 = null;

			ResetGame();

		}


		//Method which turns off music when forms3 is closed
		private void Form3_FormClosed(object sender, FormClosedEventArgs e)
		{

			mySuperPlayer.Stop();

		}



		//=============================//
		//====== GAME STARTS HERE =====//
		//=============================//

		private void MainGameTimer(object sender, EventArgs e)
		{

			btnKills.Text = "KILLS: " + kills.ToString();

			//Asteroid movement starts
			pbxAsteroid1.Top += asteroidSpeed;
			pbxAsteroid2.Top += asteroidSpeed;
			pictureBox1.Top += asteroidSpeed;



			if (pbxAsteroid1.Top > this.ClientSize.Height || pbxAsteroid2.Top > this.ClientSize.Height || pictureBox1.Top > this.ClientSize.Height)
			{
				GameOver();
			}


			//Player movement logic starts
			if (goLeft == true && pbxJet.Left > 0)
			{
				pbxJet.Left -= playerSpeed;
			}
			if (goRight == true && pbxJet.Left < (this.Width - (1.2 * pbxJet.Width)))
			{
				pbxJet.Left += playerSpeed;
			}

			if (goUp == true && pbxJet.Top > 0)
			{
				pbxJet.Top -= playerSpeed;
			}

			if (goDown == true && pbxJet.Top < (this.Height - (1.2 * pbxJet.Height)))
			{
				pbxJet.Top += playerSpeed;

			}
			//player movement logic ends


			if (shooting == true)
			{
				laserSpeed = 20;
				pbxLaser1.Top -= laserSpeed;
			}
			else
			{
				pbxLaser1.Left = -300;
				laserSpeed = 0;
			}

			if (pbxLaser1.Top < -30)
			{
				shooting = false;
			}


			if (pbxLaser1.Bounds.IntersectsWith(pbxAsteroid1.Bounds))
			{
				kills += 1;
				pbxAsteroid1.Top = -450;
				pbxAsteroid1.Left = rnd.Next(20, this.ClientSize.Width -200);
				shooting = false;
			}

			if (pbxLaser1.Bounds.IntersectsWith(pbxAsteroid2.Bounds))
			{
				kills += 1;
				pbxAsteroid2.Top = -450;
				pbxAsteroid2.Left = rnd.Next(20, this.ClientSize.Width -200);
				shooting = false;
			}

			if (pbxLaser1.Bounds.IntersectsWith(pictureBox1.Bounds))
			{
				kills += 1;
				pictureBox1.Top = -450;
				pictureBox1.Left = rnd.Next(20, this.ClientSize.Width -200);
				shooting = false;
			}

			//Making game more difficult by making it faster with time
			if (kills == 5)
			{
				asteroidSpeed = 10;
			}

			if (kills == 10)
			{

				asteroidSpeed = 15;
			}

			pbxBackground.Visible = false;

		}

		//Controls
		private void KeyIsDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.A)
			{
				goLeft = true;
			}

			if (e.KeyCode == Keys.D)
			{
				goRight = true;
			}

			if (e.KeyCode == Keys.W)
			{
				goUp = true;
			}

			if (e.KeyCode == Keys.S)
			{
				goDown = true;
			}

		}

		private void KeyIsUp(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.A)
			{
				goLeft = false;
			}

			if (e.KeyCode == Keys.D)
			{
				goRight = false;
			}

			if (e.KeyCode == Keys.W)
			{
				goUp = false;
			}

			if (e.KeyCode == Keys.S)
			{
				goDown = false;
			}

			if (e.KeyCode == Keys.L && shooting == false)
			{
				shooting = true;
				pbxLaser1.Top = pbxJet.Top;
				pbxLaser1.Left = pbxJet.Left + (pbxJet.Width / 2) - 8;
				pbxLaser1.Visible = true;


			}

			if (e.KeyCode == Keys.Enter && gameOver == true)
			{
				ResetGame();
			}

		}


		private void ResetGame()
		{

			GameTimer.Start();
			asteroidSpeed = 6;

			pbxAsteroid1.Left = rnd.Next(20, this.Width - 300);
			pbxAsteroid2.Left = rnd.Next(20, this.Width - 300);
			pictureBox1.Left = rnd.Next(20, this.Width - 300);

			pbxAsteroid1.Top = rnd.Next(0, 200) * -1;
			pbxAsteroid2.Top = rnd.Next(0, 500) * -1;
			pictureBox1.Top = rnd.Next(0, 900) * -1;

			kills = 0;
			laserSpeed = 0;
			pbxLaser1.Left = -300;
			shooting = false;

			btnKills.Text = "KILLS: " + kills.ToString();

			pbxJet.Location = new Point(ClientSize.Width / 2 - pbxJet.Width / 2, (ClientSize.Height / 4) * 3);

		}

		private void GameOver()
		{
			gameOver = true;
			GameTimer.Stop();
			btnStartGame.Visible = true;
			btnStartGame.Size = new Size(400, 400);
			btnStartGame.Text = "Game Over!" + "\nPress enter to try again.";



		}


	}


}
