using UnityEngine;

public class SliderBackgroundMusic : SliderVolume
{
    protected override void ChangeVolume(float volume)
    {
        
        if(ToggleMuteChange.IsMuted != true)
        Mixer.audioMixer.SetFloat(CommandBackGroundMusic, Mathf.Lerp(-80, 0, volume));
    }
}