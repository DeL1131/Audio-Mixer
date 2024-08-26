using UnityEngine;

public class SliderVolumeSelectedMusic : SliderVolume
{
    protected override void ChangeVolume(float volume)
    {
        if (ToggleMuteChange.IsMuted != true)
            Mixer.audioMixer.SetFloat(CommandSelectedMusic, Mathf.Lerp(-80, 0, volume));
    }
}