namespace Uppgift3._2DesktopTrådning
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			//THREAD =  is an execution of a program.
			//			we can use multiple threads to perform,
			//			different tasks of our program, at the same time.
			//			Current thread running is Form1 using System.Threading

			//Assign the current thread that is running to a variable
			Thread Form1Thread = Thread.CurrentThread;





		}



		private void btnStartForm3_Click(object sender, EventArgs e)
		{

			new Thread(() => new Form3().ShowDialog()).Start();

		}

	}
}