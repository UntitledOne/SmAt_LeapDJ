using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Leap;
using System.Media;
using irrKlang_Tester;
using System.Drawing.Drawing2D;

//NB:
// Add a reference to LeapCSharp.NET4.0.dll to the project, but make sure that Leap.dll, 
// LeapCSharp.dll & LeapCSharp.NET4.0.dll are all in the Debug folder. Must match machine configuration
// as well.


namespace LeapWindowsFormCSharp
{
    public enum ESoundEffects { DISTORTION, ECHO, REVERB, GARGLE }

    public partial class Form1 : Form
    {
        //declare
        SoundPlayer player;
        String[] playListSongNamesR = {  "pendulum - crush.mp3", 
                                "pendulum - encoder.mp3", 
                                "pendulum - under the waves.mp3", 
                                "Pendulum - Watercolour.mp3"};

        // Create a sample listener and controller;
        Controller controller;

        irrKlangClass musicPlayer;

        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap RotateImageByAngle(Image oldBitmap, float angle)
        {
            var newBitmap = new Bitmap(oldBitmap.Width, oldBitmap.Height);
            newBitmap.SetResolution(oldBitmap.HorizontalResolution, oldBitmap.VerticalResolution);
            var graphics = Graphics.FromImage(newBitmap);
            graphics.TranslateTransform((float)oldBitmap.Width / 2, (float)oldBitmap.Height / 2);
            graphics.RotateTransform(angle);
            graphics.TranslateTransform(-(float)oldBitmap.Width / 2, -(float)oldBitmap.Height / 2);
            graphics.DrawImage(oldBitmap, new Point(0, 0));
            return newBitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer(playListSongNamesR[0]);
            // Create a sample listener and controller
            //SampleListener listener = new SampleListener(listBox1);
            controller = new Controller();
            
            //soundEffectsLibrary
            musicPlayer = new irrKlangClass(playListSongNamesR[0],playListSongNamesR.Length);

            playListR.Items.AddRange(playListSongNamesR);
            playListR.SelectedIndex = playListR.FindString(playListSongNamesR[musicPlayer.getTrackCurrentlyPlaying()]);

            // Have the sample listener receive events from the controller
            controller.AddListener(musicPlayer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musicPlayer.setIsPlaying(true);
            musicPlayer.stopPlaying();
            musicPlayer.startPlaying();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musicPlayer.setIsPlaying(false);
            musicPlayer.stopPlaying();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //RIGHT HAND FUNCTIONS/////////////////////////////////////////////////////////////////////////////////
            //OnOffSwitch
            if (musicPlayer.getIsPlaying() == false)
            {
                onOffLabelR.BackColor = Color.Red;//off
            }
            else
            {
                Bitmap bitmap = (Bitmap)discR.Image;
                discR.Image = (Bitmap)(RotateImageByAngle(discR.Image, 5));
                onOffLabelR.BackColor = Color.LightGreen;//on
            }
            //Distortion
            if (musicPlayer.getDistortionOnOff() == false)
            {
                distortionLabelR.BackColor = Color.Red;//off
            }
            else
            {
                distortionLabelR.BackColor = Color.LightGreen;//on
            }
            //reverb
            if (musicPlayer.getReverbOnOff() == false)
            {
                reverbLabelR.BackColor = Color.Red;//off
            }
            else
            {
                reverbLabelR.BackColor = Color.LightGreen;//on
            }
            //echo
            if (musicPlayer.getEchoOnOff() == false)
            {
                echoLabelR.BackColor = Color.Red;//off
            }
            else
            {
                echoLabelR.BackColor = Color.LightGreen;//on
            }
            //gargle
            if (musicPlayer.getGargleOnOff() == false)
            {
                gargleLabelR.BackColor = Color.Red;//off
            }
            else
            {
                gargleLabelR.BackColor = Color.LightGreen;//on
            }

            //Right Volume Labels
            volumeLabelR.Text = Convert.ToString(musicPlayer.GetVolume());
            float rightValue = Convert.ToSingle(volumeLabelR.Text);
            rightValue = rightValue * 100;
            volumeBarR.Value = Convert.ToInt32(rightValue);

            //playlist
            int currentSong = musicPlayer.getTrackCurrentlyPlaying();

            playListR.SelectedIndex = playListR.FindString(playListSongNamesR[currentSong]);

            musicPlayer.setFileName(playListSongNamesR[musicPlayer.getTrackCurrentlyPlaying()]);
        }

        private void addButtonR_Click(object sender, EventArgs e)//AddSong
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                playListR.Items.Add(openFile.FileName);
            }
        }

        private void removeButtonR_Click(object sender, EventArgs e)//RemoveSong
        {
            int currentSong = musicPlayer.getTrackCurrentlyPlaying();
            playListR.Items.RemoveAt(currentSong);
            playListR.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int newTrack = musicPlayer.getTrackCurrentlyPlaying();
            newTrack++;
            newTrack = newTrack % playListSongNamesR.Length;

            if (newTrack > playListSongNamesR.Length) { newTrack = 0; }
            musicPlayer.setTrackCurrentlyPlaying(newTrack);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int newTrack = musicPlayer.getTrackCurrentlyPlaying();
            newTrack--;
            newTrack = newTrack % playListSongNamesR.Length;

            if (newTrack < 0) { newTrack = 0; }
            musicPlayer.setTrackCurrentlyPlaying(newTrack);
        }
    }
}
