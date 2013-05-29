namespace irrKlang_Tester
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEffects = new System.Windows.Forms.Button();
            this.btnStopEffects = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDistortion = new System.Windows.Forms.RadioButton();
            this.rdoEcho = new System.Windows.Forms.RadioButton();
            this.rdoReverb = new System.Windows.Forms.RadioButton();
            this.rdoGargle = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(5, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(177, 51);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Basic";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(5, 76);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(177, 51);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop Basic";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(7, 178);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(425, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Volume Control";
            // 
            // btnEffects
            // 
            this.btnEffects.Location = new System.Drawing.Point(233, 36);
            this.btnEffects.Name = "btnEffects";
            this.btnEffects.Size = new System.Drawing.Size(177, 51);
            this.btnEffects.TabIndex = 5;
            this.btnEffects.Text = "Start Effect";
            this.btnEffects.UseVisualStyleBackColor = true;
            this.btnEffects.Click += new System.EventHandler(this.btnEffects_Click);
            // 
            // btnStopEffects
            // 
            this.btnStopEffects.Location = new System.Drawing.Point(233, 150);
            this.btnStopEffects.Name = "btnStopEffects";
            this.btnStopEffects.Size = new System.Drawing.Size(177, 51);
            this.btnStopEffects.TabIndex = 6;
            this.btnStopEffects.Text = "Stop Effect";
            this.btnStopEffects.UseVisualStyleBackColor = true;
            this.btnStopEffects.Click += new System.EventHandler(this.btnStopEffects_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnEffects);
            this.panel1.Controls.Add(this.btnStopEffects);
            this.panel1.Location = new System.Drawing.Point(525, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 322);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoGargle);
            this.groupBox1.Controls.Add(this.rdoReverb);
            this.groupBox1.Controls.Add(this.rdoEcho);
            this.groupBox1.Controls.Add(this.rdoDistortion);
            this.groupBox1.Location = new System.Drawing.Point(21, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 225);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select an Effect";
            // 
            // rdoDistortion
            // 
            this.rdoDistortion.AutoSize = true;
            this.rdoDistortion.Location = new System.Drawing.Point(18, 48);
            this.rdoDistortion.Name = "rdoDistortion";
            this.rdoDistortion.Size = new System.Drawing.Size(132, 33);
            this.rdoDistortion.TabIndex = 0;
            this.rdoDistortion.TabStop = true;
            this.rdoDistortion.Text = "Distortion";
            this.rdoDistortion.UseVisualStyleBackColor = true;
            // 
            // rdoEcho
            // 
            this.rdoEcho.AutoSize = true;
            this.rdoEcho.Location = new System.Drawing.Point(18, 87);
            this.rdoEcho.Name = "rdoEcho";
            this.rdoEcho.Size = new System.Drawing.Size(82, 33);
            this.rdoEcho.TabIndex = 1;
            this.rdoEcho.TabStop = true;
            this.rdoEcho.Text = "Echo";
            this.rdoEcho.UseVisualStyleBackColor = true;
            // 
            // rdoReverb
            // 
            this.rdoReverb.AutoSize = true;
            this.rdoReverb.Location = new System.Drawing.Point(18, 126);
            this.rdoReverb.Name = "rdoReverb";
            this.rdoReverb.Size = new System.Drawing.Size(103, 33);
            this.rdoReverb.TabIndex = 2;
            this.rdoReverb.TabStop = true;
            this.rdoReverb.Text = "Reverb";
            this.rdoReverb.UseVisualStyleBackColor = true;
            // 
            // rdoGargle
            // 
            this.rdoGargle.AutoSize = true;
            this.rdoGargle.Checked = true;
            this.rdoGargle.Location = new System.Drawing.Point(18, 165);
            this.rdoGargle.Name = "rdoGargle";
            this.rdoGargle.Size = new System.Drawing.Size(98, 33);
            this.rdoGargle.TabIndex = 3;
            this.rdoGargle.TabStop = true;
            this.rdoGargle.Text = "Gargle";
            this.rdoGargle.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 366);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(991, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Location = new System.Drawing.Point(12, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 322);
            this.panel2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 388);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEffects;
        private System.Windows.Forms.Button btnStopEffects;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoReverb;
        private System.Windows.Forms.RadioButton rdoEcho;
        private System.Windows.Forms.RadioButton rdoDistortion;
        private System.Windows.Forms.RadioButton rdoGargle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
    }
}

