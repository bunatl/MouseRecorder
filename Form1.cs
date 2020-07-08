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

		[System.Runtime.InteropServices.DllImport("User32.dll")] // budeme používat tuto knihovnu
		private static extern short GetAsyncKeyState(int vKey);

		public MouseRecorder()
		{
			InitializeComponent();
		}

		private void MouseRecorder_Load(object sender, EventArgs e)
		{
			CurrentPosition.Start();
		}

		private void MousePlay_Tick(object sender, EventArgs e)
		{
			//check for no input

			/*Iterates through the list and replicates mouse movement*/
			Cursor.Position = new Point(points[currentListPosition].getX(), points[currentListPosition].getY());
			if (currentListPosition++ >= points.Count()-1 )
				MousePlay.Stop();
		}

		private void buttonRec_Click(object sender, EventArgs e)
		{
			points.Clear();
			MouseRec.Start();
		}

		private void buttonStop_Click(object sender, EventArgs e)
		{
			MouseRec.Stop();
			MousePlay.Stop();
		}

		private void buttonPlay_Click(object sender, EventArgs e)
		{
			currentListPosition = 0;
			//how many times<? set accoring to something
			MousePlay.Start();
		}

		private void MouseRec_Tick(object sender, EventArgs e)
		{
			string tmp = MouseRecorder.GetBuffKeys();
			if (tmp == "F10")
				MouseRec.Stop();
			MousePoint currentMousePoint = new MousePoint(Cursor.Position.X, Cursor.Position.Y);
			points.Add(currentMousePoint);
			if (tmp != "")
			{
				string[] rowValues = { currentMousePoint.getY().ToString(), tmp };
				listView1.Items.Add(currentMousePoint.getX().ToString()).SubItems.AddRange(rowValues);
			}
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

		private void CurrentPosition_Tick(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Cursor.Position.X + ", " + Cursor.Position.Y;
			string tmp = MouseRecorder.GetBuffKeys();

			//start recording
			if (tmp == "F9")
				buttonRec_Click(sender, e);

			//stop recording
			/*if (tmp == "F10")
				MouseRec.Stop();*/

			//replay
			if (tmp == "F8")
				buttonPlay_Click(sender, e);

		}
	}
}
