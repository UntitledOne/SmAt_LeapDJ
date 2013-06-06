using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Leap;
using System.Media;
using irrKlang_Tester;

namespace LeapWindowsFormCSharp
{
    class birdSongListener : Listener
    {
        private delegate void writeLineDel(string line);

        private Object thisLock;
        private SoundPlayer soundPlayer;
        private String[] songNames;

        private int currentlyPlaying;
        private int tracksCount;
        private int volume;
        private bool isPlaying;

        private irrKlangClass song;

        private double lastXPosition;

        public birdSongListener(SoundPlayer soundPlayer, String[] songNames, int playing, irrKlangClass song)
        {
            this.soundPlayer = soundPlayer;
            thisLock = new Object();
            this.songNames = songNames;
            currentlyPlaying = playing;
            tracksCount = songNames.Length;
            this.song = song;

            volume = 100;
        }
        //GETS SETS////////////////////////////////////////////////////////////////////////////////////
        public int getCurrentlyPlaying()
        {
            return currentlyPlaying;
        }

        public void setCurrentlyPlaying(int currentlyPlaying)
        {
            this.currentlyPlaying = currentlyPlaying;
        }

        public int getTracksCount()
        {
            return tracksCount;
        }

        public void setTracksCount(int tracksCount)
        {
            this.tracksCount = tracksCount;
        }

        public void lineToBox(string line)
        {
            //displayBox.Items.Add(line);
        }

        public int getVolume()
        {
            return volume;
        }

        public void setVolume(int volume)
        {
            this.volume = volume;
        }

        public bool getIsPlaying()
        {
            return isPlaying;
        }

        public void setIsPlaying(bool isPlaying)
        {
            this.isPlaying = isPlaying;
        }
        //MAIN CODE BEGINS HERE////////////////////////////////////////////////////////////////////////////////////
        private void SafeWriteLine(String line)
        {
            lock (thisLock)
            {
                writeLineDel writeLineDel = new writeLineDel(lineToBox);
                //displayBox.Invoke(writeLineDel, line);
            }
        }

        public override void OnInit(Controller controller)
        {
            //SafeWriteLine("OnInit Raised");
        }

        public override void OnConnect(Controller controller)
        {
            //SafeWriteLine("OnConnect Raised");
            controller.EnableGesture(Gesture.GestureType.TYPECIRCLE);
            controller.EnableGesture(Gesture.GestureType.TYPEKEYTAP);
            controller.EnableGesture(Gesture.GestureType.TYPESCREENTAP);
            controller.EnableGesture(Gesture.GestureType.TYPESWIPE);
        }

        public override void OnDisconnect(Controller controller)
        {
            //SafeWriteLine("OnDisconnect Raised");
        }

        public override void OnExit(Controller controller)
        {
            //SafeWriteLine("On Exit Raised");
        }

        public override void OnFrame(Controller controller)
        {
            // Get the most recent frame and report some basic information
            Frame frame = controller.Frame();

            //Get hand information
            Hand hand = frame.Hands[0];

            //get finger information
            FingerList fingers = hand.Fingers;
            int fingercount = fingers.Count;

            // Get gestures
            GestureList gestures = frame.Gestures();
            for (int i = 0; i < gestures.Count; i++)
            {
                Gesture gesture = gestures[i];

                switch (gesture.Type)
                {
                    case Gesture.GestureType.TYPECIRCLE:
                        CircleGesture circle = new CircleGesture(gesture);
                        if (circle.Pointable.Direction.AngleTo(circle.Normal) <= Math.PI / 4)
                        {
                            volume++; //clockwise
                            if (volume > 100) { volume = 100; }
                        }
                        else
                        {
                            volume--; //anticlockwise
                            if (volume < 0) { volume = 0; }
                        }
                        float newVolume = (float)(volume / 100.0);
                        setVolume(Convert.ToInt32(newVolume));

                        //volumeLabel.Text = Convert.ToString(newVolume);
                        break;
                    case Gesture.GestureType.TYPEKEYTAP: //Play a song
                        if (isPlaying == true)
                        {
                            song.stopPlaying();
                            isPlaying = false;
                        }
                        else
                        {
                            song.stopPlaying();
                            song.startPlaying();
                            isPlaying = true;
                        }
                        break;
                    case Gesture.GestureType.TYPESCREENTAP: //Stop a song
                        //FREE SPACE
                        break;
                    case Gesture.GestureType.TYPESWIPE:
                        Vector myPalmPosition = hand.PalmPosition;
			            double currentPalmPositionX = myPalmPosition.x;

                        if (currentPalmPositionX > lastXPosition) //Add in a +n value so its the swipe is a certian size
		            	{
                            currentlyPlaying--; //Go back
                            currentlyPlaying = currentlyPlaying % tracksCount;
                            if (currentlyPlaying < 0) { currentlyPlaying = 0; } //boundsCheckFix
		            	}
		            	else
		            	{
                            currentlyPlaying++; //Go Forward
                            currentlyPlaying = currentlyPlaying % tracksCount;
                            if (currentlyPlaying > tracksCount) { currentlyPlaying = tracksCount; } //boundsCheckFix
	            		}
                        lastXPosition = currentPalmPositionX;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
