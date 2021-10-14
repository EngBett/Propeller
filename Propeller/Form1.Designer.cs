namespace Propeller
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbTimerInterval = new System.Windows.Forms.TrackBar();
            this.tbAmountMoved = new System.Windows.Forms.TrackBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRevolutions = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimerInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmountMoved)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbTimerInterval
            // 
            this.tbTimerInterval.Location = new System.Drawing.Point(567, 126);
            this.tbTimerInterval.Maximum = -1;
            this.tbTimerInterval.Minimum = -100;
            this.tbTimerInterval.Name = "tbTimerInterval";
            this.tbTimerInterval.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbTimerInterval.Size = new System.Drawing.Size(45, 209);
            this.tbTimerInterval.TabIndex = 0;
            this.tbTimerInterval.Value = -50;
            this.tbTimerInterval.Scroll += new System.EventHandler(this.tbTimerInterval_Scroll);
            // 
            // tbAmountMoved
            // 
            this.tbAmountMoved.Location = new System.Drawing.Point(618, 126);
            this.tbAmountMoved.Maximum = 100;
            this.tbAmountMoved.Name = "tbAmountMoved";
            this.tbAmountMoved.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbAmountMoved.Size = new System.Drawing.Size(45, 209);
            this.tbAmountMoved.TabIndex = 1;
            this.tbAmountMoved.Value = 5;
            this.tbAmountMoved.Scroll += new System.EventHandler(this.tbAmountMoved_Scroll);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslRevolutions});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(708, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel1.Text = "Revolutions:";
            // 
            // tsslRevolutions
            // 
            this.tsslRevolutions.Name = "tsslRevolutions";
            this.tsslRevolutions.Size = new System.Drawing.Size(13, 17);
            this.tsslRevolutions.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 494);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbAmountMoved);
            this.Controls.Add(this.tbTimerInterval);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Propeller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.tbTimerInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmountMoved)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbTimerInterval;
        private System.Windows.Forms.TrackBar tbAmountMoved;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslRevolutions;
    }
}

