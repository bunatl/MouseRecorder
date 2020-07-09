using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recorder
{
	public partial class MouseRecorder : Form
	{
		List<MousePoint> points = new List<MousePoint>();
		int currentListPosition = 0;
		int timeDelay = 0;

		//capture inputs
		[System.Runtime.InteropServices.DllImport("User32.dll")] 
		private static extern short GetAsyncKeyState(int vKey);

		public MouseRecorder()
		{
			InitializeComponent();
		}

		private void MouseRecorder_Load(object sender, EventArgs e)
		{
			CurrentPosition.Start();
		}

        /*UI buttons*/

        private void buttonRec_Click(object sender, EventArgs e)
		{
			points.Clear();
			MouseRec.Start();
			listView1.Items.Clear();
		}

		private void buttonStop_Click(object sender, EventArgs e)
		{
			MouseRec.Stop();
		}

		private void buttonPlay_Click(object sender, EventArgs e)
		{
			Replay();
		}


		/*Recording timer*/
		private void MouseRec_Tick(object sender, EventArgs e)
		{
			string tmp = MouseRecorder.GetBuffKeys();
			if (tmp == "F10")
				MouseRec.Stop();

			MousePoint currentMousePoint = new MousePoint(Cursor.Position.X, Cursor.Position.Y);
			points.Add(currentMousePoint);
			if (tmp != "")
			{
				string[] delayValues = { timeDelay.ToString(), "Delay" };
				listView1.Items.Add("").SubItems.AddRange(delayValues);

				string[] rowValues = { currentMousePoint.getY().ToString(), tmp };
				listView1.Items.Add(currentMousePoint.getX().ToString()).SubItems.AddRange(rowValues);

				timeDelay = 0;
			}
			timeDelay++;
		}

		class MousePoint
		{
			public MousePoint(int x, int y)
			{
				this.x = x;
				this.y = y;
			}

			public int getX() { return this.x; }
			public int getY() { return this.y; }

			private int x;
			private int y;
		}

		public static string GetBuffKeys()
		{
			string buffer = "";
			foreach (System.Int32 i in Enum.GetValues(typeof(Keys)))
			{
				// pokud je hodnota GetAsyncKeyState rovna -32767 (hodnota pro stisk klávesy. Jsou zde i hodnoty pro držení klávesy, uvolnění a podobně.), tak
				if (GetAsyncKeyState(i) == -32767) 
					// add pressed key into the buffer
					buffer += Enum.GetName(typeof(Keys), i);
			}
			return buffer;
		}

		private int GetRndNumber(int start, int end) {
			Random rnd = new Random();
			return rnd.Next(start, end);
		}

		/* Replay of the mouse movement*/
		private void Replay() {
			
			//if no recordings, do not play
			if (points.Count == 0)
				return;

			//allow user to move mouse away
			System.Threading.Thread.Sleep(500);

			//loop as many times as user selected
			for (int i = 1; i <= numOfReps.Value; i++)
			{
				//set start position for replayeing to 0
				currentListPosition = 0;
				//Update number of the current loop
				currentLoop.Text = i.ToString();

				/*Iterate (move mouse) according to the its previous movemnt*/
				/* Each move is followed by delay of random lenght */
				for (int j = 0; j <= points.Count-1; j++)
				{
					Cursor.Position = new Point(points[currentListPosition].getX(), points[currentListPosition].getY());
					//random wait
					System.Threading.Thread.Sleep(GetRndNumber(7,14));
					currentListPosition++;
				}
			}
		}

		/* Program "menu"*/
		private void CurrentPosition_Tick(object sender, EventArgs e)
		{
			// log cursor position
			toolStripStatusLabel1.Text = Cursor.Position.X + ", " + Cursor.Position.Y;

			// check for pressed keyes
			string buttonPressed = MouseRecorder.GetBuffKeys();

			//start recording
			if (buttonPressed == "F9")
				buttonRec_Click(sender, e);

			//replay
			if (buttonPressed == "F8")
				Replay();
		}
    }
}
