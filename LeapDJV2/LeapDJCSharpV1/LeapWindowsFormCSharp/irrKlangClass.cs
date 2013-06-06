using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IrrKlang;
using LeapWindowsFormCSharp;
using System.Media;
using Leap;

namespace irrKlang_Tester
{
    class irrKlangClass : Listener
    {
        ISoundEngine engine;
        ISoundEngine effectsEngine;
        String fileName;
        private bool isPlaying;
        private double lastXPosition;
        private int trackCurrentlyPlaying;
        private int tracksCount;

        private bool distortionOnOff;
        private bool reverbOnOff;
        private bool echoOnOff;
        private bool gargleOnOff;

        public irrKlangClass(String fileName, int tracksCount)
        {
            engine = new ISoundEngine();
            this.fileName = fileName;

            isPlaying = false;
            trackCurrentlyPlaying = 0;
            this.tracksCount = tracksCount;
        }

        public void startPlaying()
        {
            engine.Play2D(fileName, true);  // the boolean is playLooped
        }

        public void stopPlaying()
        {
            engine.StopAllSounds();
        }

        public void SetVolume(float newVolume)
        {
            engine.SoundVolume = newVolume;
        }

        public string GetVolume()
        {
            return engine.SoundVolume.ToString();
        }


        //NEWGETSSETS===========================================================================
        public void setDistortionOnOff(bool distortionOnOff) 
        { 
            this.distortionOnOff = distortionOnOff; 
        }

        public bool getDistortionOnOff() 
        {
            return this.distortionOnOff; 
        }

        public void setReverbOnOff(bool reverbOnOff) 
        { 
            this.reverbOnOff = reverbOnOff; 
        }

        public bool getReverbOnOff() 
        {
            return this.reverbOnOff; 
        }

        public void setEchoOnOff(bool echoOnOff) 
        {
            this.echoOnOff = echoOnOff; 
        }

        public bool getEchoOnOff() 
        { 
            return this.echoOnOff; 
        }
        
        public void setGargleOnOff(bool gargleOnOff) 
        {
            this.gargleOnOff = gargleOnOff; 
        }
        
        public bool getGargleOnOff() 
        {
            return this.gargleOnOff; 
        }
        
        public String getFileName()
        {
            return fileName;
        }

        public void setFileName(String fileName)
        {
            this.fileName = fileName;
        }

        public int getTrackCurrentlyPlaying()
        {
            return trackCurrentlyPlaying;
        }

        public void setTrackCurrentlyPlaying(int currentlyPlaying)
        {
            this.trackCurrentlyPlaying = currentlyPlaying;
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

        public bool getIsPlaying()
        {
            return isPlaying;
        }

        public void setIsPlaying(bool isPlaying)
        {
            this.isPlaying = isPlaying;
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
        //MAIN CODE BEGINS HERE=================================================================================
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
                    case Gesture.GestureType.TYPECIRCLE: //increase/reduce volume
                        float newVolume = Convert.ToSingle(GetVolume());

                        CircleGesture circle = new CircleGesture(gesture);
                        if (circle.Pointable.Direction.AngleTo(circle.Normal) <= Math.PI / 4)//increase (clockwise)
                        {
                            newVolume += 0.01f;
                            if (newVolume > 1) { newVolume = 1; }//bounds fixer
                        }
                        else//decrease (anticlockwise)
                        {
                            newVolume -= 0.01f;
                            if (newVolume < 0) { newVolume = 0; }//bounds fixer
                        }
                        SetVolume(newVolume);
                        break;
                    case Gesture.GestureType.TYPEKEYTAP: //Play a song
                        if (isPlaying == true)
                        {
                            stopPlaying();
                            isPlaying = false;
                        }
                        else
                        {
                            stopPlaying();
                            startPlaying();
                            isPlaying = true;
                        }
                        break;
                    case Gesture.GestureType.TYPESCREENTAP: //Stop all sound effects
                        StopSoundEffects();
                        break;
                    case Gesture.GestureType.TYPESWIPE: //SWIPE GESTURES
                        switch (fingercount)
                        {
                            case 5: //NEXT/LAST SONG
                            Vector myPalmPosition = hand.PalmPosition;
                            double currentPalmPositionX = myPalmPosition.x;

                            if (currentPalmPositionX > lastXPosition) //Add in a +n value so its the swipe is a certian size
                            {
                                trackCurrentlyPlaying--; //Go back
                                trackCurrentlyPlaying = trackCurrentlyPlaying % tracksCount;
                                if (trackCurrentlyPlaying < 0) { trackCurrentlyPlaying = 0; } //boundsCheckFix
                            }
                            else
                            {
                                trackCurrentlyPlaying++; //Go Forward
                                trackCurrentlyPlaying = trackCurrentlyPlaying % tracksCount;
                                if (trackCurrentlyPlaying > tracksCount) { trackCurrentlyPlaying = 0; } //boundsCheckFix
                            }
                            lastXPosition = currentPalmPositionX;
                                break;
                            case 4://GARGLE
                                DoSoundEffects(ESoundEffects.GARGLE);
                                break;
                            case 3://REVERB
                                DoSoundEffects(ESoundEffects.REVERB);
                                break;
                            case 2://ECHO
                                DoSoundEffects(ESoundEffects.ECHO);
                                break;
                            case 1://DISTORTION
                                DoSoundEffects(ESoundEffects.DISTORTION);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        public void DoSoundEffects(ESoundEffects fx)
        {
            //effectsEngine = new ISoundEngine();

            // boolean args are 1) looped 2) start paused 3) enable sound effects
            //ISound effectTester = effectsEngine.Play2D(fileName, true, false, StreamMode.AutoDetect, true);

            //ISoundEffectControl effectsControl = effectTester.SoundEffectControl;

            switch (fx)
            {
                case ESoundEffects.DISTORTION:
                    distortionOnOff = true;
                    //effectsControl.EnableDistortionSoundEffect();
                    break;
                case ESoundEffects.ECHO:
                    echoOnOff = true;
                    //effectsControl.EnableEchoSoundEffect();
                    break;
                case ESoundEffects.REVERB:
                    reverbOnOff = true;
                    //effectsControl.EnableWavesReverbSoundEffect();
                    break;
                case ESoundEffects.GARGLE:
                    gargleOnOff = true;
                    //effectsControl.EnableGargleSoundEffect();
                    break;
            }
        } // end DoSoundEffects

        //=============================================================================
        public void StopSoundEffects()
        {
            distortionOnOff = false;
            reverbOnOff = false;
            echoOnOff = false;
            gargleOnOff = false;
            //effectsEngine.StopAllSounds();
        }
    }
}
