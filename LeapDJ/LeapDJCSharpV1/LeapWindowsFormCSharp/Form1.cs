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
        String[] songNames = {  "pendulum - crush.mp3", 
                                "pendulum - encoder.mp3", 
                                "pendulum - under the waves.mp3", 
                                "Pendulum - Watercolour.mp3"};

        // Create a sample listener and controller;
        private birdSongListener musicPlayer;
        Controller controller;

        irrKlangClass irrKlangObject;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //soundEffectsLibrary
            irrKlangObject = new irrKlangClass(songNames[0]);

            player = new SoundPlayer(songNames[0]);
            // Create a sample listener and controller
            //SampleListener listener = new SampleListener(listBox1);
            musicPlayer = new birdSongListener(player, songNames, 0, irrKlangObject);
            controller = new Controller();

            // Have the sample listener receive events from the controller
            controller.AddListener(musicPlayer);

            playList.Items.AddRange(songNames);
            playList.SelectedIndex = playList.FindString(songNames[musicPlayer.getCurrentlyPlaying()]);            
        }

        /*
        public void onFrame(Controller controller, birdSongListener musicPlayer) //onFrame
        {
            listBox1.SelectedIndex = listBox1.FindString(songNames[musicPlayer.getCurrentlyPlaying()]);
            player = new SoundPlayer(songNames[musicPlayer.getCurrentlyPlaying()]);
            controller.AddListener(musicPlayer);
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            irrKlangObject.stopPlaying();
            irrKlangObject.startPlaying();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            irrKlangObject.stopPlaying();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (musicPlayer.getIsPlaying() == false)
            {
                onOffLabelR.BackColor = Color.Red;
            }
            else
            {
                onOffLabelR.BackColor = Color.LightGreen;
            }
            volumeLabelR.Text = Convert.ToString(musicPlayer.getVolume());
            volumeBarR.Value = musicPlayer.getVolume();
            int currentSong = musicPlayer.getCurrentlyPlaying();

            playList.SelectedIndex = playList.FindString(songNames[currentSong]);

            //irrKlangObject = new irrKlangClass(songNames[currentSong]);
            //musicPlayer = new birdSongListener(player, songNames, currentSong, irrKlangObject);

            //player = new SoundPlayer(songNames[currentSong]);
            //musicPlayer = new birdSongListener(player, songNames, currentSong);

            //controller = new Controller();
            //controller.AddListener(musicPlayer);
        }

        private void trackBar1_Scroll(object sender, EventArgs e) //Volume Label
        {
            float newVolume = (float)(volumeBarR.Value / 100.0);
            irrKlangObject.SetVolume(newVolume);
        }
    }
}
