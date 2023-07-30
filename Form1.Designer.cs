namespace Uppgift3._2DesktopTrådning
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblHeader = new Label();
			gbxFun = new GroupBox();
			label1 = new Label();
			btnStartForm3 = new Button();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			gbxFun.SuspendLayout();
			SuspendLayout();
			// 
			// lblHeader
			// 
			lblHeader.AutoSize = true;
			lblHeader.Font = new Font("ROG Fonts", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
			lblHeader.Location = new Point(233, 58);
			lblHeader.Name = "lblHeader";
			lblHeader.Size = new Size(588, 64);
			lblHeader.TabIndex = 0;
			lblHeader.Text = "Your Terminal";
			// 
			// gbxFun
			// 
			gbxFun.Controls.Add(label7);
			gbxFun.Controls.Add(label6);
			gbxFun.Controls.Add(label5);
			gbxFun.Controls.Add(label4);
			gbxFun.Controls.Add(label3);
			gbxFun.Controls.Add(label1);
			gbxFun.Controls.Add(btnStartForm3);
			gbxFun.Controls.Add(label2);
			gbxFun.Location = new Point(335, 219);
			gbxFun.Name = "gbxFun";
			gbxFun.Size = new Size(400, 450);
			gbxFun.TabIndex = 2;
			gbxFun.TabStop = false;
			gbxFun.Text = "FUN";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(132, 44);
			label1.Name = "label1";
			label1.Size = new Size(138, 32);
			label1.TabIndex = 3;
			label1.Text = "CONTROLS:";
			// 
			// btnStartForm3
			// 
			btnStartForm3.Location = new Point(120, 339);
			btnStartForm3.Name = "btnStartForm3";
			btnStartForm3.Size = new Size(150, 46);
			btnStartForm3.TabIndex = 3;
			btnStartForm3.Text = "PLAY";
			btnStartForm3.UseVisualStyleBackColor = true;
			btnStartForm3.Click += btnStartForm3_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(45, 279);
			label2.Name = "label2";
			label2.Size = new Size(314, 32);
			label2.TabIndex = 2;
			label2.Text = "Press button to start playing";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(104, 86);
			label3.Name = "label3";
			label3.Size = new Size(184, 32);
			label3.TabIndex = 4;
			label3.Text = "Up: keyboard W";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(97, 118);
			label4.Name = "label4";
			label4.Size = new Size(207, 32);
			label4.TabIndex = 5;
			label4.Text = "Down: keyboard S";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(104, 150);
			label5.Name = "label5";
			label5.Size = new Size(187, 32);
			label5.TabIndex = 6;
			label5.Text = "Left: keyboard A";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(94, 182);
			label6.Name = "label6";
			label6.Size = new Size(205, 32);
			label6.TabIndex = 7;
			label6.Text = "Right: keyboard D";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(93, 213);
			label7.Name = "label7";
			label7.Size = new Size(206, 32);
			label7.TabIndex = 8;
			label7.Text = "Shoot: keyboard L";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1070, 733);
			Controls.Add(gbxFun);
			Controls.Add(lblHeader);
			Name = "Form1";
			Text = "Main Terminal";
			gbxFun.ResumeLayout(false);
			gbxFun.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblHeader;
		private GroupBox gbxFun;
		private Button btnStartForm3;
		private Label label2;
		private Label label1;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
	}
}