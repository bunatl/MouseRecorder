namespace Recorder
{
	partial class MouseRecorder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MouseRecorder));
            this.buttonRec = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MouseRec = new System.Windows.Forms.Timer(this.components);
            this.CurrentPosition = new System.Windows.Forms.Timer(this.components);
            this.numOfReps = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentLoop = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.xMin = new System.Windows.Forms.NumericUpDown();
            this.xMax = new System.Windows.Forms.NumericUpDown();
            this.yMin = new System.Windows.Forms.NumericUpDown();
            this.yMax = new System.Windows.Forms.NumericUpDown();
            this.delayMin = new System.Windows.Forms.NumericUpDown();
            this.delayMax = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfReps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayMax)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRec
            // 
            this.buttonRec.Location = new System.Drawing.Point(393, 27);
            this.buttonRec.Name = "buttonRec";
            this.buttonRec.Size = new System.Drawing.Size(195, 35);
            this.buttonRec.TabIndex = 0;
            this.buttonRec.Text = "Record (F9)";
            this.buttonRec.UseVisualStyleBackColor = true;
            this.buttonRec.Click += new System.EventHandler(this.buttonRec_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(393, 68);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(195, 35);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop (F10)";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(393, 110);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(195, 35);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Play (F8)";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recorderToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recorderToolStripMenuItem
            // 
            this.recorderToolStripMenuItem.Name = "recorderToolStripMenuItem";
            this.recorderToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.recorderToolStripMenuItem.Text = "Recorder";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 552);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(375, 481);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "#";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "X";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Y";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Action";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = " Δ Time [ms]";
            this.columnHeader4.Width = 91;
            // 
            // MouseRec
            // 
            this.MouseRec.Interval = 1;
            this.MouseRec.Tick += new System.EventHandler(this.MouseRec_Tick);
            // 
            // CurrentPosition
            // 
            this.CurrentPosition.Interval = 50;
            this.CurrentPosition.Tick += new System.EventHandler(this.CurrentPosition_Tick);
            // 
            // numOfReps
            // 
            this.numOfReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfReps.Location = new System.Drawing.Point(543, 165);
            this.numOfReps.Maximum = new decimal(new int[] {
            8096,
            0,
            0,
            0});
            this.numOfReps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfReps.Name = "numOfReps";
            this.numOfReps.Size = new System.Drawing.Size(41, 26);
            this.numOfReps.TabIndex = 8;
            this.numOfReps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Loops";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "/";
            // 
            // currentLoop
            // 
            this.currentLoop.AutoSize = true;
            this.currentLoop.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLoop.Location = new System.Drawing.Point(472, 165);
            this.currentLoop.Name = "currentLoop";
            this.currentLoop.Size = new System.Drawing.Size(24, 26);
            this.currentLoop.TabIndex = 11;
            this.currentLoop.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Randomization";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mouse X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(404, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mouse Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Delays";
            // 
            // xMin
            // 
            this.xMin.Location = new System.Drawing.Point(473, 308);
            this.xMin.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.xMin.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.xMin.Name = "xMin";
            this.xMin.Size = new System.Drawing.Size(48, 20);
            this.xMin.TabIndex = 16;
            // 
            // xMax
            // 
            this.xMax.Location = new System.Drawing.Point(534, 308);
            this.xMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xMax.Name = "xMax";
            this.xMax.Size = new System.Drawing.Size(45, 20);
            this.xMax.TabIndex = 17;
            // 
            // yMin
            // 
            this.yMin.Location = new System.Drawing.Point(473, 334);
            this.yMin.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.yMin.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.yMin.Name = "yMin";
            this.yMin.Size = new System.Drawing.Size(48, 20);
            this.yMin.TabIndex = 18;
            // 
            // yMax
            // 
            this.yMax.Location = new System.Drawing.Point(534, 334);
            this.yMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yMax.Name = "yMax";
            this.yMax.Size = new System.Drawing.Size(45, 20);
            this.yMax.TabIndex = 19;
            // 
            // delayMin
            // 
            this.delayMin.Location = new System.Drawing.Point(473, 360);
            this.delayMin.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.delayMin.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.delayMin.Name = "delayMin";
            this.delayMin.Size = new System.Drawing.Size(47, 20);
            this.delayMin.TabIndex = 20;
            // 
            // delayMax
            // 
            this.delayMax.Location = new System.Drawing.Point(534, 360);
            this.delayMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.delayMax.Name = "delayMax";
            this.delayMax.Size = new System.Drawing.Size(45, 20);
            this.delayMax.TabIndex = 21;
            // 
            // MouseRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 574);
            this.Controls.Add(this.delayMax);
            this.Controls.Add(this.delayMin);
            this.Controls.Add(this.yMax);
            this.Controls.Add(this.yMin);
            this.Controls.Add(this.xMax);
            this.Controls.Add(this.xMin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentLoop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numOfReps);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonRec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MouseRecorder";
            this.Text = "Mouse Randomize Recorder";
            this.Load += new System.EventHandler(this.MouseRecorder_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfReps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonRec;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Button buttonPlay;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem recorderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Timer MouseRec;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Timer CurrentPosition;
        private System.Windows.Forms.NumericUpDown numOfReps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentLoop;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown xMin;
        private System.Windows.Forms.NumericUpDown xMax;
        private System.Windows.Forms.NumericUpDown yMin;
        private System.Windows.Forms.NumericUpDown yMax;
        private System.Windows.Forms.NumericUpDown delayMin;
        private System.Windows.Forms.NumericUpDown delayMax;
    }
}

