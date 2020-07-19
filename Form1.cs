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
		// value (in order): ID, recordedAt (time of creation), mouse position at that time
		Dictionary<int, mousePathEntries > mousePath = new Dictionary<int, mousePathEntries >();
		int entryID = 0;
		double waitTime = 0;

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
			// clear previous recording
			mousePath.Clear();
			listView1.Items.Clear();
			entryID = 0;
			waitTime = 0;

			MouseRec.Start();
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
			//record mouse position and key
			string keyPressed = "";
			keyPressed = MouseRecorder.GetBuffKeys();
			MousePoint currentMousePoint = new MousePoint(Cursor.Position.X, Cursor.Position.Y);
			DateTime recordedAt = DateTime.Now;

			// check for break hotkey
			if (keyPressed == "F10")
				MouseRec.Stop();

			mousePathEntries entry = new mousePathEntries(currentMousePoint, recordedAt, keyPressed, 0);
			mousePath.Add(entryID++, entry);

			// Add row into app list
			double timeDiff = waitTime;
			if (entryID > 1)
				timeDiff = Math.Round((recordedAt - mousePath[(entryID - 2)].timeStamp).TotalMilliseconds);

			// calculate wait time if mouse is not moving
			waitTime += timeDiff;

			// log to app only user inputs
			if (keyPressed != "" && keyPressed != "F10")
			{
				string[] rowValues = { currentMousePoint.getX().ToString(), currentMousePoint.getY().ToString(), keyPressed, waitTime.ToString() };
				listView1.Items.Add((entryID - 1).ToString()).SubItems.AddRange(rowValues);

				// in order to edit waittime in mousePathMap need to create new entry with new wait time
				mousePath[ (  entryID - 1 ) ] = new mousePathEntries(currentMousePoint, recordedAt, keyPressed, waitTime);

				// when print to the window, reset counter for wait time
				waitTime = 0;
            }
		}

		struct mousePathEntries
		{
			public mousePathEntries( MousePoint p, DateTime dt, string k, double tw ) {
				this.point = p;
				this.timeStamp = dt;
				this.key = k;
				this.timeWait = tw;
			}

			public MousePoint point { get; set; }
			public DateTime timeStamp { get; set; }
			public string key { get; set; }
			public double timeWait { get; set; }
		}

		class MousePoint
		{
			public MousePoint(int x, int y)
			{
				this.x = x;
				this.y = y;
			}

			public MousePoint() : this(0, 0) {}

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
			if (mousePath.Count == 0)
				return;

			//allow user to move mouse away before replay starts
			System.Threading.Thread.Sleep(500);

			//loop as many times as user selected
			for (int i = 1; i <= numOfReps.Value; i++)
			{
				//Update number of the current loop
				currentLoop.Text = i.ToString();

				/*Iterate (move mouse) according to the its previous movemnt*/
				/* Each move is followed by delay of random lenght */
				for (int j = 0; j <= mousePath.Count-1; j++)
				{
					// randomize mouse point
					int pX = mousePath[j].point.getX() + GetRndNumber( (int) xMin.Value, (int) xMax.Value );
					int pY = mousePath[j].point.getY() + GetRndNumber((int) yMin.Value, (int) yMax.Value);
					// Replicate mouse movement
					Cursor.Position = new Point( pX, pY );

					SendKeys.Send( mousePath[j].key );

					//random wait
					System.Threading.Thread.Sleep( (int) mousePath[j].timeWait + GetRndNumber((int) delayMin.Value, (int) delayMax.Value) );
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
