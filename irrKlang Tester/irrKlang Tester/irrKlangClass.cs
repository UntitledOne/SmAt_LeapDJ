using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IrrKlang;

namespace irrKlang_Tester
{
    class irrKlangClass
    {
        ISoundEngine engine;
        ISoundEngine effectsEngine;

        public irrKlangClass()
        {
            engine = new ISoundEngine();
        }

        public void startPlaying()
        {
                engine.Play2D("curlew.wav", true);  // the boolean is playLooped
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


        //===========================================================================
        public void DoSoundEffects(ESoundEffects fx)
        {
            effectsEngine = new ISoundEngine();

            // boolean args are 1) looped 2) start paused 3) enable sound effects
            ISound effectTester = effectsEngine.Play2D("curlew.wav", true, false, StreamMode.AutoDetect, true);

            ISoundEffectControl effectsControl = effectTester.SoundEffectControl;

            switch(fx)
            {
                case ESoundEffects.DISTORTION:
                    effectsControl.EnableDistortionSoundEffect();
                    break;
                case ESoundEffects.ECHO:
                    effectsControl.EnableEchoSoundEffect();
                    break;
                case ESoundEffects.REVERB:
                    effectsControl.EnableWavesReverbSoundEffect();
                    break;
                case ESoundEffects.GARGLE:
                    effectsControl.EnableGargleSoundEffect();
                    break;
            }
        } // end DoSoundEffects

        //=============================================================================
        public void StopSoundEffects()
        {
            effectsEngine.StopAllSounds();
        }
    }
}
