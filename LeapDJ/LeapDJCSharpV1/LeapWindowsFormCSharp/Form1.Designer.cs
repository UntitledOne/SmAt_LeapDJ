namespace LeapWindowsFormCSharp
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
            this.playList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.djTimer = new System.Windows.Forms.Timer(this.components);
            this.detectionLabel = new System.Windows.Forms.Label();
            this.volumeBarR = new System.Windows.Forms.TrackBar();
            this.volumeLabelR = new System.Windows.Forms.Label();
            this.onOffLabelR = new System.Windows.Forms.Label();
            this.volumeBarL = new System.Windows.Forms.TrackBar();
            this.onOffLabelL = new System.Windows.Forms.Label();
            this.volumeLabelL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBarL)).BeginInit();
            this.SuspendLayout();
            // 
            // playList
            // 
            this.playList.FormattingEnabled = true;
            this.playList.Location = new System.Drawing.Point(300, 100);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(200, 290);
            this.playList.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // djTimer
            // 
            this.djTimer.Enabled = true;
            this.djTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // detectionLabel
            // 
            this.detectionLabel.AutoSize = true;
            this.detectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.detectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.detectionLabel.Location = new System.Drawing.Point(299, 30);
            this.detectionLabel.Name = "detectionLabel";
            this.detectionLabel.Size = new System.Drawing.Size(203, 29);
            this.detectionLabel.TabIndex = 3;
            this.detectionLabel.Text = "Perform an Action";
            // 
            // volumeBarR
            // 
            this.volumeBarR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.volumeBarR.Enabled = false;
            this.volumeBarR.Location = new System.Drawing.Point(519, 219);
            this.volumeBarR.Maximum = 100;
            this.volumeBarR.Name = "volumeBarR";
            this.volumeBarR.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeBarR.Size = new System.Drawing.Size(45, 171);
            this.volumeBarR.TabIndex = 4;
            this.volumeBarR.TabStop = false;
            this.volumeBarR.Value = 100;
            this.volumeBarR.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // volumeLabelR
            // 
            this.volumeLabelR.AutoSize = true;
            this.volumeLabelR.BackColor = System.Drawing.Color.Transparent;
            this.volumeLabelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeLabelR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.volumeLabelR.Location = new System.Drawing.Point(548, 296);
            this.volumeLabelR.Name = "volumeLabelR";
            this.volumeLabelR.Size = new System.Drawing.Size(25, 13);
            this.volumeLabelR.TabIndex = 5;
            this.volumeLabelR.Text = "100";
            // 
            // onOffLabelR
            // 
            this.onOffLabelR.AutoSize = true;
            this.onOffLabelR.BackColor = System.Drawing.Color.Red;
            this.onOffLabelR.Location = new System.Drawing.Point(487, 81);
            this.onOffLabelR.Name = "onOffLabelR";
            this.onOffLabelR.Size = new System.Drawing.Size(13, 13);
            this.onOffLabelR.TabIndex = 6;
            this.onOffLabelR.Text = "  ";
            // 
            // volumeBarL
            // 
            this.volumeBarL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.volumeBarL.Enabled = false;
            this.volumeBarL.Location = new System.Drawing.Point(249, 219);
            this.volumeBarL.Maximum = 100;
            this.volumeBarL.Name = "volumeBarL";
            this.volumeBarL.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeBarL.Size = new System.Drawing.Size(45, 171);
            this.volumeBarL.TabIndex = 7;
            this.volumeBarL.TabStop = false;
            this.volumeBarL.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.volumeBarL.Value = 100;
            // 
            // onOffLabelL
            // 
            this.onOffLabelL.AutoSize = true;
            this.onOffLabelL.BackColor = System.Drawing.Color.Red;
            this.onOffLabelL.Location = new System.Drawing.Point(301, 81);
            this.onOffLabelL.Name = "onOffLabelL";
            this.onOffLabelL.Size = new System.Drawing.Size(13, 13);
            this.onOffLabelL.TabIndex = 8;
            this.onOffLabelL.Text = "  ";
            // 
            // volumeLabelL
            // 
            this.volumeLabelL.AutoSize = true;
            this.volumeLabelL.BackColor = System.Drawing.Color.Transparent;
            this.volumeLabelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeLabelL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.volumeLabelL.Location = new System.Drawing.Point(228, 296);
            this.volumeLabelL.Name = "volumeLabelL";
            this.volumeLabelL.Size = new System.Drawing.Size(25, 13);
            this.volumeLabelL.TabIndex = 9;
            this.volumeLabelL.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.volumeLabelL);
            this.Controls.Add(this.onOffLabelL);
            this.Controls.Add(this.volumeBarL);
            this.Controls.Add(this.onOffLabelR);
            this.Controls.Add(this.volumeLabelR);
            this.Controls.Add(this.volumeBarR);
            this.Controls.Add(this.detectionLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playList);
            this.Name = "Form1";
            this.Text = "LeapDJ V1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumeBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBarL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer djTimer;
        private System.Windows.Forms.Label detectionLabel;
        private System.Windows.Forms.TrackBar volumeBarR;
        private System.Windows.Forms.Label volumeLabelR;
        private System.Windows.Forms.Label onOffLabelR;
        private System.Windows.Forms.TrackBar volumeBarL;
        private System.Windows.Forms.Label onOffLabelL;
        private System.Windows.Forms.Label volumeLabelL;
    }
}

