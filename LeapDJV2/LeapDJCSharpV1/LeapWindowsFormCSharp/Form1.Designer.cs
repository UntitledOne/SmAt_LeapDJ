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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playListR = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.djTimer = new System.Windows.Forms.Timer(this.components);
            this.volumeBarR = new System.Windows.Forms.TrackBar();
            this.volumeLabelR = new System.Windows.Forms.Label();
            this.onOffLabelR = new System.Windows.Forms.Label();
            this.volumeBarL = new System.Windows.Forms.TrackBar();
            this.onOffLabelL = new System.Windows.Forms.Label();
            this.volumeLabelL = new System.Windows.Forms.Label();
            this.DistortionR = new System.Windows.Forms.Label();
            this.distortionLabelR = new System.Windows.Forms.Label();
            this.reverbLabelR = new System.Windows.Forms.Label();
            this.echoLabelR = new System.Windows.Forms.Label();
            this.gargleLabelR = new System.Windows.Forms.Label();
            this.reverbR = new System.Windows.Forms.Label();
            this.echoR = new System.Windows.Forms.Label();
            this.gargleR = new System.Windows.Forms.Label();
            this.addButtonR = new System.Windows.Forms.Button();
            this.removeButtonR = new System.Windows.Forms.Button();
            this.playListL = new System.Windows.Forms.ListBox();
            this.removeButtonL = new System.Windows.Forms.Button();
            this.addButtonL = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.discR = new System.Windows.Forms.PictureBox();
            this.discL = new System.Windows.Forms.PictureBox();
            this.masterVolumeBar = new System.Windows.Forms.TrackBar();
            this.masterVolumeLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBarL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterVolumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // playListR
            // 
            this.playListR.FormattingEnabled = true;
            this.playListR.Location = new System.Drawing.Point(575, 311);
            this.playListR.Name = "playListR";
            this.playListR.Size = new System.Drawing.Size(197, 212);
            this.playListR.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // djTimer
            // 
            this.djTimer.Enabled = true;
            this.djTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // volumeBarR
            // 
            this.volumeBarR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.volumeBarR.Enabled = false;
            this.volumeBarR.Location = new System.Drawing.Point(530, 397);
            this.volumeBarR.Maximum = 100;
            this.volumeBarR.Name = "volumeBarR";
            this.volumeBarR.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeBarR.Size = new System.Drawing.Size(45, 126);
            this.volumeBarR.TabIndex = 4;
            this.volumeBarR.TabStop = false;
            this.volumeBarR.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.volumeBarR.Value = 100;
            // 
            // volumeLabelR
            // 
            this.volumeLabelR.AutoSize = true;
            this.volumeLabelR.BackColor = System.Drawing.Color.Transparent;
            this.volumeLabelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeLabelR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.volumeLabelR.Location = new System.Drawing.Point(508, 457);
            this.volumeLabelR.Name = "volumeLabelR";
            this.volumeLabelR.Size = new System.Drawing.Size(25, 13);
            this.volumeLabelR.TabIndex = 5;
            this.volumeLabelR.Text = "100";
            // 
            // onOffLabelR
            // 
            this.onOffLabelR.AutoSize = true;
            this.onOffLabelR.BackColor = System.Drawing.Color.Red;
            this.onOffLabelR.Location = new System.Drawing.Point(758, 296);
            this.onOffLabelR.Name = "onOffLabelR";
            this.onOffLabelR.Size = new System.Drawing.Size(13, 13);
            this.onOffLabelR.TabIndex = 6;
            this.onOffLabelR.Text = "  ";
            // 
            // volumeBarL
            // 
            this.volumeBarL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.volumeBarL.Enabled = false;
            this.volumeBarL.Location = new System.Drawing.Point(220, 397);
            this.volumeBarL.Maximum = 100;
            this.volumeBarL.Name = "volumeBarL";
            this.volumeBarL.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeBarL.Size = new System.Drawing.Size(45, 126);
            this.volumeBarL.TabIndex = 7;
            this.volumeBarL.TabStop = false;
            this.volumeBarL.Value = 100;
            // 
            // onOffLabelL
            // 
            this.onOffLabelL.AutoSize = true;
            this.onOffLabelL.BackColor = System.Drawing.Color.Red;
            this.onOffLabelL.Location = new System.Drawing.Point(12, 295);
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
            this.volumeLabelL.Location = new System.Drawing.Point(249, 457);
            this.volumeLabelL.Name = "volumeLabelL";
            this.volumeLabelL.Size = new System.Drawing.Size(25, 13);
            this.volumeLabelL.TabIndex = 9;
            this.volumeLabelL.Text = "100";
            // 
            // DistortionR
            // 
            this.DistortionR.AutoSize = true;
            this.DistortionR.BackColor = System.Drawing.Color.Transparent;
            this.DistortionR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistortionR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DistortionR.Location = new System.Drawing.Point(499, 311);
            this.DistortionR.Name = "DistortionR";
            this.DistortionR.Size = new System.Drawing.Size(51, 13);
            this.DistortionR.TabIndex = 10;
            this.DistortionR.Text = "Distortion";
            // 
            // distortionLabelR
            // 
            this.distortionLabelR.AutoSize = true;
            this.distortionLabelR.BackColor = System.Drawing.Color.Red;
            this.distortionLabelR.Location = new System.Drawing.Point(556, 311);
            this.distortionLabelR.Name = "distortionLabelR";
            this.distortionLabelR.Size = new System.Drawing.Size(13, 13);
            this.distortionLabelR.TabIndex = 11;
            this.distortionLabelR.Text = "  ";
            // 
            // reverbLabelR
            // 
            this.reverbLabelR.AutoSize = true;
            this.reverbLabelR.BackColor = System.Drawing.Color.Red;
            this.reverbLabelR.Location = new System.Drawing.Point(556, 333);
            this.reverbLabelR.Name = "reverbLabelR";
            this.reverbLabelR.Size = new System.Drawing.Size(13, 13);
            this.reverbLabelR.TabIndex = 12;
            this.reverbLabelR.Text = "  ";
            // 
            // echoLabelR
            // 
            this.echoLabelR.AutoSize = true;
            this.echoLabelR.BackColor = System.Drawing.Color.Red;
            this.echoLabelR.Location = new System.Drawing.Point(556, 355);
            this.echoLabelR.Name = "echoLabelR";
            this.echoLabelR.Size = new System.Drawing.Size(13, 13);
            this.echoLabelR.TabIndex = 13;
            this.echoLabelR.Text = "  ";
            // 
            // gargleLabelR
            // 
            this.gargleLabelR.AutoSize = true;
            this.gargleLabelR.BackColor = System.Drawing.Color.Red;
            this.gargleLabelR.Location = new System.Drawing.Point(556, 377);
            this.gargleLabelR.Name = "gargleLabelR";
            this.gargleLabelR.Size = new System.Drawing.Size(13, 13);
            this.gargleLabelR.TabIndex = 14;
            this.gargleLabelR.Text = "  ";
            // 
            // reverbR
            // 
            this.reverbR.AutoSize = true;
            this.reverbR.BackColor = System.Drawing.Color.Transparent;
            this.reverbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reverbR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reverbR.Location = new System.Drawing.Point(508, 333);
            this.reverbR.Name = "reverbR";
            this.reverbR.Size = new System.Drawing.Size(42, 13);
            this.reverbR.TabIndex = 15;
            this.reverbR.Text = "Reverb";
            // 
            // echoR
            // 
            this.echoR.AutoSize = true;
            this.echoR.BackColor = System.Drawing.Color.Transparent;
            this.echoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.echoR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.echoR.Location = new System.Drawing.Point(518, 355);
            this.echoR.Name = "echoR";
            this.echoR.Size = new System.Drawing.Size(32, 13);
            this.echoR.TabIndex = 16;
            this.echoR.Text = "Echo";
            // 
            // gargleR
            // 
            this.gargleR.AutoSize = true;
            this.gargleR.BackColor = System.Drawing.Color.Transparent;
            this.gargleR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gargleR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gargleR.Location = new System.Drawing.Point(512, 377);
            this.gargleR.Name = "gargleR";
            this.gargleR.Size = new System.Drawing.Size(38, 13);
            this.gargleR.TabIndex = 17;
            this.gargleR.Text = "Gargle";
            // 
            // addButtonR
            // 
            this.addButtonR.Location = new System.Drawing.Point(601, 529);
            this.addButtonR.Name = "addButtonR";
            this.addButtonR.Size = new System.Drawing.Size(75, 23);
            this.addButtonR.TabIndex = 18;
            this.addButtonR.Text = "Add Song";
            this.addButtonR.UseVisualStyleBackColor = true;
            this.addButtonR.Click += new System.EventHandler(this.addButtonR_Click);
            // 
            // removeButtonR
            // 
            this.removeButtonR.Location = new System.Drawing.Point(682, 529);
            this.removeButtonR.Name = "removeButtonR";
            this.removeButtonR.Size = new System.Drawing.Size(90, 23);
            this.removeButtonR.TabIndex = 19;
            this.removeButtonR.Text = "Remove Song";
            this.removeButtonR.UseVisualStyleBackColor = true;
            this.removeButtonR.Click += new System.EventHandler(this.removeButtonR_Click);
            // 
            // playListL
            // 
            this.playListL.FormattingEnabled = true;
            this.playListL.Location = new System.Drawing.Point(12, 311);
            this.playListL.Name = "playListL";
            this.playListL.Size = new System.Drawing.Size(197, 212);
            this.playListL.TabIndex = 20;
            // 
            // removeButtonL
            // 
            this.removeButtonL.Location = new System.Drawing.Point(93, 529);
            this.removeButtonL.Name = "removeButtonL";
            this.removeButtonL.Size = new System.Drawing.Size(90, 23);
            this.removeButtonL.TabIndex = 22;
            this.removeButtonL.Text = "Remove Song";
            this.removeButtonL.UseVisualStyleBackColor = true;
            // 
            // addButtonL
            // 
            this.addButtonL.Location = new System.Drawing.Point(12, 529);
            this.addButtonL.Name = "addButtonL";
            this.addButtonL.Size = new System.Drawing.Size(75, 23);
            this.addButtonL.TabIndex = 21;
            this.addButtonL.Text = "Add Song";
            this.addButtonL.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("AR DESTINE", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(3, 3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(147, 44);
            this.titleLabel.TabIndex = 23;
            this.titleLabel.Text = "LeapDJ";
            // 
            // discR
            // 
            this.discR.BackColor = System.Drawing.Color.Transparent;
            this.discR.Image = ((System.Drawing.Image)(resources.GetObject("discR.Image")));
            this.discR.InitialImage = ((System.Drawing.Image)(resources.GetObject("discR.InitialImage")));
            this.discR.Location = new System.Drawing.Point(559, 109);
            this.discR.Name = "discR";
            this.discR.Size = new System.Drawing.Size(200, 200);
            this.discR.TabIndex = 25;
            this.discR.TabStop = false;
            // 
            // discL
            // 
            this.discL.BackColor = System.Drawing.Color.Transparent;
            this.discL.Image = ((System.Drawing.Image)(resources.GetObject("discL.Image")));
            this.discL.InitialImage = ((System.Drawing.Image)(resources.GetObject("discL.InitialImage")));
            this.discL.Location = new System.Drawing.Point(24, 109);
            this.discL.Name = "discL";
            this.discL.Size = new System.Drawing.Size(200, 200);
            this.discL.TabIndex = 26;
            this.discL.TabStop = false;
            // 
            // masterVolumeBar
            // 
            this.masterVolumeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.masterVolumeBar.Enabled = false;
            this.masterVolumeBar.Location = new System.Drawing.Point(280, 515);
            this.masterVolumeBar.Maximum = 100;
            this.masterVolumeBar.Name = "masterVolumeBar";
            this.masterVolumeBar.Size = new System.Drawing.Size(227, 45);
            this.masterVolumeBar.TabIndex = 27;
            this.masterVolumeBar.TabStop = false;
            this.masterVolumeBar.Value = 100;
            // 
            // masterVolumeLabel
            // 
            this.masterVolumeLabel.AutoSize = true;
            this.masterVolumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.masterVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterVolumeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.masterVolumeLabel.Location = new System.Drawing.Point(380, 543);
            this.masterVolumeLabel.Name = "masterVolumeLabel";
            this.masterVolumeLabel.Size = new System.Drawing.Size(25, 13);
            this.masterVolumeLabel.TabIndex = 28;
            this.masterVolumeLabel.Text = "100";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "NextSong";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(287, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Last Song";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.masterVolumeLabel);
            this.Controls.Add(this.masterVolumeBar);
            this.Controls.Add(this.discL);
            this.Controls.Add(this.discR);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.removeButtonL);
            this.Controls.Add(this.addButtonL);
            this.Controls.Add(this.playListL);
            this.Controls.Add(this.removeButtonR);
            this.Controls.Add(this.addButtonR);
            this.Controls.Add(this.gargleR);
            this.Controls.Add(this.echoR);
            this.Controls.Add(this.reverbR);
            this.Controls.Add(this.gargleLabelR);
            this.Controls.Add(this.echoLabelR);
            this.Controls.Add(this.reverbLabelR);
            this.Controls.Add(this.distortionLabelR);
            this.Controls.Add(this.DistortionR);
            this.Controls.Add(this.volumeLabelL);
            this.Controls.Add(this.onOffLabelL);
            this.Controls.Add(this.volumeBarL);
            this.Controls.Add(this.onOffLabelR);
            this.Controls.Add(this.volumeLabelR);
            this.Controls.Add(this.volumeBarR);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playListR);
            this.Name = "Form1";
            this.Text = "LeapDJ V3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumeBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBarL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterVolumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playListR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer djTimer;
        private System.Windows.Forms.TrackBar volumeBarR;
        private System.Windows.Forms.Label volumeLabelR;
        private System.Windows.Forms.Label onOffLabelR;
        private System.Windows.Forms.TrackBar volumeBarL;
        private System.Windows.Forms.Label onOffLabelL;
        private System.Windows.Forms.Label volumeLabelL;
        private System.Windows.Forms.Label DistortionR;
        private System.Windows.Forms.Label distortionLabelR;
        private System.Windows.Forms.Label reverbLabelR;
        private System.Windows.Forms.Label echoLabelR;
        private System.Windows.Forms.Label gargleLabelR;
        private System.Windows.Forms.Label reverbR;
        private System.Windows.Forms.Label echoR;
        private System.Windows.Forms.Label gargleR;
        private System.Windows.Forms.Button addButtonR;
        private System.Windows.Forms.Button removeButtonR;
        private System.Windows.Forms.ListBox playListL;
        private System.Windows.Forms.Button removeButtonL;
        private System.Windows.Forms.Button addButtonL;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox discR;
        private System.Windows.Forms.PictureBox discL;
        private System.Windows.Forms.TrackBar masterVolumeBar;
        private System.Windows.Forms.Label masterVolumeLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

