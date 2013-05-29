using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace irrKlang_Tester
{
    public enum ESoundEffects { DISTORTION, ECHO, REVERB, GARGLE }

    public partial class Form1 : Form
    {
        irrKlangClass irrKlangObject;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            irrKlangObject = new irrKlangClass();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            irrKlangObject.startPlaying();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            irrKlangObject.stopPlaying();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float newVolume = (float)(trackBar1.Value / 100.0);
            irrKlangObject.SetVolume(newVolume);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = irrKlangObject.GetVolume();
        }

        private void btnEffects_Click(object sender, EventArgs e)
        {
            if (rdoDistortion.Checked)
                irrKlangObject.DoSoundEffects(ESoundEffects.DISTORTION);
            else if (rdoEcho.Checked)
                irrKlangObject.DoSoundEffects(ESoundEffects.ECHO);
            else if (rdoReverb.Checked)
                irrKlangObject.DoSoundEffects(ESoundEffects.REVERB);
            else
                irrKlangObject.DoSoundEffects(ESoundEffects.GARGLE);
        }

        private void btnStopEffects_Click(object sender, EventArgs e)
        {
            irrKlangObject.StopSoundEffects();
        }
    }
}
