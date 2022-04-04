namespace WindowsFormsApplication1
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnHide = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtKeyboard = new System.Windows.Forms.TextBox();
            this.txtMouse = new System.Windows.Forms.TextBox();
            this.txtloggingStatus = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowGraph = new System.Windows.Forms.Button();
            this.btnLogging = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Klikk/tastetrykkteller";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(24, 132);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(292, 24);
            this.btnHide.TabIndex = 1;
            this.btnHide.Text = "Skjul vindu";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSum);
            this.groupBox1.Controls.Add(this.txtKeyboard);
            this.groupBox1.Controls.Add(this.txtMouse);
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totalt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Museklikk:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tastetrykk:";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(88, 68);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(40, 20);
            this.txtSum.TabIndex = 6;
            this.txtSum.TabStop = false;
            this.txtSum.Text = "0";
            // 
            // txtKeyboard
            // 
            this.txtKeyboard.Location = new System.Drawing.Point(88, 44);
            this.txtKeyboard.Name = "txtKeyboard";
            this.txtKeyboard.ReadOnly = true;
            this.txtKeyboard.Size = new System.Drawing.Size(40, 20);
            this.txtKeyboard.TabIndex = 7;
            this.txtKeyboard.TabStop = false;
            this.txtKeyboard.Text = "0";
            // 
            // txtMouse
            // 
            this.txtMouse.Location = new System.Drawing.Point(88, 20);
            this.txtMouse.Name = "txtMouse";
            this.txtMouse.ReadOnly = true;
            this.txtMouse.Size = new System.Drawing.Size(40, 20);
            this.txtMouse.TabIndex = 8;
            this.txtMouse.TabStop = false;
            this.txtMouse.Text = "0";
            // 
            // txtloggingStatus
            // 
            this.txtloggingStatus.BackColor = System.Drawing.Color.LightCoral;
            this.txtloggingStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtloggingStatus.Location = new System.Drawing.Point(16, 24);
            this.txtloggingStatus.Multiline = true;
            this.txtloggingStatus.Name = "txtloggingStatus";
            this.txtloggingStatus.ReadOnly = true;
            this.txtloggingStatus.Size = new System.Drawing.Size(96, 16);
            this.txtloggingStatus.TabIndex = 8;
            this.txtloggingStatus.TabStop = false;
            this.txtloggingStatus.Text = "Av";
            this.txtloggingStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtloggingStatus);
            this.groupBox2.Controls.Add(this.btnShowGraph);
            this.groupBox2.Controls.Add(this.btnLogging);
            this.groupBox2.Location = new System.Drawing.Point(188, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logging";
            // 
            // btnShowGraph
            // 
            this.btnShowGraph.Location = new System.Drawing.Point(16, 68);
            this.btnShowGraph.Name = "btnShowGraph";
            this.btnShowGraph.Size = new System.Drawing.Size(96, 23);
            this.btnShowGraph.TabIndex = 3;
            this.btnShowGraph.Text = "Vis statistikk";
            this.btnShowGraph.UseVisualStyleBackColor = true;
            this.btnShowGraph.Click += new System.EventHandler(this.btnShowGraph_Click);
            // 
            // btnLogging
            // 
            this.btnLogging.Location = new System.Drawing.Point(16, 44);
            this.btnLogging.Name = "btnLogging";
            this.btnLogging.Size = new System.Drawing.Size(96, 23);
            this.btnLogging.TabIndex = 2;
            this.btnLogging.Text = "Start";
            this.btnLogging.UseVisualStyleBackColor = true;
            this.btnLogging.Click += new System.EventHandler(this.btnLogging_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 171);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(341, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Interval = 99999999;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 193);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Text = "Klikk/tastetrykkteller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtKeyboard;
        private System.Windows.Forms.TextBox txtMouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtloggingStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowGraph;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnLogging;
        private System.Windows.Forms.Timer timer1;
    }
}

